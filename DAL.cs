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
    class DAL
    {
        readonly DbConn C = new DbConn();
        public int InsertCloth(Cloth cloth)
        {
            try
            {
                using ()
                {
                    SqlCommand cmd = new SqlCommand("AddCloths", C.Con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@SKUNumber", cloth.SKUNumber));
                    cmd.Parameters.Add(new SqlParameter("@Name", cloth.Name));
                    cmd.Parameters.Add(new SqlParameter("@Size", cloth.Size));
                    cmd.Parameters.Add(new SqlParameter("@Color", cloth.Color));
                    cmd.Connection.Open();
                    int Result = cmd.ExecuteNonQuery();
                    C.Con.Close();
                    return Result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
