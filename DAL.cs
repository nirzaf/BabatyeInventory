using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BabatyeInventory
{
    class DAL
    {
        public SqlConnection Con = new SqlConnection("Data Source=.\\SQLEXPRESS01 ;Initial Catalog=babatye;Integrated Security=True");

        public int InsertCloth(Cloth cloth)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("InsertClothes", Con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@SKUNumber", cloth.SKUNumber));
                cmd.Parameters.Add(new SqlParameter("@Name", cloth.Name));
                cmd.Parameters.Add(new SqlParameter("@Size", cloth.Size));
                cmd.Parameters.Add(new SqlParameter("@Color", cloth.Color));
                cmd.Connection.Open();
                int Result = cmd.ExecuteNonQuery();
                return Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                if (Con != null)
                {
                    Con.Close();
                }
            }
        }

        public int AddNewCloth(Cloth cloth)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("AddNewItem", Con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@SKUNumber", cloth.SKUNumber));
                cmd.Parameters.Add(new SqlParameter("@Name", cloth.Name));
                cmd.Parameters.Add(new SqlParameter("@Size", cloth.Size));
                cmd.Parameters.Add(new SqlParameter("@Color", cloth.Color));
                cmd.Connection.Open();
                int Result = cmd.ExecuteNonQuery();             
                return Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                if (Con != null)
                {
                    Con.Close();
                }
            }
        }

        public DataTable LoadDGV()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("ViewProducts", Con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                SqlDataAdapter Sda = new SqlDataAdapter(cmd);
                Sda.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                if (Con != null)
                {
                    Con.Close();
                }
            }
        }

        public string GetName(string SKUNumber)
        {
            if (SKUNumber.Length > 5)
            {
                try
                {
                    DataSet NameOfProduct = new DataSet();

                    SqlCommand cmd = new SqlCommand("GetName", Con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.Add(new SqlParameter("@SKUNumber", SKUNumber));
                    SqlDataAdapter Sda = new SqlDataAdapter(cmd);
                    Sda.Fill(NameOfProduct);
                    if (NameOfProduct.Tables[0].Rows.Count != 0)
                    {
                        return NameOfProduct.Tables[0].Rows[0]["Name"].ToString();
                    }
                    else
                        return "";
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    if (Con != null)
                    {
                        Con.Close();
                    }
                }
            }
            else
            {
                return "";
            }
        }
    }
}
