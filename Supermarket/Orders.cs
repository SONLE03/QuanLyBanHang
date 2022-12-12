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
using System.Xml.Linq;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Supermarket
{
    public partial class Orders : Form
    {
        int grandTotal = 0;
        SQLConnection conn;
        public Orders()
        {
            InitializeComponent();
        }

        private void showdata()
        {
            conn = new SQLConnection();
            conn.OpenConnection();
            String str = "SELECT * FROM BILL";
            SqlCommand sqlCommand = new SqlCommand(str, conn.con);
            sqlCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            da.Fill(dt);
            dataGridView_addOrder.DataSource = dt;
            conn.CloseConnection();
        }
         
        private void getEmployee()
        {
            Employee.Text = Login.id + " | " + Login.name;
        }
        
        private void getCustomer()
        {
            conn = new SQLConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * FROM CUSTOMER";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Customer.Items.Add(dr["CUS_ID"].ToString() + " | " + dr["CUS_NAME"].ToString());
            }
            conn.CloseConnection();
        }
        
        private void getProduct()
        {
            conn = new SQLConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn.con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * FROM PRODUCT";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Product.Items.Add(dr["PRO_ID"].ToString() + " | " + dr["PRO_NAME"].ToString());
            }
            conn.CloseConnection();
        }
        private void CheckQuantity()
        {
            conn = new SQLConnection();
            conn.OpenConnection();
            String str = "Select PRO_Quantity FROM PRODUCT WHERE PRO_ID = '" + Product.Text.Substring(0, 7) + "'";
            SqlCommand cmd = new SqlCommand(str, conn.con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                try
                {
                    if (Convert.ToInt32(Quantity.Text) > Convert.ToInt32(dr.GetValue(0).ToString()))
                    {
                        MessageBox.Show("Số lượng cần mua lớn hơn số lượng hiện có", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    
                }
            }
            else
            {

            }
            conn.CloseConnection();
        }
        private void getPrice()
        {
            conn = new SQLConnection();
            conn.OpenConnection();
            String str = "Select PRO_Price FROM PRODUCT WHERE PRO_ID = '" + Product.Text.Substring(0,7) + "'";
            SqlCommand cmd = new SqlCommand(str, conn.con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                price.Text = dr.GetValue(0).ToString();
            }
            conn.CloseConnection();
        }
        private void getDateTime() 
        {
            DateTime dateTime = DateTime.Now;
            datetime.Text = dateTime.ToString("dd/MM/yyyy");
        }

        private void auto_id()
        {
            conn = new SQLConnection();
            conn.OpenConnection();
            SqlCommand sqlCommand = new SqlCommand("AUTOBILLID", conn.con);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            object obj = sqlCommand.ExecuteScalar();
            this.id.Text = obj.ToString();
            conn.CloseConnection();
        }
        private void Orders_Load(object sender, EventArgs e)
        {
            getCustomer();
            getDateTime();
            getEmployee();
            getProduct();
            auto_id();
        }

        private void Product_SelectedValueChanged(object sender, EventArgs e)
        {
            getPrice();
        }

        private void Quantity_TextChanged(object sender, EventArgs e)
        {
            CheckQuantity();
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
        private void AddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (Quantity.Text == "")
                {
                    MessageBox.Show("Chưa nhập số lượng cần mua", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Quantity.Focus();
                }
                DateTime dateTime = DateTime.Now;
                conn = new SQLConnection();
                conn.OpenConnection();
                int total = Convert.ToInt32(price.Text) * Convert.ToInt32(Quantity.Text);
                grandTotal += total;
                gTotal.Text = grandTotal + " VND";
                // Kiểm tra mã hóa đơn đã tồn tại trong csdl chưa.
                string checkBill = "SELECT B_ID FROM BILL WHERE B_ID= '" + id.Text + "'";
                if (!CheckKey(checkBill))
                {
                    string query = "INSERT INTO BILL(B_ID, B_DATE, CUS_ID, EM_ID, B_PRICE) VALUES(@B_ID, @B_DATE, @CUS_ID, @EM_ID, @B_PRICE)";
                    SqlCommand sqlCommand = new SqlCommand(query, conn.con);
                    sqlCommand.Parameters.AddWithValue("@B_ID", id.Text);
                    sqlCommand.Parameters.AddWithValue("@B_DATE", dateTime.ToString("dd/MM/yyyy"));
                    sqlCommand.Parameters.AddWithValue("@CUS_ID", Customer.Text.Substring(0, 7));
                    sqlCommand.Parameters.AddWithValue("@EM_ID", Employee.Text.Substring(0, 7));
                    sqlCommand.Parameters.AddWithValue("@B_PRICE", grandTotal);
                    sqlCommand.ExecuteNonQuery();
                }
                else
                {
                    string query = "UPDATE BILL SET B_PRICE ='" + grandTotal + "' WHERE B_ID = '" + id.Text + "'";
                    SqlCommand sqlCommand = new SqlCommand(query, conn.con);
                    sqlCommand.ExecuteNonQuery();
                }
                // CẬP NHẬT SỐ LƯỢNG SẢN PHẨM SAU KHI ĐÃ BÁN
                string selectQuery = "UPDATE Product SET Pro_Quantity = Pro_Quantity-" + Quantity.Text + " WHERE Pro_id ='" + Product.Text.Substring(0, 7) + "'";
                SqlCommand cmd = new SqlCommand(selectQuery, conn.con);
                cmd.ExecuteNonQuery();
                //kiểm tra xem có tồn tại bill info hay chưa
                string checkBillInfo = "SELECT B_id,pro_id FROM BILLINFO WHERE B_ID='" + id.Text + "'and Pro_id='" + Product.Text.Substring(0, 7) + "'";
                if (!CheckKey(checkBillInfo))
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView_addOrder);
                    row.Cells[0].Value = Product.Text.Substring(0, 7);
                    row.Cells[1].Value = Product.Text.Substring(10);
                    row.Cells[2].Value = price.Text;
                    row.Cells[3].Value = Quantity.Text;
                    row.Cells[4].Value = total;
                    dataGridView_addOrder.Rows.Add(row);
                    string query = "INSERT INTO BILLINFO(B_ID, PRO_ID, QUANTITY) VALUES(@B_ID, @PRO_ID, @QUANTITY)";
                    SqlCommand sqlCommand = new SqlCommand(query, conn.con);
                    sqlCommand.Parameters.AddWithValue("@B_ID", id.Text);
                    sqlCommand.Parameters.AddWithValue("@PRO_ID", Product.Text.Substring(0, 7));
                    sqlCommand.Parameters.AddWithValue("@QUANTITY", Quantity.Text);
                    sqlCommand.ExecuteNonQuery();
                }
                else
                {
                    int n_Quantity;
                    // Cập nhật số lượng sản phẩm nếu chọn lại sản phẩm đã từng chọn mua
                    for (int i = 0; i < dataGridView_addOrder.Rows.Count; i++)
                    {
                        var value = dataGridView_addOrder.Rows[i].Cells[0].Value;
                        if (value.ToString() == Product.Text.Substring(0, 7))
                        {
                            dataGridView_addOrder.Rows[i].Cells[4].Value = Convert.ToInt32(dataGridView_addOrder.Rows[i].Cells[4].Value) + total;
                            dataGridView_addOrder.Rows[i].Cells[3].Value = Convert.ToInt32(dataGridView_addOrder.Rows[i].Cells[3].Value) + Convert.ToInt32(Quantity.Text);
                            n_Quantity = Convert.ToInt32(dataGridView_addOrder.Rows[i].Cells[3].Value);
                            string query_BillInfo = "UPDATE BILLINFO SET QUANTITY ='" + n_Quantity.ToString() + "' WHERE B_ID = '" + id.Text + " 'AND Pro_ID = '" + Product.Text.Substring(0, 7) + "'";
                            SqlCommand sqlCommand_Bill = new SqlCommand(query_BillInfo, conn.con);
                            sqlCommand_Bill.ExecuteNonQuery();
                            break;
                        }
                    }
                }
            }catch
            {

            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string checkBillInfo = "SELECT B_id,pro_id FROM BILLINFO WHERE B_ID='" + id.Text + "'and Pro_id='" + Product.Text.Substring(0, 7) + "'";
            if (!CheckKey(checkBillInfo))
            {
                MessageBox.Show("Không tìm thấy sản phẩm trong hóa đơn", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int _Price;
                foreach (DataGridViewRow dataGridViewRow in dataGridView_addOrder.Rows)
                {
                    if (dataGridViewRow.Cells[0].Value.ToString() == Product.Text.Substring(0, 7))
                    {
                        _Price = Convert.ToInt32(dataGridViewRow.Cells[4].Value);
                        dataGridView_addOrder.Rows.Remove(dataGridViewRow);
                        grandTotal -= _Price;
                        string query_BillInfo = "DELETE FROM BILLINFO WHERE B_ID = '" + id.Text + "'AND Pro_ID = '" + Product.Text.Substring(0, 7) + "'";
                        SqlCommand sqlCommand_BillInfo = new SqlCommand(query_BillInfo, conn.con);
                        sqlCommand_BillInfo.ExecuteNonQuery();
                        string query_Bill = "UPDATE BILL SET B_PRICE='" + grandTotal + "' WHERE B_ID = '" + id.Text + "'";
                        SqlCommand sqlCommand_Bill = new SqlCommand(query_Bill, conn.con);
                        sqlCommand_Bill.ExecuteNonQuery();
                        gTotal.Text = grandTotal + " VND";
                        break;
                    }
                }
            }
        }
        private void Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        
        private void print_Click(object sender, EventArgs e)
        {
            if (dataGridView_addOrder.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có sản phẩm nào trong hóa đơn", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn muốn thanh toán ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    DialogResult _result = MessageBox.Show("Bạn muốn in hóa đơn ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if( _result == DialogResult.Yes)
                    {
                        BprintPreviewDialog.Document = BprintDocument;
                        BprintPreviewDialog.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã thanh toán thành công", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void BprintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string CUS_ADDRESS = "", CUS_PHONE = "";
            string sql = "SELECT CUS_PHONE, CUS_ADDRESS FROM CUSTOMER WHERE CUS_ID = '" + Customer.Text.Substring(0, 7) + "'";
            SqlCommand sqlCommand = new SqlCommand(sql, conn.con);
            SqlDataReader dr = sqlCommand.ExecuteReader();
            if (dr.Read())
            {
                CUS_PHONE = dr.GetValue(0).ToString();
                CUS_ADDRESS = dr.GetValue(1).ToString();
            }
            e.Graphics.DrawString("HÓA ĐƠN BÁN HÀNG", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(320,80));
            e.Graphics.DrawString("Mã khách hàng: " + Customer.Text.Substring(0,7), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 150));
            e.Graphics.DrawString("Tên khách hàng: " + Customer.Text.Substring(10), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80,180));
            // Thực hiện truy vấn tìm số điện thoại và địa chỉ
            e.Graphics.DrawString("Số điện thoại: " + CUS_PHONE.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 210));
            e.Graphics.DrawString("Địa chỉ: " + CUS_ADDRESS.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 240));
            e.Graphics.DrawString("Mã hóa đơn: " + id.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(520, 150));
            e.Graphics.DrawString("Mã nhân viên: " + Employee.Text.Substring(0,7), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(520, 180));
            e.Graphics.DrawString("Tên nhân viên: " + Employee.Text.Substring(10), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(520, 210));
            e.Graphics.DrawString("Ngày hóa đơn: " + datetime.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(520, 240));
            e.Graphics.DrawString("Mã sản phẩm" , new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, 310));
            e.Graphics.DrawString("Tên sản phẩm", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(230, 310));
            e.Graphics.DrawString("Đơn giá", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(430, 310));
            e.Graphics.DrawString("Số lượng", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, 310));
            e.Graphics.DrawString("Thành tiền" , new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(670, 310));
            int x = 360;
            for(int i = 0; i < dataGridView_addOrder.Rows.Count; i++)
            {
                e.Graphics.DrawString(dataGridView_addOrder.Rows[i].Cells[0].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(80, x));
                e.Graphics.DrawString(dataGridView_addOrder.Rows[i].Cells[1].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(230, x));
                e.Graphics.DrawString(dataGridView_addOrder.Rows[i].Cells[2].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(430, x));
                e.Graphics.DrawString(dataGridView_addOrder.Rows[i].Cells[3].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(550, x));
                e.Graphics.DrawString(dataGridView_addOrder.Rows[i].Cells[4].Value.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(670, x));
                x += 40;
            }
            e.Graphics.DrawString("Thành tiền:   " + gTotal.Text, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(520, x + 50));
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult _result = MessageBox.Show("Bạn muốn thoát ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if( _result == DialogResult.Yes)
            {
                string checkBill = "SELECT B_ID FROM BILL WHERE B_ID= '" + id.Text + "'";
                if (CheckKey(checkBill))
                {
                    // Nếu thoát khi đã từng thêm sản phẩm mà chưa thanh toán csdl sẽ thêm mã hóa đơn -> xử lí tránh trường hợp này.
                    string query_BillInfo = "DELETE FROM BILL WHERE B_ID = '" + id.Text + "'AND B_Price = '" + 0 + "'";
                    SqlCommand sqlCommand_BillInfo = new SqlCommand(query_BillInfo, conn.con);
                    sqlCommand_BillInfo.ExecuteNonQuery();
                }
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
            }
        }
    }
}
