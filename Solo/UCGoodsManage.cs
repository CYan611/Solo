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

namespace Solo
{
    public partial class UCGoodsManage : UserControl
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        public UCGoodsManage()
        {
            InitializeComponent();
        }

        private void UCGoodsManage_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MidternPersonalProject";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();

        }

        private void lblChangePic_Click(object sender, EventArgs e)
        {
            Int32.TryParse(lblGoodsID.Text, out int id);
            GlobalVar.SearchID = id;
            GlobalVar.selectMode = "detail";
            GoodsManage goodsManage = new GoodsManage();
            goodsManage.ShowDialog(); 
        }

        private void lblSaveChange_Click(object sender, EventArgs e)
        {
            if(!Int32.TryParse(txtGoodsAmount.Text, out int amount) || !Int32.TryParse(txtGoodsPrice.Text, out int price))
            {
                MessageBox.Show("請輸入正整數");
                return;
            }
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "update Goods set GoodsAmount = @NewAmount, GoodsName = @NewName, GoodsPrice = @NewPrice, GoodsClass = @NewClass where GoodsID = @SearchID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", lblGoodsID.Text);
            cmd.Parameters.AddWithValue("@NewAmount", amount);
            cmd.Parameters.AddWithValue("@NewName", txtGoodsName.Text);
            cmd.Parameters.AddWithValue("@NewPrice", price);
            cmd.Parameters.AddWithValue("@NewClass", cbxGoodsClass.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("修改成功");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "delete FROM Goods where GoodsID = @GoodsID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@GoodsID",lblGoodsID.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("刪除成功");
        }
    }
}
