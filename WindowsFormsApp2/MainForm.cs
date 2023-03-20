using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    {

        // 그림 불러오기 경로참조 : bin -> debug -> images
        Bitmap sunny = new Bitmap("images/sunny.png");
        Bitmap cloud = new Bitmap("images/cloud.png");
        Bitmap manycloud = new Bitmap("images/manycloud.png");
        Bitmap rainy = new Bitmap("images/rainy.png");
        Bitmap raninysnow = new Bitmap("images/raninysnow.png");
        Bitmap snow = new Bitmap("images/snow.png");
        Bitmap shower = new Bitmap("images/shower.png");

        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void btnrequest_Click(object sender, EventArgs e)
        {
            String dong = cbarea.SelectedItem.ToString();
            String dong_number = "";

            switch (dong)
            {
                case "도산동":
                    dong_number = "2920054000";
                    break;

                case "동곡동":
                    dong_number = "2920066000";
                    break;

                case "본량동":
                    dong_number = "2920069000";
                    break;

                case "비아동":
                    dong_number = "2920062000";
                    break;

                case "삼도동":
                    dong_number = "2920068000";
                    break;

                case "송정1동":
                    dong_number = "2920051500";
                    break;

                case "송정2동":
                    dong_number = "2920052500";
                    break;

                case "수완동":
                    dong_number = "2920063700";
                    break;

                case "신가동":
                    dong_number = "2920063000";
                    break;

                case "신창동":
                    dong_number = "2920070000";
                    break;

                case "신흥동":
                    dong_number = "2920055000";
                    break;

                case "어룡동":
                    dong_number = "2920056500";
                    break;

                case "우산동":
                    dong_number = "2920058000";
                    break;

                case "운남동":
                    dong_number = "2920063500";
                    break;

                case "월곡1동":
                    dong_number = "2920063500";
                    break;

                case "월곡2동":
                    dong_number = "2920061000";
                    break;

                case "임곡동":
                    dong_number = "2920065000";
                    break;

                case "첨단1동":
                    dong_number = "2920062400";
                    break;

                case "첨단2동":
                    dong_number = "2920062600";
                    break;

                case "평동":
                    dong_number = "2920067000";
                    break;
            }
            String query = "http://www.kma.go.kr/wid/queryDFSRSS.jsp?zone=" + dong_number;

            // 먼저 클라이언트에서 Request 한다.
            WebRequest request = WebRequest.Create(query);

            request.Method = "GET";
            // Respons를 받는다.

            WebResponse response = request.GetResponse();

            Stream stream = response.GetResponseStream();

            StreamReader reader = new StreamReader(stream);

            string answer = reader.ReadToEnd();

            //richTextBox1.Text = answer;


            // Respons 받은 것을 xml으로 파싱한다.

            XmlDocument xmlDo = new XmlDocument();
            xmlDo.LoadXml(answer); // xml 문서 파싱할 준비

            // 제목이랑 중요한 정보 처리 하는 부분
            XmlNode channel = xmlDo["rss"]["channel"];
            arealabel.Text = channel["title"].InnerText;
            datelabel.Text = channel["pubDate"].InnerText;
            //MessageBox.Show(channel["title"].InnerText);


            // 데이터 처리하는 부분
            XmlNode xmlNode = xmlDo["rss"]["channel"]["item"]["description"]["body"]; // xml 문서에서 필요한 데이터를 파고 들어 찾기 위한 스트링 선언
                                                                                      // rss에 달린 그 가지들 중에 묶여있는 가지를 초이스 해야 한다. channel, item, description, body 는 가지이다.

            /* richTextBox1.Text = xmlNode.ChildNodes.Count.ToString();*/ // chileNodes 란 프로퍼티에 주목. 개수가 몇개인지 파악.

            //for(int i=0; i<xmlNode.ChildNodes.Count; i++)
            //{
            //    richTextBox1.Text += xmlNode.ChildNodes[i]["hour"].InnerText + "\n"; // xml 가지 중에 시간 가지 출력
            //}
            Label[] hour = { label2, label9, label16, label23, label30, label37, label44, label51, label58 };
            Label[] temp = { label3, label10, label17, label24, label31, label38, label45, label52, label59 };
            Label[] wfKor = { label4, label11, label18, label25, label32, label39, label46, label53, label60 };
            Label[] pop = { label5, label12, label19, label26, label33, label40, label47, label54, label61 };
            Label[] ws = { label6, label13, label20, label27, label34, label41, label48, label55, label62 };
            Label[] wdKor = { label7, label14, label21, label28, label35, label42, label49, label56, label63 };
            Label[] reh = { label8, label15, label22, label29, label36, label43, label50, label57, label64 };

            PictureBox[] pb = { pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8, pictureBox9, pictureBox10, };

            // 원래 차트에 그려져 있던 내용을 초기화 하기
            chart1.Series[0].Points.Clear();


            // 차트의 디자인 설정하기

            CustomLabel[] cl = new CustomLabel[9];

            for (int i = 0; i < 9; i++) // 21시부터 다음날 21시까지 총 9건이 나옴.
            {
                /*richTextBox1.Text += xmlNode.ChildNodes[i]["hour"].InnerText + "\n";*/ // xml 가지 중에 시간 가지 출력
                hour[i].Text = "시간: " + xmlNode.ChildNodes[i]["hour"].InnerText + "시"; // 시간
                pop[i].Text = "강수확률: " + xmlNode.ChildNodes[i]["pop"].InnerText + "%"; // 강수확률
                ws[i].Text = "풍속: " + xmlNode.ChildNodes[i]["ws"].InnerText.ToString() + "m/s"; // 풍속
                wdKor[i].Text = "풍향: " + xmlNode.ChildNodes[i]["wdKor"].InnerText; // 풍향
                reh[i].Text = "습도: " + xmlNode.ChildNodes[i]["reh"].InnerText + "%"; // 습도

                temp[i].Text = "기온: " + xmlNode.ChildNodes[i]["temp"].InnerText + "'C"; // 기온
                // 기온으로 그래프 그려 보기
                // y값 확보하기
                double graph_temp = double.Parse(xmlNode.ChildNodes[i]["temp"].InnerText); // 더블 파스로 묶어주면 더블로 변환
                // x값 확보하기
                string graph_time = xmlNode.ChildNodes[i]["hour"].InnerText + "시";

                chart1.Series[0].Points.AddXY(i, graph_temp); // 차트 데이터를 관장하는 Series

                cl[i] = new CustomLabel();
                cl[i].Text = graph_time;
                cl[i].FromPosition = i - 1;
                cl[i].ToPosition = i + 1;
                chart1.ChartAreas[0].AxisX.CustomLabels.Add(cl[i]);


                string wf = xmlNode.ChildNodes[i]["wfKor"].InnerText;
                wfKor[i].Text = "날씨: " + wf; // 날씨

                // 날씨에 따라서 그림을 다르게 표시 해 보기.

                if(wf == "맑음")
                {
                    pb[i].Image = sunny;
                }
                else if(wf == "구름 많음")
                {
                    pb[i].Image = cloud;
                }
                else if (wf == "흐림")
                {
                    pb[i].Image = manycloud;
                }
                else if (wf == "비")
                {
                    pb[i].Image = rainy;
                }
                else if (wf == "비/눈")
                {
                    pb[i].Image = raninysnow;
                }
                else if (wf == "눈")
                {
                    pb[i].Image = snow;
                }
                else if (wf == "소나기")
                {
                    pb[i].Image = shower;
                }
            }
            /*
             * 시간 hour
             * 기온 temp
             * 날씨 wfKor - 맑음, 구름많음, 흐림, 비, 비/눈, 눈, 소나기
             * 강수확률 pop
             * 풍속 ws
             * 풍향 wdKor
             * 습도 reh
             */

        }

        Point lastPoint;

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    for (int i = 8; i <=64; i+=7)
        //    {
        //        richTextBox1.Text += "label" + i.ToString() + ",";
        //    }
        //}
    }
}
