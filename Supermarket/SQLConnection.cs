using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    public class SQLConnection
    {
        public SqlConnection con;
        public SQLConnection()
        {

            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-MV4COEO\SQLEXPRESS; Initial Catalog = BAKERY; Integrated Security = True");
            }
            catch
            {
                return;
            }
        }
        public void OpenConnection()
        {
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void CloseConnection()
        {
            con.Close();
        }
    }
}
