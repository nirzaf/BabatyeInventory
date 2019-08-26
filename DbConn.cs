using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BabatyeInventory
{
    class DbConn
    {
        public SqlConnection Con;
        public DbConn()
        {
            try
            {
                string ConnectionString = "Data Source=.\\SQLEXPRESS01;Initial Catalog=babatie;Integrated Security=True";
                Con = new SqlConnection(ConnectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
