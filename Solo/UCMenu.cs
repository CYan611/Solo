using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Solo
{
    public partial class UCMenu : UserControl
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        public UCMenu()
        {
            InitializeComponent();
        }

        private void UCMenu_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MidternPersonalProject";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();

            Menushow("");
        }
        
        private void  Menushow(string keyWord)
        {
            flpMenu.Size = new System.Drawing.Size(793, 535);
            flpMenu.Controls.Clear();
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = $"select * from Goods {keyWord};";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                UCMeals meals = new UCMeals();
                meals.pbGoods.Tag = (int)reader["GoodsID"];
                meals.lblGoodsName.Text = (string)reader["GoodsName"];
                meals.lblPrice.Text = $"{(int)reader["GoodsPrice"]}";
                string image_name = (string)reader["GoodsImage"];
                string ImgPath = GlobalVar.image_dir + @"\" + image_name;
                System.IO.FileStream fs = System.IO.File.OpenRead(ImgPath);
                meals.pbGoods.Image = Image.FromStream(fs);
                fs.Close();
                flpMenu.Controls.Add(meals);
            }
            reader.Close();
            con.Close();
        }

        private void lblHomePage_Click(object sender, EventArgs e)
        {
            Menushow("");
        }

        private void lblFood_Click(object sender, EventArgs e)
        {
            Menushow("where GoodsClass = 'food'");
        }

        private void lblDessert_Click(object sender, EventArgs e)
        {
            Menushow("where GoodsClass = 'dessert'");
        }

        private void lblDrink_Click(object sender, EventArgs e)
        {
            Menushow("where GoodsClass = 'drink'");
        }

        private void lblCheckOrder_Click(object sender, EventArgs e)
        {
            flpMenu.Controls.Clear();
            flpMenu.Size = new System.Drawing.Size(793, 436);
            UCOrderList title = new UCOrderList();
            flpMenu.Controls.Add(title);
            // name price amount  ordertime 狀態
            foreach (ArrayList order in GlobalVar.cart)// if 狀態
            {
                UCOrderList Order = new UCOrderList();
                Order.lblGoodsName.Text = order[2].ToString();
                Order.lblGoodsPrice.Text = order[3].ToString();
                Order.lblOrderAmount.Text = order[4].ToString();
                Order.lblOrderTime.Text = ((DateTime)order[6]).ToString("HH:mm");
                Order.Tag = order[8];
                if (order[7] is true)
                {
                    Order.btnDelete.Visible = false;
                }
                
               
                flpMenu.Controls.Add(Order);
            }
        }


        private void btnReturnMenu_Click(object sender, EventArgs e)
        {
            Menushow("");
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            flpMenu.Controls.Clear();
            UCOrderList title = new UCOrderList();
            title.btnDelete.Enabled = false;
            flpMenu.Controls.Add(title);
            var cartCopy = new List<ArrayList>(GlobalVar.cart); // 建立副本
            foreach (ArrayList order in cartCopy)
            {
                if (order[7] is false)
                {
                    GlobalVar.cart.Remove(order); // 在原集合中移除符合條件的項目
                }
            }
            lblCheckOrder_Click(sender, e);
        }

        private void btnSendOrder_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = $"Insert into Orders values(@PersonID, @GoodsID, @GoodsName, @GoodsPrice, @GoodsAmount, @SeatID, @orderTime, @IsDone)";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            foreach (ArrayList order in GlobalVar.cart)
            {
                if (order[7] is false)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@PersonID", order[0]);
                    cmd.Parameters.AddWithValue("@GoodsID", order[1]);
                    cmd.Parameters.AddWithValue("@GoodsName", order[2]);
                    cmd.Parameters.AddWithValue("@GoodsPrice", order[3]);
                    cmd.Parameters.AddWithValue("@GoodsAmount", order[4]);
                    cmd.Parameters.AddWithValue("@SeatID", order[5]);
                    cmd.Parameters.AddWithValue("@orderTime", order[6]);
                    cmd.Parameters.AddWithValue("@IsDone", false);
                    order[7] = true;
                    cmd.ExecuteNonQuery();
                    GlobalVar.OrderTotal.Add((int)order[3] * (int)order[4]);
                }
            }
            con.Close();
            MessageBox.Show("已送出訂單");
            lblCheckOrder_Click(sender, e);

            con.Open();
            Dictionary<int, (int order,int stock)> AmountChange = new Dictionary<int, (int, int)>();
            strSQL = $"select GoodsAmount from Goods where GoodsID = @ID";
            SqlCommand cmd1 = new SqlCommand(strSQL, con);
            foreach (ArrayList order in GlobalVar.cart)
            {
                cmd1.Parameters.Clear();
                cmd1.Parameters.AddWithValue("@ID", order[1]);
                using (SqlDataReader reader = cmd1.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int newAmount = (int)reader["GoodsAmount"] - (int)order[4];
                        reader.Close();

                        strSQL = "update Goods set GoodsAmount = @Amount where GoodsID = @ID";
                        SqlCommand cmd2 = new SqlCommand(strSQL, con);
                        cmd2.Parameters.AddWithValue("@Amount", newAmount);
                        cmd2.Parameters.AddWithValue("@ID", order[1]);
                        cmd2.ExecuteNonQuery();
                    }
                }
            }
            con.Close();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            GlobalVar.Total = 0;
            
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select IsDone from Orders where IsDone = 0 and SeatID = @SearchID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchID", GlobalVar.tableID);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("請確認餐點以出餐完畢");
                return;
            }
            else
            {
                foreach(int pay in GlobalVar.OrderTotal)
                {
                    GlobalVar.Total += pay;
                }
            }
            reader.Close();
            con.Close();

            if(GlobalVar.Total < 80)
            {
                GlobalVar.Total = 80;
            }
            int meattotal = GlobalVar.Total;
            int UsingHour = (int)Math.Ceiling(GlobalVar.TimePass.TotalHours);
            switch (GlobalVar.permission)
            {
                case "member":
                    GlobalVar.Total += UsingHour * 90;
                    break;
                case "guest":
                    GlobalVar.Total += UsingHour * 100;
                    break;
            }

            con.Open();
            strSQL = "insert into History values(@ID, @Date, @Time, @Total, @SeatID)";
            SqlCommand cmd2 = new SqlCommand(strSQL, con);
            cmd2.Parameters.AddWithValue("@ID", GlobalVar.userID);
            cmd2.Parameters.AddWithValue("@Date", DateTime.Now.Date);
            cmd2.Parameters.AddWithValue("@Time", GlobalVar.TimePass.ToString(@"hh\:mm\:ss"));
            cmd2.Parameters.AddWithValue("@Total", GlobalVar.Total);
            cmd2.Parameters.AddWithValue("@SeatID", GlobalVar.tableID);
            cmd2.ExecuteNonQuery();
            con.Close();

            if (GlobalVar.permission == "guest")
            {
                MessageBox.Show($"餐點:{meattotal}元(含低消)\n使用時間:{UsingHour}小時(未滿一小時以一小時算)\n{UsingHour * 100}元\n總共{GlobalVar.Total}元");
            }
            else
            {
                MessageBox.Show($"餐點: {meattotal}元(含低消)\n使用時間: {UsingHour}小時(未滿一小時以一小時算)\n{UsingHour * 100}元\n會員優惠: -{UsingHour * 10}\n總共{GlobalVar.Total}元");
            }
            this.FindForm().Close();
        }
    }
}
