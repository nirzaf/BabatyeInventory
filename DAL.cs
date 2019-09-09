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
                SqlCommand cmd = new SqlCommand("InsertClothes", C.Con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@SKUNumber", cloth.SKUNumber));
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
                if (C.Con != null)
                {
                    C.Con.Close();
                }
            }
        }

        public int AddNewCloth(Cloth cloth)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("AddNewItem", C.Con)
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
                if (C.Con != null)
                {
                    C.Con.Close();
                }
            }
        }

        public DataTable LoadDGV()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("ViewProducts", C.Con)
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
                if (C.Con != null)
                {
                    C.Con.Close();
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

                    SqlCommand cmd = new SqlCommand("GetName", C.Con)
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
                    if (C.Con != null)
                    {
                        C.Con.Close();
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
