using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.Structure;
using Emgu.CV;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Net;
using OpenCvSharp;
using Tesseract;
using Point = OpenCvSharp.Point;

namespace WindowsFormsApp2
{
    public partial class parking : Form
    {
        bool _streaming;
        Capture _capture;
        NetworkStream stream = default(NetworkStream);
        TcpClient client;
        Thread clientThread;
        Label status; // 상태표시
        String _date;
        Bitmap NowImg; // 현재의 이미지
        Bitmap processedImg; // 처리가 가해진 이미지

        public parking()
        {
            InitializeComponent();
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            try
            {
                if (client.Connected)
                {   
                    stream.Close();
                    client.Close();
                    clientThread.Interrupt();
                    Application.ExitThread();
                    Application.Exit();
                }
                else
                {
                    Application.Exit();
                }
            }
            catch (Exception)
            {
                Application.Exit();
            }
        }

        private void parking_Load(object sender, EventArgs e)
        {
            _streaming = false;
            _capture = new Capture();
            timer1.Interval = 100; // 타이머 간격
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            datatimelabel.Text = DateTime.Now.ToString("F"); // F는 자세한 날짜 및 시간
            //Console.WriteLine(datatimelabel.Text);
            //Display(datatimelabel.Text);
        }

        private void btnServerConnect_Click(object sender, EventArgs e)
        {
            connectTcp();
            client = new TcpClient();
        }

