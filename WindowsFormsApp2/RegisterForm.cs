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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            this.PasswordText.AutoSize = false;
            this.PasswordText.Size = new Size(this.PasswordText.Width, 64);

            userNameField.Text = "이름을 입력하세요.";
            userNameField.ForeColor = Color.Gray;

            userPhoneField.Text = "연락처를 입력하세요.";
            userPhoneField.ForeColor = Color.Gray;

            IdText.Text = "아이디를 입력하세요.";
            IdText.ForeColor = Color.Gray;

        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "이름을 입력하세요.")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;
            }
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "이름을 입력하세요.";
                userNameField.ForeColor = Color.Gray;
            }
        }

        private void IdText_Enter(object sender, EventArgs e)
        {
            if (IdText.Text == "아이디를 입력하세요.")
            {
                IdText.Text = "";
                IdText.ForeColor = Color.Black;
            }
        }

        private void IdText_Leave(object sender, EventArgs e)
        {
            if (IdText.Text == "")
            {
                IdText.Text = "아이디를 입력하세요.";
                IdText.ForeColor = Color.Gray;
            }
        }

        private void userPhoneField_Enter(object sender, EventArgs e)
        {
            if (userPhoneField.Text == "연락처를 입력하세요.")
            {
                userPhoneField.Text = "";
                userPhoneField.ForeColor = Color.Black;
            }
        }

        private void userPhoneField_Leave(object sender, EventArgs e)
        {
            if (userPhoneField.Text == "")
            {
                userPhoneField.Text = "연락처를 입력하세요.";
                userPhoneField.ForeColor = Color.Gray;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (userNameField.Text == "이름을 입력하세요." || userPhoneField.Text == "연락처를 입력하세요." || IdText.Text == "아이디를 입력하세요." || PasswordText.Text == "")
            {
                MessageBox.Show("모든 항목을 입력 해 주세요", "등록실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (isUserExists()) // 아이디가 존재할 경우 종료
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `loginuser` (`login`, `password`, `name`, `phone`) VALUES (@login, @pass, @name, @phone)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = IdText.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PasswordText.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = userPhoneField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("계정이 등록되었습니다.", "등록성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("계정이 등록되지 않았습니다.");

            db.closeConnection();

        }

        public Boolean isUserExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `loginuser` WHERE `login` = @uL", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = IdText.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("이미 존재하는 아이디입니다.", "등록실패", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                return true;
            }

            else
                return false;

        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loginform loginForm = new Loginform();
            loginForm.Show();
        }
    }
}
