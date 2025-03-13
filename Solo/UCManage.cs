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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Solo
{
    public partial class UCManage : UserControl
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        Dictionary<string, string> ColumnDic = new Dictionary<string, string>();
        string keyword = "";

        public UCManage()
        {
            InitializeComponent();
        }

        private void UCManage_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MidternPersonalProject";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();

            lblSeat_Click(sender, e);
            if (GlobalVar.permission == "boss")
            {
                lblProfit.Visible = true;
            }
        }

        private void lblSeat_Click(object sender, EventArgs e)
        {
            flpManage.Size = new System.Drawing.Size(793, 535);
            flpManage.Controls.Clear();
            
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select * from Seat;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                UCSeat seat = new UCSeat();
                seat.btnSeat.Text = reader["SeatID"].ToString();
                flpManage.Controls.Add(seat);
            }
            GlobalVar.page = "home";
            reader.Close();
            con.Close();
        }

        private void lblOrderManage_Click(object sender, EventArgs e)
        {
            lblEmployeeManage.Visible = false;
            GlobalVar.page = "order";
            btnAddNew.Visible = false;
            flpManage.Size = new System.Drawing.Size(793, 470);
            flpManage.Controls.Clear();
            UCOrderManage orderManage = new UCOrderManage();
            flpManage.Controls.Add(orderManage);
            
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = $"select OrderID, GoodsName, OrderAmount, SeatID, OrderTime, IsDone from Orders where (OrderTime >= DATEADD(HOUR, -24, GETDATE())) {keyword};";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (!reader.HasRows)
            {
                MessageBox.Show("查無資料");
                return;
            }
            while (reader.Read())
            {
                UCOrderManage orderManage1 = new UCOrderManage();
                orderManage1.lblOrderID.Text = reader["OrderID"].ToString();
                orderManage1.lblGoodsName.Text = (string)reader["GoodsName"];
                orderManage1.lblGoodsAmount.Text = reader["OrderAmount"].ToString();
                orderManage1.lblTableID.Text = reader["SeatID"].ToString();
                orderManage1.lblOrderTime.Text = ((DateTime)reader["OrderTime"]).ToString("HH:mm");
                orderManage1.lblIsDone.Text = "";
                if ((bool)reader["IsDone"] is true)
                {
                    orderManage1.lblIsDone.BackColor = Color.Green;

                }
                else
                {
                    orderManage1.lblIsDone.BackColor = Color.Red;
                }
                flpManage.Controls.Add(orderManage1);
            }
            reader.Close();
            con.Close();

            cbxColumn.Items.Clear();
            cbxColumn.Items.AddRange(new string[] { "訂單編號", "商品名稱", "桌號" });
            ColumnDic.Clear();
            ColumnDic.Add("訂單編號", "OrderID");
            ColumnDic.Add("商品名稱", "GoodsName");
            ColumnDic.Add("桌號", "SeatID");
        }

        private void lblMemberManage_Click(object sender, EventArgs e)
        {
            if (GlobalVar.permission == "boss")
            {
                lblEmployeeManage.Visible = true;
            }
            GlobalVar.page = "member";
            btnAddNew.Visible = true;
            flpManage.Size = new System.Drawing.Size(793, 470);
            flpManage.Controls.Clear();
            UCPersonManage PersonManage = new UCPersonManage();
            PersonManage.lblDetail.Enabled = false;
            flpManage.Controls.Add(PersonManage);
           
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = $"select * from Persons where role = 'member' {keyword};";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                MessageBox.Show("查無資料");
                return;
            }

            while (reader.Read())
            {
                UCPersonManage PersonManage1 = new UCPersonManage();
                PersonManage1.lblPersonID.Text = reader["PersonID"].ToString();
                PersonManage1.lblName.Text = reader["name"].ToString();
                PersonManage1.lblPhone.Text = (string)reader["phone"];
                PersonManage1.lblBirth.Text = ((DateTime)reader["birthday"]).ToString("MM/dd");
                flpManage.Controls.Add(PersonManage1);
            }
            reader.Close();
            con.Close();

            cbxColumn.Items.Clear();
            cbxColumn.Items.AddRange(new string[] { "會員編號", "會員姓名", "電話" });
            ColumnDic.Clear();
            ColumnDic.Add("會員編號", "PersonID");
            ColumnDic.Add("會員姓名", "name");
            ColumnDic.Add("電話", "phone");
        }

        private void lblGoodsManage_Click(object sender, EventArgs e)
        {
            lblEmployeeManage.Visible = false;
            btnAddNew.Visible = true;
            GlobalVar.page = "goods";
            flpManage.Size = new System.Drawing.Size(793, 470);
            flpManage.Controls.Clear();
            

            UCGoodsManage goodsManage = new UCGoodsManage();
            goodsManage.txtGoodsAmount.ReadOnly = true;
            goodsManage.txtGoodsName.ReadOnly = true;
            goodsManage.txtGoodsPrice.ReadOnly = true;
            goodsManage.cbxGoodsClass.Enabled = false;
            goodsManage.btnDelete.Enabled = false;
            goodsManage.lblChangePic.Enabled = false;
            goodsManage.lblSaveChange.Enabled = false;
            flpManage.Controls.Add(goodsManage);

            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = $"select * from Goods {keyword};";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                MessageBox.Show("查無資料");
                return;
            }

            while (reader.Read())
            {
                UCGoodsManage goodsManage1 = new UCGoodsManage();
                goodsManage1.lblGoodsID.Text = reader["GoodsID"].ToString();
                goodsManage1.txtGoodsAmount.Text = reader["GoodsAmount"].ToString();
                goodsManage1.txtGoodsName.Text = (string)reader["GoodsName"];
                goodsManage1.txtGoodsPrice.Text = reader["GoodsPrice"].ToString();
                goodsManage1.cbxGoodsClass.Text = (string)reader["GoodsClass"];
                flpManage.Controls.Add(goodsManage1);
            }
            reader.Close();
            con.Close();

            cbxColumn.Items.Clear();
            cbxColumn.Items.AddRange(new string[] { "商品編號", "商品名稱", "商品分類" });
            ColumnDic.Clear();
            ColumnDic.Add("商品編號", "GoodsID");
            ColumnDic.Add("商品名稱", "GoodsName");
            ColumnDic.Add("商品分類", "GoodsClass");
        }

        private void lblEmployeeManage_Click(object sender, EventArgs e)
        {

            GlobalVar.page = "employee";
            btnAddNew.Visible = true;
            flpManage.Size = new System.Drawing.Size(793, 470);
            flpManage.Controls.Clear();
            UCPersonManage PersonManage = new UCPersonManage();
            PersonManage.lblPersonID.Text = "員工編號";
            PersonManage.lblName.Text = "員工姓名";
            PersonManage.lblDetail.Enabled = false;
            flpManage.Controls.Add(PersonManage);
            
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = $"select * from Persons where role = 'employee' {keyword};";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (!reader.HasRows)
            {
                MessageBox.Show("查無資料");
                return;
            }
            while (reader.Read())
            {
                UCPersonManage PersonManage1 = new UCPersonManage();
                PersonManage1.lblPersonID.Text = reader["PersonID"].ToString();
                PersonManage1.lblName.Text = reader["name"].ToString();
                PersonManage1.lblPhone.Text = (string)reader["phone"];
                PersonManage1.lblBirth.Text = ((DateTime)reader["birthday"]).ToString("MM/dd");
                flpManage.Controls.Add(PersonManage1);
            }
            reader.Close();
            con.Close();

            cbxColumn.Items.Clear();
            cbxColumn.Items.AddRange(new string[] { "員工編號", "員工姓名", "電話" });
            ColumnDic.Clear();
            ColumnDic.Add("員工編號", "PersonID");
            ColumnDic.Add("員工姓名", "name");
            ColumnDic.Add("電話", "phone");
        }


        private void lblProfit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select total from History where date between @Start and @End;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            DateTime dt = new DateTime(DateTime.Now.Year,DateTime.Now.Month-1,1);
            cmd.Parameters.AddWithValue("@Start", dt.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@End", DateTime.Now.ToString("yyyy-MM-dd"));
            SqlDataReader reader = cmd.ExecuteReader();
            int MonthProfit = 0;
            while (reader.Read())
            {
                MonthProfit += (int)reader["total"];
            }
            MessageBox.Show($"前月收入: {MonthProfit}元");
            reader.Close();
            con.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            switch (GlobalVar.page)
            {
                case "goods":
                    GlobalVar.selectMode = "add";
                    GoodsManage goodsManage = new GoodsManage();
                    goodsManage.ShowDialog();
                    break;
                case "member":
                    GlobalVar.selectMode = "add";
                    PersonDetail personDetail = new PersonDetail();
                    personDetail.ShowDialog();
                    break;
                case "employee":
                    GlobalVar.selectMode = "add";
                    PersonDetail personDetail2 = new PersonDetail();
                    personDetail2.ShowDialog();
                    break;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtKeyword.Text != "") 
            { 
                keyword = $"where {ColumnDic[cbxColumn.Text]} like '%{txtKeyword.Text.Trim()}%'";
                switch (GlobalVar.page)
                {
                    case "goods":

                        lblGoodsManage_Click(sender, e);
                        keyword = "";
                        break;
                    case "member":
                        keyword = $"and {ColumnDic[cbxColumn.Text]} like %{txtKeyword.Text.Trim()}%'";
                        lblMemberManage_Click(sender, e);
                        keyword = "";
                        break;
                    case "employee":
                        keyword = $"and {ColumnDic[cbxColumn.Text]} like %{txtKeyword.Text.Trim()}%'";
                        lblEmployeeManage_Click(sender, e);
                        keyword = "";
                        break;
                    case "order":
                        keyword = $"and {ColumnDic[cbxColumn.Text]} like %{txtKeyword.Text.Trim()}%'";
                        lblOrderManage_Click(sender, e);
                        keyword = "";
                        break;
                    case "history":
                        lblHistory_Click(sender, e);
                        break;
                }
            }
            else
            {
                MessageBox.Show("請輸入關鍵字");
            }
        }

        private void lblHistory_Click(object sender, EventArgs e)
        {
            lblEmployeeManage.Visible = false;
            btnAddNew.Visible = true;
            GlobalVar.page = "history";
            flpManage.Size = new System.Drawing.Size(793, 470);
            flpManage.Controls.Clear();

            UCHistory history = new UCHistory();
            flpManage.Controls.Add(history);

            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = $"select * from History {keyword};";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (!reader.HasRows)
            {
                MessageBox.Show("查無資料");
                return;
            }
            while (reader.Read())
            {
                UCHistory history1 = new UCHistory();
                history1.lblPersonID.Text = reader["PersonID"].ToString();
                history1.lblDate.Text = ((DateTime)reader["date"]).ToString("yyyy/MM/dd");
                history1.lblTime.Text = ((TimeSpan)reader["usingtime"]).ToString(@"hh\:mm");
                history1.lblTotal.Text = reader["total"].ToString();
                history1.lblSeatID.Text = reader["SeatID"].ToString();
                flpManage.Controls.Add(history1);
            }
            reader.Close();
            con.Close();

            cbxColumn.Items.Clear();
            cbxColumn.Items.AddRange(new string[] { "會員編號", "日期", "桌號" });
            ColumnDic.Clear();
            ColumnDic.Add("會員編號", "PersonID");
            ColumnDic.Add("日期", "date");
            ColumnDic.Add("桌號", "SeatID");
        }
    }
}
