using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
            this.PasswordText.AutoSize = false;
            this.PasswordText.Size = new Size(this.PasswordText.Width, 64);

        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void ExitLabel_MouseEnter(object sender, EventArgs e)
        {
            ExitLabel.ForeColor = Color.Green;
        }

        private void ExitLabel_MouseLeave(object sender, EventArgs e)
        {
            ExitLabel.ForeColor = Color.White;
        }

        Point lastPoint; // 포인트는 설정을 위한 특수 클래스
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left) // 여기서 e는 생성된 객체이다 ! 어렵게 생각 ㄴ
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y); // 마우스를 아래로 이동할 때 새로운 점 좌표를 얻는다.

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            String loginUser = IdText.Text;
            String passUser = PasswordText.Text;

            DB db = new DB(); // 메모리 할당

            DataTable table = new DataTable(); // 메모리 할당

            MySqlDataAdapter adapter = new MySqlDataAdapter(); // 메모리 할당

            MySqlCommand command = new MySqlCommand("SELECT * FROM loginuser WHERE `login` = @uL AND `password` = @uP", db.getConnection()); // 메모리 할당 , 이 줄은 sql 명령 자체와 같다.

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command; // 특정 명령을 실행한 다음
            adapter.Fill(table); // 모든 데이터는 내부에서 변형되도록 한다.

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("환영합니다.", "로그인성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
                
            else
                MessageBox.Show("계정이 등록되어 있지 않습니다.", "로그인실패",MessageBoxButtons.OK ,MessageBoxIcon.Error);


        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm(); // 메모리 할당
            registerForm.Show();
        }

    }
}
