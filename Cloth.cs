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
        public string Name { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }


        public string ProductColor()
        {
            try
            {
                if (SKUNumber.Length == 12)
                {
                    if (SKUNumber.Substring(7, 2) == "BL")
                    {
                        return Color = "BLACK";
                    }
                    else if (SKUNumber.Substring(7, 2) == "GR")
                    {
                        return Color = "GREEN";
                    }
                    else
                    {
                        return Color = "Invalid Colour";
                    }
                }
                else
                {
                    MessageBox.Show("Invalid SKU Code");
                    return Color = "Invalid Colour";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        public string ProductSize()
        {
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
                return Size = "Invalid Size";
            }
        }

        public string ProductName()
        {
            string Name = SKUNumber.Substring(0, 6);
            return Name;
        }
    }
}

