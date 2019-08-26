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
        public SqlConnection Con = new SqlConnection("Data Source=.;Initial Catalog=babatye;Integrated Security=True");
    }
}
