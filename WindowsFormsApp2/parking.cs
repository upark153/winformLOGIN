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

namespace WindowsFormsApp2
{
    public partial class parking : Form
    {
        bool _streaming;
        Capture _capture;

        public parking()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            _streaming = false;
            _capture = new Capture();

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
    }
}
