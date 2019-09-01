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
        DAL dal = new DAL();

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
                    if (SKUNumber.Contains("BK"))
                    {
                        Color = "Black";
                    }
                    else if (SKUNumber.Contains("GR"))
                    {
                        Color = "Green";
                    }
                    else if (SKUNumber.Contains("WH"))
                    {
                        Color = "White";
                    }
                    else if (SKUNumber.Contains("BE"))
                    {
                        Color = "Beige";
                    }
                    else if (SKUNumber.Contains("AP"))
                    {
                        Color = "Apricot";
                    }
                    else if (SKUNumber.Contains("KH"))
                    {
                        Color = "Khaki";
                    }
                    else if (SKUNumber.Contains("BR"))
                    {
                        Color = "Brown";
                    }
                    else if (SKUNumber.Contains("BL"))
                    {
                        Color = "Blue";
                    }
                    else if (SKUNumber.Contains("RD"))
                    {
                        Color = "Red";
                    }
                    else if (SKUNumber.Contains("GY"))
                    {
                        Color = "Gray";
                    }
                    else
                    {
                        Color = "";
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
            string SizeKey = "";
            if (string.IsNullOrEmpty(SKUNumber))
            {
                MessageBox.Show("SKU Number cannot be null or Empty");
                return Size = "";               
            }
            if(!string.IsNullOrEmpty(SKUNumber) && SKUNumber.Length > 6)
                SizeKey = SKUNumber.Substring(SKUNumber.Length - 2);

            if (SizeKey == "01")
            {
                return Size = "XS";
            }
            else if (SizeKey == "02")
            {
                return Size = "S";
            }
            else if (SizeKey == "03")
            {
                return Size = "M";
            }
            else if (SizeKey == "04")
            {
                return Size = "L";
            }
            else if (SizeKey == "05")
            {
                return Size = "XL";
            }
            else if (SizeKey == "06")
            {
                return Size = "XXL";
            }
            else if (SizeKey == "28")
            {
                return Size = "XS";
            }
            else if (SizeKey == "30")
            {
                return Size = "S";
            }
            else if (SizeKey == "32")
            {
                return Size = "M";
            }
            else if (SizeKey == "34")
            {
                return Size = "L";
            }
            else if (SizeKey == "36")
            {
                return Size = "XL";
            }
            else if (SizeKey == "38")
            {
                return Size = "XXL";
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

            Name = dal.GetName(SKUNumber);
            if (!string.IsNullOrEmpty(Name))
                return Name;
            else
                return "";
        }
    }
}
