using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BabatyeInventory
{
    class Cloth
    {
        public string SKUNumber { get; set; }
        public string Name { get; set;}
        public string Size { get; set; }
        public string Color { get; set; }


        public string ProductColor()
        {
            if (string.IsNullOrEmpty(SKUNumber))
            {
                MessageBox.Show("SKU Number cannot be null or Empty");
                return Color = "";
            }
            else
            {
                try
                {
                    if (SKUNumber.Substring(7, 2) == "BL")
                    {
                        Color = "BLACK";
                    }
                    else if (SKUNumber.Substring(7, 2) == "GR")
                    {
                        Color = "GREEN";
                    }
                    else
                    {
                        Color = "Null";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Color = ex.Message;
                }
                return Color;
            }
        }

        public string ProductSize()
        {
            if (string.IsNullOrEmpty(SKUNumber))
            {
                MessageBox.Show("SKU Number cannot be null or Empty");
                return Size = "";               
            }
           string SizeKey = SKUNumber.Substring(10, 2);

            if (SizeKey == "02")
            {
                return Size = "Small";
            }
            else if (SizeKey == "03")
            {
                return Size = "Medium";
            }
            else if (SizeKey == "04")
            {
                return Size = "Large";
            }
            else
            {
                return Size = "";
            }
        }

        public string ProductName()
        {
            if (string.IsNullOrEmpty(SKUNumber))
            {
                MessageBox.Show("SKU Number cannot be null or Empty");
                return Name = "";
            } 
            Name = SKUNumber.Substring(0, 6);
            return Name;
        }
    }
}
