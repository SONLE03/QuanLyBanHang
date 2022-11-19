using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Runtime.CompilerServices;
namespace Supermarket
{
    public partial class Login : Form
    {
        SQLConnection SQLConnection = new SQLConnection();
        SqlCommand cmd = new SqlCommand();
        DataTable data = new DataTable();
        public Login()
        {
            InitializeComponent();
        }

        private void Dangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                if(username.Text == "" || password.Text == "")
                {
                    MessageBox.Show("Thông tin đăng nhập không đầy đủ", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SQLConnection.OpenConnection();
                    cmd = SQLConnection.con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select * From EMPLOYEE Where EM_USERNAME = '" + username.Text + "' and EM_PASSWORD = '" + password.Text + "'" ;
                    cmd.ExecuteNonQuery();
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();

                    if (sqlDataReader.Read())
                    {
                        this.Hide();
                        Home home = new Home();
                        home.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Thông tin đăng nhập không chính xác", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    SQLConnection.CloseConnection();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void tendangnhap_Click(object sender, EventArgs e)
        {
            username.SelectAll();
        }

        private void Matkhau_Click(object sender, EventArgs e)
        {
            password.SelectAll();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            login2.Visible = false;
            adminlogin.Visible = false;
            login1.Visible = true;
            em_login.Visible = true;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass.Checked)
            {
                password.UseSystemPasswordChar = true;
            }
            else
            {
                password.UseSystemPasswordChar = false;
            }
        }

        private void adminlogin_Click(object sender, EventArgs e)
        {
            adminlogin.Visible = false;
            em_login.Visible = true;
            login1.Visible = true;
            login2.Visible = false;
        }

        private void Dangnhap2_Click(object sender, EventArgs e)
        {
            try
            {
                if (username.Text == "Tên đăng nhập" || password.Text == "Mật khẩu")
                {
                    MessageBox.Show("Thông tin đăng nhập không đầy đủ", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SQLConnection.OpenConnection();
                    cmd = SQLConnection.con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Select * From ADMIN Where AD_USERNAME = '" + username.Text + "' and AD_PASSWORD = '" + password.Text + "'";
                    cmd.ExecuteNonQuery();
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();

                    if (sqlDataReader.Read())
                    {
                        this.Hide();
                        Home home = new Home();
                        home.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Thông tin đăng nhập không chính xác", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    SQLConnection.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void userlogin_Click(object sender, EventArgs e)
        {
            adminlogin.Visible = true;
            em_login.Visible = false;
            login1.Visible = false;
            login2.Visible = true;
        }
        private void signup_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
        }
    }
}
