using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solo
{
    public partial class UCMeals : UserControl
    {
        public UCMeals()
        {
            InitializeComponent();
        }

        private void UCMeals_Load(object sender, EventArgs e)
        {
            txtAmount.Text = "1";
            
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtAmount.Text, out int amount))
            {
                amount--;
                txtAmount.Text = amount.ToString();
            }
            else 
            {
                MessageBox.Show("商品數量須為正整數");
                txtAmount.Text = "1";
            }

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtAmount.Text, out int amount))
            {
                amount++;
                txtAmount.Text = amount.ToString();
            }
            else
            {
                MessageBox.Show("商品數量須為正整數");    
            }
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(txtAmount.Text, out int amount) && amount > 0)
            {
                Int32.TryParse(lblPrice.Text, out int price);
                ArrayList orders = new ArrayList();//要加編號
                orders.Add(GlobalVar.userID);
                orders.Add((int)pbGoods.Tag);//goodsid
                orders.Add(lblGoodsName.Text);
                orders.Add(price);
                orders.Add(amount);
                orders.Add(GlobalVar.tableID);
                orders.Add(DateTime.Now);
                orders.Add(false);
                orders.Add(GlobalVar.OrderNum);
                GlobalVar.cart.Add(orders);
                GlobalVar.OrderNum++;
                MessageBox.Show("已加入購物車");
                txtAmount.Text = "1";
            }
            else
            {
                MessageBox.Show("商品數量須為正整數");
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (!Int32.TryParse(txtAmount.Text, out int amount) || amount <= 0)
            {
                MessageBox.Show("商品數量須為正整數");
                txtAmount.Text="1";
            }
        }
    }
}
