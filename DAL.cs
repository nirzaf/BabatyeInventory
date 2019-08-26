using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BabatyeInventory
{
    class DAL
    {
        DbConn C = new DbConn();

        public int InsertCloth(Cloth cloth)
        {
            try
            {
                    SqlCommand cmd = new SqlCommand("AddCloth", C.Con)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
