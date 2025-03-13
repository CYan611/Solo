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
    public partial class UCOrderList : UserControl
    {
        public UCOrderList()
        {
            InitializeComponent();
        }

        private void UCOrderList_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);

            var cartCopy = new List<ArrayList>(GlobalVar.cart); // 建立副本
            foreach (ArrayList order in cartCopy)
            {
                if (order[8] == this.Tag)
                {
                    GlobalVar.cart.Remove(order); // 在原集合中移除符合條件的項目
                }
            }
        }
    }
}
