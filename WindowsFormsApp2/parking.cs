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
        //public const int _buffsize = 1024;
        //public Socket _wSocket = null;
        //public byte[] _buffer = new byte[_buffsize];
        //public StringBuilder sb = new StringBuilder();

        //public class AsyncSocketClient
        //{
        //    private const int _port = 9001;
        //    private static ManualResetEvent connectCompleted = new ManualResetEvent(false);
        //    private static ManualResetEvent sendCompleted = new ManualResetEvent(false);
        //    private static ManualResetEvent receiveCompleted = new ManualResetEvent(false);
        //    private static string response = String.Empty;

        //    public static void StartClinet()
        //    {
        //        try
        //        {
        //            IPAddress ipaddr = IPAddress.Parse("10.10.21.105");
        //            IPHostEntry ipHost = Dns.GetHostEntry(ipaddr);
        //            IPEndPoint remoteEndPoint = new IPEndPoint(ipaddr, _port);

        //            Socket client = new Socket(ipaddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        //            client.BeginConnect(remoteEndPoint, new AsyncCallback(ConnectionCallback), client);
        //            Send(client, "hello jiheock");
        //            sendCompleted.WaitOne();

        //            Receive(client);
        //            receiveCompleted.WaitOne();
        //            Console.WriteLine($"Response received {response}");
        //            client.Shutdown(SocketShutdown.Both);
        //            client.Close();
        //        }
        //        catch(Exception e)
        //        {

        //        }
        //    }

        //    private static void Receive(Socket client)
        //    {
        //        try
        //        {
        //            parking state = new parking();
        //            state._wSocket = client;
        //            client.BeginReceive(state._buffer, 0, parking._buffsize, 0, new AsyncCallback(ReceiveCallback), state);
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e);
        //        }
        //    }

        //    private static void ReceiveCallback(IAsyncResult ar)
        //    {
        //        try
        //        {
        //            parking state = (parking)ar.AsyncState;
        //            var client = state._wSocket;
        //            int byteRead = client.EndReceive(ar);
        //            if (byteRead > 0)
        //            {
        //                state.sb.Append(Encoding.ASCII.GetString(state._buffer, 0, byteRead));
        //                client.BeginReceive(state._buffer, 0, parking._buffsize, 0, new AsyncCallback(ReceiveCallback), state);
        //            }
        //            else
        //            {
        //                if (state.sb.Length > 1)
        //                {
        //                    response = state.sb.ToString();
        //                }
        //                receiveCompleted.Set();
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e);
        //        }

        //    }

        //    private static void Send(Socket client, string data)
        //    {
        //        byte[] byteData = Encoding.ASCII.GetBytes(data);
        //        client.BeginSend(byteData, 0, byteData.Length, 0, new AsyncCallback(SendCallback), client);
        //    }

        //    private static void SendCallback(IAsyncResult ar)
        //    {
        //        try
        //        {
        //            Socket client = (Socket)ar.AsyncState;
        //            int byteSent = client.EndSend(ar);
        //            Console.WriteLine($"Sent : {byteSent} bytes to server");
        //            sendCompleted.Set();
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e);
        //        }
        //    }

        //    private static void ConnectionCallback(IAsyncResult ar)
        //    {
        //        try
        //        {
        //            Socket client = (Socket)ar.AsyncState;
        //            client.EndConnect(ar);
        //            Console.WriteLine($"Socket connection : {client.RemoteEndPoint.ToString()}");
        //            connectCompleted.Set();
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e);
        //        }
        //    }
        //}
        //byte[] bytes = new byte[_buffsize];

        public parking()
        {
            InitializeComponent();
            //AsyncSocketClient.StartClinet();
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            stream.Flush();
            stream.Close();
            client.Close();
            clientThread.Interrupt();
            Application.ExitThread();
            Application.Exit();
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
            pictureBoxcapture.Image = pictureBoxcam.Image;
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
                    Display(msg);
                }
            }
            catch(IOException e)
            {
                setLabel(status, "연결종료", Color.IndianRed);
                MessageBox.Show("서버와 연결이 종료되었습니다.", "연결종료");
                clientThread.Interrupt();
            }
        }
        void Classify(string server)
        {
            if(!client.Connected)
            {
                MessageBox.Show("서버에 먼저 연결 해 주세요.");
            }           
            
            else if(server.StartsWith(entrancebtn.Text))
            {
                
                Sender(server);
            }
        }
        private void entrancebtn_Click(object sender, EventArgs e)
        {
            
            string entrance = entrancebtn.Text;
            string datetime = datatimelabel.Text;
            string carnumber = carnumbertext.Text;
            int numberlength = carnumber.Length;

            if (numberlength >= 7 && numberlength <= 8)
            {
                string entry = String.Concat(entrance, " ",datetime, " ", carnumber);
                Classify(entry);
            }
            else
            {
                MessageBox.Show("자동차번호를 제대로 입력 해야 합니다.", "전송실패");
            }
        }
    }
}