        async void connectTcp()
        {
            status = connlabel; // 상태표시

            await Task.Run(() =>
            {
                try
                {
                    setLabel(status, "연결중...", Color.Transparent);
                    client.Connect(IPAddress.Parse("10.10.21.105"), 9001);
                    
                    stream = client.GetStream();
                    Display("Server connected");
                }
                catch (Exception e)
                {
                    MessageBox.Show("서버가 실행중이 아닙니다.", "연결실패");
                }
                if (client.Connected)
                {
                    setLabel(status, "연결성공", Color.LightSalmon);
                    IPHostEntry host;
                    string localip = "?";
                    host = Dns.GetHostEntry(Dns.GetHostName());

                    foreach(IPAddress ip in host.AddressList)
                    {
                        if(ip.AddressFamily.ToString() == "InterNetwork")
                        {
                            localip = ip.ToString();
                        }
                    }

                    byte[] buffer = Encoding.UTF8.GetBytes(localip);
                    stream.Write(buffer, 0, buffer.Length);

                    clientThread = new Thread(Receiver);
                    clientThread.IsBackground = true;
                    clientThread.Start();
                }
                else
                {
                    setLabel(status, "연결실패", Color.IndianRed);
                }
            });
        }
        private void setLabel(Label label, String text, Color backColor)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new EventHandler(delegate
                {
                    if (text != null) label.Text = text;
                    if (backColor != null) label.BackColor = backColor;
                }));
            }
            else
            {
                if (text != null) label.Text = text;
                if (backColor != null) label.BackColor = backColor;
            }
        }

        private void streaming(object sender, System.EventArgs e)
        {
            var img = _capture.QueryFrame().ToImage<Bgr, byte>();
            var bmp = img.Bitmap;
            pictureBoxcam.Image = bmp;
        }

        private void btncctv_Click(object sender, EventArgs e)
        {
            if (!_streaming)
            {
                Application.Idle += streaming;
                btncctv.Text = @"Stop CCTV";
                btncctv.ForeColor = Color.White;
                btncctv.BackColor = Color.Red;
            }

            else
            {
                Application.Idle -= streaming;
                btncctv.Text = @"Start CCTV";
                btncctv.ForeColor = Color.Black;
                btncctv.BackColor = Color.Gainsboro;
            }

            _streaming = !_streaming;
        }

        private void btncapture_Click(object sender, EventArgs e)
        {
            Bitmap Image = new Bitmap(pictureBoxcam.Image);
            NowImg = Image;
            //pictureBoxcapture.Image = pictureBoxcam.Image;
            this.pictureBoxcapture.Image = NowImg;
        }

        public Bitmap SelectImg()
        {
            /* 이미지 선택 메서드, 메모리 누수 방지를 위한 using 사용 */
            if (processedImg is null)
            {
                return NowImg;
            }
            else
            {
                return processedImg;
            }
        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void connlabel_Click(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            status = connlabel;
            if (!client.Connected)
            {
                MessageBox.Show("서버와의 연결 중이 아닙니다..", "메시지");
            }
            else
            {
                byte[] buffer = Encoding.UTF8.GetBytes(exitbtn.Text);
                stream.Write(buffer, 0, buffer.Length);
                stream.Flush();
                stream.Close();
                client.Close();
                clientThread.Interrupt();
                MessageBox.Show("서버와의 연결을 종료하였습니다.", "연결종료");
                setLabel(status, "연결종료", Color.IndianRed);
            }

        }

        void Display(string msg)
        {
            CheckForIllegalCrossThreadCalls = false;
            richTextBoxserverreply.AppendText(msg + "\r\n");
            richTextBoxserverreply.Select(richTextBoxserverreply.Text.Length, 0);
            richTextBoxserverreply.ScrollToCaret();
        }

        void Sender(string server)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(server);
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();
        }
        void Receiver()
        {
            status = connlabel;
            try
            {
                while (true)
                {
                    int bufferSize = client.ReceiveBufferSize;
                    byte[] buffer = new byte[bufferSize];
                    int bytes = stream.Read(buffer, 0, buffer.Length);
                    string msg = Encoding.UTF8.GetString(buffer, 0, bytes);
                    if(!isClassifyMsg(msg)) 
                        Display(msg);
                }
            }
            catch(IOException e)
            {
                setLabel(status, "연결종료", Color.IndianRed);
                MessageBox.Show("서버와 연결이 종료되었습니다.", "연결종료");
                stream.Close();
                client.Close();
                clientThread.Interrupt();
            }
        }
        void Classify(string server)
        {
            try
            {
                if (!client.Connected)
                {
                    MessageBox.Show("서버에 먼저 연결 해 주세요.");
                }
                else
                {

                    if (server.StartsWith(entrancebtn.Text))
                    {
                        Sender(server);
                    }

                    else if (server.StartsWith(carExitbtn.Text))
                    {
                        Sender(server);
                    }

                    else if (server.StartsWith(parkingstatusbtn.Text))
                    {
                        Sender(server);
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("서버와 연결되 있지 않습니다.", "연결종료");
            }
        }

        bool isClassifyMsg(string msg)
        {
            bool servermsg = true;

            if (msg.StartsWith("입차") || msg.StartsWith("출차"))
            {
                servermsg = true;
            }
            else if (msg.StartsWith("주차현황"))
            {
                parkingstatus.Items.Clear();
                char split = ' ';
                string[] parkinglist = msg.Split(split);
                foreach (string s in parkinglist)
                {
                    if (s.StartsWith("주차현황")) continue;
                    parkingstatus.Items.Add(s);
                }
            }
            else servermsg = false;

            return servermsg;
        }
        private void entrancebtn_Click(object sender, EventArgs e)
        {
            
            string entrance = entrancebtn.Text;
            string datetime = datatimelabel.Text;
            string carnumber = carnumbertext.Text;
            int numberlength = carnumber.Length;

            if (numberlength >= 7 && numberlength <= 8)
            {
                string entrycar = String.Concat(entrance, " ",datetime, " ", carnumber);
                Classify(entrycar);
            }
            else
            {
                MessageBox.Show("자동차번호를 제대로 입력 해야 합니다.", "전송실패");
            }
        }

        private void carExitbtn_Click(object sender, EventArgs e)
        {
            string exit = carExitbtn.Text;
            string datetime = datatimelabel.Text;
            string carnumber = carnumbertext.Text;
            int numberlength = carnumber.Length;

            if (numberlength >= 7 && numberlength <= 8)
            {
                string exitcar = String.Concat(exit, " ", datetime, " ", carnumber);
                Classify(exitcar);
            }
            else
            {
                MessageBox.Show("자동차번호를 제대로 입력 해야 합니다.", "전송실패");
            }
        }

        private void parkingstatusbtn_Click(object sender, EventArgs e)
        {
            string senddate = dateTimePicker1.Text; 
            string parkingstatus = parkingstatusbtn.Text;

            string parkinginformation = String.Concat(parkingstatus, " ", senddate);
            Classify(parkinginformation);
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime mydatetime = dateTimePicker1.Value;
            _date = mydatetime.ToString("yyyy/MM/dd");
            MessageBox.Show(_date, "선택 날짜");
            //DateTime dt = dateTimePicker1.Value;
            //string daterequest = string.Format("{0}년{1}월{2}일", dt.Year, dt.Month, dt.Day);
            //MessageBox.Show(daterequest, "선택 날짜");
            //string datereturn = daterequest;
            //return datereturn; 
        }

        private void btnBlur_Click(object sender, EventArgs e)
        {
            OpenCvSharp.Mat img = OpenCvSharp.Extensions.BitmapConverter.ToMat(SelectImg());
            OpenCvSharp.Mat result = new OpenCvSharp.Mat(); // 편집 후 이미지

            /* 가우시안 */
            Cv2.GaussianBlur(img, result, new OpenCvSharp.Size(3, 3), 0);
            // 편집 후 이미지 할당
            processedImg = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(result);
            this.picresult.Image = processedImg;

            // 메모리 해제
            img.Dispose();
            result.Dispose();

        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            OpenCvSharp.Mat img = OpenCvSharp.Extensions.BitmapConverter.ToMat(SelectImg()); // 편집할 이미지
            OpenCvSharp.Mat result = new OpenCvSharp.Mat(); // 편집 후 이미지

            /* 그레이 스케일 : 이미 그레이스케일을 적용한 이미지에는 그레이스케일 불가 */

            if(img.Channels() != 1)
            {
                Cv2.CvtColor(img, result, ColorConversionCodes.BGR2GRAY);

                // 편집 후 이미지 할당
                processedImg = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(result);
                this.picresult.Image = processedImg;

                // 메모리 해제
                img.Dispose();
                result.Dispose();

            }

        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            OpenCvSharp.Mat img = OpenCvSharp.Extensions.BitmapConverter.ToMat(SelectImg()); // 편집할 이미지
            OpenCvSharp.Mat result = new OpenCvSharp.Mat(); // 편집 후 이미지

            /* 이진화 : 그레이스케일이 적용되지 않은 이미지는 이진화 하지 않음 */

            if (img.Channels() == 1)
            {
                Cv2.AdaptiveThreshold(img, result, 255, AdaptiveThresholdTypes.GaussianC, ThresholdTypes.Binary, 15, 9);

                // 편집 후 이미지 할당
                processedImg = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(result);
                this.picresult.Image = processedImg;

                // 메모리 해제
                img.Dispose();
                result.Dispose();

            }
        }

        private void btnEdge_Click(object sender, EventArgs e)
        {
            OpenCvSharp.Mat img = OpenCvSharp.Extensions.BitmapConverter.ToMat(SelectImg()); // 편집할 이미지
            OpenCvSharp.Mat result = new OpenCvSharp.Mat();

            /* 경계 추출 */
            Cv2.Canny(img, result, 100, 200, 3);
            // 편집 후 이미지 할당
            processedImg = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(result);
            this.picresult.Image = processedImg;

            // 메모리 해제
            img.Dispose();
            result.Dispose();
        }

        private void btnOCR_Click(object sender, EventArgs e)
        {
            Console.WriteLine("인식 버튼 클릭");
            /* 글자 인식 */
            try
            {
                // 경로 (폴더 내 tessdata폴더), traineddata 파일명, 모드
                using (var engine = new TesseractEngine(@"./tessdata", "kor", EngineMode.Default))
                using (Pix pix = PixConverter.ToPix(SelectImg()))
                using (var page = engine.Process(pix))
                {
                    this.carnumbertext.Text = page.GetText();
                    Console.WriteLine(page.GetText());
                }
            }
            catch (Exception ex)
            {
                /* 243 자주 보이는 오류 */
                // Failed to initialise tesseract engine
                //  See https://github.com/charlesw/tesseract/wiki/Error-1 for details.
                this.carnumbertext.Text = ex.ToString();
                Console.WriteLine(ex.ToString());
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            /* 초기화 */
            processedImg = null;
            this.picresult.Image = null;
            this.carnumbertext.Text = null;
        }
    }
}
