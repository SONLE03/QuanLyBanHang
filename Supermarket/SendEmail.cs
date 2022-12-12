using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class SendEmail : Form
    {
        public static int code { get; set; }
        public static string username { get; set; }
        public static string email { get; set; }

        SQLConnection conn;
        public SendEmail()
        {
            InitializeComponent();
        }

        private bool CheckKey(string sql)
        {
            conn = new SQLConnection();
            conn.OpenConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, conn.con);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }
        private void Save_Click(object sender, EventArgs e)
        {
            string sql = "SELECT EM_USERNAME, EM_EMAIL FROM EMPLOYEE WHERE EM_USERNAME= '" + UserName.Text + "'and EM_EMAIL='" + Email.Text + "'";
            if (CheckKey(sql))
            {
                username = UserName.Text;
                email = Email.Text;
                Random random = new Random();
                code = random.Next(100000, 1000000);
                MailMessage mailMessage = new MailMessage();
                mailMessage.To.Add(Email.Text);
                mailMessage.From = new MailAddress("sonle102003@gmail.com");
                mailMessage.Subject = "Gửi mã xác nhận mật khẩu";
                mailMessage.Body = code.ToString();

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.EnableSsl = true;
                smtpClient.Port = 587;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.Credentials = new NetworkCredential("sonle102003@gmail.com", "prnifdmglzmlqxeg");
                try
                {
                    smtpClient.Send(mailMessage);
                    MessageBox.Show("Đã gửi mã xác nhận");
                    SetPass setNewPass = new SetPass();
                    setNewPass.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
