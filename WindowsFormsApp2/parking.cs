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
        int BUFF_SIZE = 1024;
        byte[] bytes = new byte[1024];

        public parking()
        {
            InitializeComponent();
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
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
        }

        private void btnServerConnect_Click(object sender, EventArgs e)
        {
            connectTcp();
        }


        async void connectTcp()
        {
            TcpClient _client = new TcpClient();
            Label status = connlabel; // 상태표시

            await Task.Run(() =>
            {
                try
                {
                    setLabel(status, "연결중...", Color.Transparent);
                    _client.Connect(IPAddress.Parse("10.10.21.105"), 9001);
                }
                catch (Exception e)
                {

                }
                if (_client.Connected)
                {
                    setLabel(status, "연결성공", Color.LightSalmon);
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

    }
}
