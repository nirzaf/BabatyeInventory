using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BabatyeInventory
{
    public partial class Main : Form
    {
        readonly Cloth cloth = new Cloth();
        readonly DAL dal = new DAL();
        

        public Main()
        {
            InitializeComponent();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            cloth.SKUNumber = TxtSKUNum.Text.Trim();  // Takes value from text box input value
            cloth.Name = cloth.ProductName();   
            cloth.Color = cloth.ProductColor();
            cloth.Size = cloth.ProductSize();

            int Result = dal.InsertCloth(cloth);
            try
            {
                if (Result > 0)
                {
                    MessageBox.Show("Product Added Successfully");
                    this.tbl_clothsTableAdapter.Fill(this.babatyeDataSet.tbl_cloths);
                }
                else
                {
                    MessageBox.Show("Something Went Wrong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            cloth.SKUNumber = TxtSKUNum.Text.Trim();
            label1.Text = cloth.ProductColor();
            label2.Text = cloth.ProductSize();
            label3.Text = cloth.ProductName();

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'babatyeDataSet.tbl_cloths' table. You can move, or remove it, as needed.
            this.tbl_clothsTableAdapter.Fill(this.babatyeDataSet.tbl_cloths);

        }

        private void TxtSKUNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TxtSKUNum.Text.Length > 11)
            {
                cloth.SKUNumber = TxtSKUNum.Text.Trim();
                label1.Text = cloth.ProductColor();
                label2.Text = cloth.ProductSize();
                label3.Text = cloth.ProductName();
            }

        }

        private void TxtSKUNum_KeyUp(object sender, KeyEventArgs e)
        {
            if (TxtSKUNum.Text.Length > 11)
            {
                cloth.SKUNumber = TxtSKUNum.Text.Trim();
                label1.Text = cloth.ProductColor();
                label2.Text = cloth.ProductSize();
                label3.Text = cloth.ProductName();
            }
        }

        private void TxtSKUNum_TextChanged(object sender, EventArgs e)
        {

            
            if (TxtSKUNum.Text.Length > 11)
            {
                cloth.SKUNumber = TxtSKUNum.Text.Trim();
                label1.Text = cloth.ProductColor();
                label2.Text = cloth.ProductSize();
                label3.Text = cloth.ProductName();


                SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=babatye;Integrated Security=True");
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM tbl_cloths WHERE tbl_cloths.SKU = @SKUNumber", conn);
                command.Parameters.AddWithValue("@SKUNumber", TxtSKUNum.Text.ToString());
                // int result = command.ExecuteNonQuery();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                       
                    }
                    else {

                        MessageBox.Show("Do you need to add this product","New product alert", MessageBoxButtons.YesNo);
                        new NewCode().Show(); }


                }

                conn.Close();
            }

           

        }
    }
}
