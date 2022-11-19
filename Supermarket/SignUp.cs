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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace Supermarket
{
    public partial class SignUp : Form
    {
        SQLConnection SQLConnection = new SQLConnection();
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            SQLConnection.OpenConnection();
            SqlCommand sqlCommand = new SqlCommand("AUTOCODE", SQLConnection.con);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            object obj = sqlCommand.ExecuteScalar();
            this.id.Text = obj.ToString();
            SQLConnection.CloseConnection();
        }
        private void save_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || name.Text == "" || usn.Text =="" || pass.Text =="" || phone.Text =="" || mail.Text == "")
            {
                MessageBox.Show("Thông tin đăng ký không đầy đủ", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = "INSERT INTO EMPLOYEE(EM_ID, EM_NAME, EM_USERNAME, EM_PASSWORD, EM_PHONE, EM_EMAIL) VALUES(@EM_ID, @EM_NAME, @EM_USERNAME, @EM_PASSWORD, @EM_PHONE, @EM_EMAIL)";
                SqlCommand sqlCommand = new SqlCommand(query, SQLConnection.con);
                sqlCommand.Parameters.AddWithValue("@EM_ID", id.Text);
                sqlCommand.Parameters.AddWithValue("@EM_Name", name.Text);
                sqlCommand.Parameters.AddWithValue("@EM_USERNAME", usn.Text);
                sqlCommand.Parameters.AddWithValue("@EM_PASSWORD", pass.Text);
                sqlCommand.Parameters.AddWithValue("@EM_PHONE", phone.Text);
                sqlCommand.Parameters.AddWithValue("@EM_EMAIL", mail.Text);
                try
                {
                    SQLConnection.OpenConnection();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Đã đăng ký tài khoản thành công");

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    SQLConnection.CloseConnection();
                }
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
