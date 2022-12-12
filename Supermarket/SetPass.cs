using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Supermarket
{
    public partial class SetPass : Form
    {
        SQLConnection conn = new SQLConnection();
        public SetPass()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            SendEmail sendEmail = new SendEmail();
            sendEmail.ShowDialog();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(Code.Text) == SendEmail.code)
            {
                if(N_Pass.Text == CN_Pass.Text)
                {
                    string query = "UPDATE EMPLOYEE SET EM_PASSWORD ='" + N_Pass.Text + "' WHERE EM_USERNAME = '" + SendEmail.username + "'and EM_EMAIL='" + SendEmail.email + "'";
                    try
                    {
                        conn.OpenConnection();
                        SqlCommand sqlCommand = new SqlCommand(query, conn.con);
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Đã thay đổi mật khẩu");
                        this.Hide();
                        Login login = new Login();
                        login.ShowDialog();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.CloseConnection();
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu xác nhận không chính xác", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Mã xác nhận không chính xác", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
