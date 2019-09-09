using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;

namespace BabatyeInventory
{
    class DAL
    {
        DbConn C = new DbConn();
        public int InsertCloth(Cloth cloth)
        {
            string sql = "UPDATE tbl_clothes SET Count = Count + 1 WHERE tbl_clothes.SKU = @SKUNumber";
            int result = 0;
            try
            {
                C.Con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(C.Con))
                {
                    cmd.CommandText = sql;
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@SKUNUmber", cloth.SKUNumber);
                    try
                    {
                        result = cmd.ExecuteNonQuery();
                    }
                    catch (SQLiteException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }              
                return result;
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
            int result = 0;
            try
            {
                string sql = "INSERT INTO tbl_clothes (SKU,Name,Size,Color) VALUES (@SKUNumber,@Name,@Size,@Color) ";
                C.Con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(C.Con))
                {
                    cmd.CommandText = sql;
                    cmd.Prepare();
                    cmd.Parameters.Add(new SQLiteParameter("@SKUNumber", cloth.SKUNumber));
                    cmd.Parameters.Add(new SQLiteParameter("@Name", cloth.Name));
                    cmd.Parameters.Add(new SQLiteParameter("@Size", cloth.Size));
                    cmd.Parameters.Add(new SQLiteParameter("@Color", cloth.Color));
                    try
                    {
                        result = cmd.ExecuteNonQuery();
                    }
                    catch (SQLiteException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }                     
                return result;
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
                string sql = "SELECT * FROM tbl_clothes";
                C.Con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(C.Con))
                {
                    cmd.CommandText = sql;
                    SQLiteDataAdapter Sda = new SQLiteDataAdapter(cmd);
                    Sda.Fill(dt);
                }              
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
                    string sql = "SELECT tbl_clothes.Name FROM tbl_clothes Where SKU =  @SKUNumber";
                    C.Con.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(C.Con))
                    {
                        cmd.CommandText = sql;
                        cmd.Parameters.Add(new SQLiteParameter("@SKUNumber", SKUNumber));
                        SQLiteDataAdapter Sda = new SQLiteDataAdapter(cmd);
                        Sda.Fill(NameOfProduct);
                    }
                
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
