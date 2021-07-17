using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeW_14._07._2021_WorkPart
{
    public partial class PStation : Form
    {
        static double SumOfAllPays = 0;
        List<Fuel> TypesOfFuel = new List<Fuel>
        {
            new Fuel {Name = "98" , Price = 34},
            new Fuel {Name = "95" , Price = 32},
            new Fuel {Name = "92" , Price = 30},
            new Fuel {Name = "80" , Price = 28}

        };
        public PStation()
        {
            InitializeComponent();
            TypeOfPetrol.DataSource = TypesOfFuel;
            TypeOfPetrol.DisplayMember = "Name";
            TypeOfPetrol.ValueMember = "Price";
            TypeOfPetrol.SelectedIndex = 2;


        }

        private void TypeOfPetrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPrise.Text = "Price : " + (sender as ComboBox).SelectedValue;
        }

        private void rbPrice_CheckedChanged(object sender, EventArgs e)
        {
            if(rbPrice.Checked)
            {
                tbPrice.ReadOnly = false;
                tbNumber.ReadOnly = true;
                tbNumber.Text = "";

                lblPetrolPay.Text = "You will take :";
            }
            else if (rbNumber.Checked)
            {
                tbNumber.ReadOnly = false;
                tbPrice.ReadOnly = true;
                tbPrice.Text = "";
                lblPetrolPay.Text = "You must pay :";
            }
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
            
             int number = Convert.ToInt32((sender as TextBox).Text);
             int price = Convert.ToInt32(TypeOfPetrol.SelectedValue);
             lblPetrolPay.Text = "You must pay : " + number * price + " grn";
             lblSumPay.Text = $"{number*price + Convert.ToDouble(lblSumPayShop.Text)}";

        }

        private void tbPrice_TextChanged_1(object sender, EventArgs e)
        {
            double OnPrice = Convert.ToDouble((sender as TextBox).Text);
            double price = Convert.ToDouble(TypeOfPetrol.SelectedValue);
            double TotalPay = OnPrice/price;
            lblPetrolPay.Text = "You will take : " + TotalPay; 
            lblSumPay.Text = $"{OnPrice + Convert.ToDouble(lblSumPayShop.Text)}";
        }

        private void cbShopBigHD_CheckedChanged(object sender, EventArgs e)
        {
            if (tbPriceBigHD.ReadOnly)
            {
                tbPriceBigHD.ReadOnly = false;
            }
            else
            {
                tbPriceBigHD.ReadOnly = true;
                tbPriceBigHD.Text = "0";

            }
        }

        private void cbShopMidHD_CheckedChanged(object sender, EventArgs e)
        {
            if (tbPriceMidHD.ReadOnly)
            {
                tbPriceMidHD.ReadOnly = false;
            }
            else
            {
                tbPriceMidHD.ReadOnly = true;
                tbPriceMidHD.Text = "0";
            }
        }

        private void cbShopLitHD_CheckedChanged(object sender, EventArgs e)
        {
            if (tbPriceLitHD.ReadOnly)
            {
                tbPriceLitHD.ReadOnly = false;
            }
            else
            {
                tbPriceLitHD.ReadOnly = true;
                tbPriceLitHD.Text = "0";
            }
        }

        private void cbShopSprite_CheckedChanged(object sender, EventArgs e)
        {
            if (tbPriceSprite.ReadOnly)
            {
                tbPriceSprite.ReadOnly = false;
            }
            else
            {
                tbPriceSprite.ReadOnly = true;
                tbPriceSprite.Text = "0";
            }
        }

        private void cbShopPepsi_CheckedChanged(object sender, EventArgs e)
        {
            if (tbPricePepsi.ReadOnly)
            {
                tbPricePepsi.ReadOnly = false;
            }
            else
            {
                tbPricePepsi.ReadOnly = true;
                tbPricePepsi.Text = "0";
            }
        }

        private void cbShopBlackTea_CheckedChanged(object sender, EventArgs e)
        {
            if (tbPriceBlackTea.ReadOnly)
            {
                tbPriceBlackTea.ReadOnly = false;
            }
            else
            {
                tbPriceBlackTea.ReadOnly = true;
                tbPriceBlackTea.Text = "0";
            }
        }

        private void tbPriceBigHD_TextChanged(object sender, EventArgs e)
        {
            int ShopSum = 0;
            if(tbPriceBigHD.ReadOnly == false && tbPriceBigHD.Text != "")
            {
                ShopSum += Convert.ToInt32(tbPriceBigHD.Text) * Convert.ToInt32(tbBigHD.Text);
            }
            if (tbPriceMidHD.ReadOnly == false && tbPriceMidHD.Text != "")
            {
                ShopSum += Convert.ToInt32(tbPriceMidHD.Text) * Convert.ToInt32(tbMidHD.Text);
            }
            if (tbPriceLitHD.ReadOnly == false && tbPriceLitHD.Text != "")
            {
                ShopSum += Convert.ToInt32(tbPriceLitHD.Text) * Convert.ToInt32(tbLitHD.Text);
            }
            if (tbPriceSprite.ReadOnly == false && tbPriceSprite.Text != "")
            {
                ShopSum += Convert.ToInt32(tbPriceSprite.Text) * Convert.ToInt32(tbSprite.Text);
            }
            if (tbPricePepsi.ReadOnly == false && tbPricePepsi.Text != "")
            {
                ShopSum += Convert.ToInt32(tbPricePepsi.Text) * Convert.ToInt32(tbPepsi.Text);
            }
            if (tbPriceBlackTea.ReadOnly == false && tbPriceBlackTea.Text != "")
            {
                ShopSum += Convert.ToInt32(tbPriceBlackTea.Text) * Convert.ToInt32(tbBlackTea.Text);
            }
            lblSumPayShop.Text = $"{ShopSum}";
            if (rbNumber.Checked)
            {
                lblSumPay.Text = $"{ShopSum + Convert.ToInt32(tbNumber.Text) * Convert.ToInt32(TypeOfPetrol.SelectedValue)}";
            }
            else if (rbPrice.Checked)
            {
                lblSumPay.Text = $"{ShopSum + Convert.ToDouble(tbPrice.Text)}";

            }
            else
            {
                lblSumPay.Text = $"{ShopSum}";
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            SumOfAllPays += Convert.ToInt32(lblSumPay.Text);
            (sender as Button).Parent.Parent.Text = $"Petrol Station \t\nTotal sum of Pays : {SumOfAllPays}";
            TypeOfPetrol.Text = "92";
            rbNumber.Checked = false;
            rbPrice.Checked = false;
            tbNumber.Text = "";
            tbPrice.Text = "";
            tbPrice.ReadOnly = true;
            tbNumber.ReadOnly = true;            
            lblPetrolPay.Text = "You must pay :";
            lblSumPay.Text = "0";
            lblSumPayShop.Text = "0";
            cbShopBigHD.Checked = false;
            cbShopMidHD.Checked = false;
            cbShopLitHD.Checked = false;
            cbShopSprite.Checked = false;
            cbShopPepsi.Checked = false;
            cbShopBlackTea.Checked = false;
        }
    }
}
