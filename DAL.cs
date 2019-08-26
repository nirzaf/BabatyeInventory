using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BabatyeInventory
{
    class DAL
    {
        public SqlConnection Con = new SqlConnection("Data Source=.\\SQLEXPRESS01;Initial Catalog=babatie;Integrated Security=True");

        public int InsertCloth(Cloth cloth)
        {
            try
            {
                    SqlCommand cmd = new SqlCommand("AddCloths", Con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@SKUNumber", cloth.SKUNumber));
                    cmd.Parameters.Add(new SqlParameter("@Name", cloth.Name));
                    cmd.Parameters.Add(new SqlParameter("@Size", cloth.Size));
                    cmd.Parameters.Add(new SqlParameter("@Color", cloth.Color));
                    cmd.Connection.Open();
                    int Result = cmd.ExecuteNonQuery();
                    Con.Close();
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
