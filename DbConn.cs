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
        //public SqlConnection Con = new SqlConnection("Data Source=CMDMFAZRIN\\SQLSERVER;Initial Catalog=babatye;Integrated Security=True; MultipleActiveResultSets=True");
        //public SqlConnection Con = new SqlConnection("Data Source=.;Initial Catalog=babatye;Integrated Security=True; MultipleActiveResultSets=True");
        public SqlConnection Con = new SqlConnection("Data Source=..\\SQLEXPRESS01;Initial Catalog=babatye;Integrated Security=True; MultipleActiveResultSets=True");
        //public SqlConnection Con = new SqlConnection("workstation id = babatye.mssql.somee.com; packet size = 4096; user id = babatye_SQLLogin_1; pwd=2jdfhb4nco;data source = babatye.mssql.somee.com; persist security info=False;initial catalog = babatye; MultipleActiveResultSets=True");        
    }
}
