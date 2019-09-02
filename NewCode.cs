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
    public partial class NewCode : Form

    {

        readonly Cloth cloth = new Cloth();
        readonly DAL dal = new DAL();

        public NewCode()
        {
            InitializeComponent();
        }

        private void NewCode_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            cloth.SKUNumber = textBox1.Text.ToString();  // Takes value from text box input value
            cloth.Name = textBox1.Text.ToString();
            cloth.Color = textBox2.Text.ToString();
            cloth.Size = textBox3.Text.ToString();

            int Result = dal.InsertCloth(cloth);
            try
            {
                if (Result > 0)
                {
                    MessageBox.Show("Product Added Successfully");

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
    }
}
