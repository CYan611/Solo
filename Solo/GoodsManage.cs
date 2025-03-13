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
    public partial class GoodsManage : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string ImgName = "";
        public GoodsManage()
        {
            InitializeComponent();
        }

        void SelectImage()
        {

        }
        private void GoodsManage_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MidternPersonalProject";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();
            switch (GlobalVar.selectMode)
            {
                case "add":
                    btnChangeOrAdd.Text = "新增資料";
                    break;
                case "detail":
                    btnChangeOrAdd.Text = "修改資料";
                    SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                    con.Open();
                    string strSQL = $"SELECT * FROM Goods where GoodsID = @ID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@ID", GlobalVar.SearchID);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lblID.Text = GlobalVar.SearchID.ToString();
                        txtName.Text = (string)reader["GoodsName"];
                        txtAmount.Text = reader["GoodsAmount"].ToString();
                        txtPrice.Text = reader["GoodsPrice"].ToString();
                        cbxClass.SelectedItem = (string)reader["GoodsClass"];
                        ImgName = reader["GoodsImage"].ToString();
                        string strImgFullPath = GlobalVar.image_dir + @"\" + ImgName;
                        System.IO.FileStream fs = System.IO.File.OpenRead(strImgFullPath);
                        pbGoods.Image = Image.FromStream(fs);
                        fs.Close();
                        pbGoods.Tag = strImgFullPath;
                    }
                    reader.Close();
                    con.Close();
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangeOrAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            switch (GlobalVar.selectMode)
            {

                case "add":
                    if (txtAmount.Text != "" &&  txtName.Text != "" && txtPrice.Text != "" && cbxClass.SelectedItem != null && pbGoods.Image != null)
                    {
                        con.Open();
                        string strSQL = $"Insert into Goods values(@NewAmount, @NewName, @NewPrice, @NewClass, @NewImage)";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        Int32.TryParse(txtAmount.Text, out int amount);
                        cmd.Parameters.AddWithValue("@NewAmount", amount);
                        cmd.Parameters.AddWithValue("@NewName", txtName.Text);
                        Int32.TryParse(txtPrice.Text, out int price);
                        cmd.Parameters.AddWithValue("@NewPrice", price);
                        cmd.Parameters.AddWithValue("@NewClass", cbxClass.SelectedItem);
                        cmd.Parameters.AddWithValue("@NewImage", pbGoods.Tag.ToString());
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("新增成功");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("請輸入完整資料");
                    }
                    break;
                case "detail":
                    if (txtAmount.Text != "" && txtName.Text != "" && txtPrice.Text != "" && cbxClass.SelectedItem != null && pbGoods.Image != null)
                    {
                        con.Open();
                        string strSQL = $"update Goods set GoodsAmount = @NewAmount, GoodsName = @NewName, GoodsPrice = @NewPrice, GoodsImage = @NewImage, GoodsClass = @NewClass where GoodsID = @SearchID;";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@SearchID", GlobalVar.SearchID);
                        Int32.TryParse(txtAmount.Text, out int amount);
                        cmd.Parameters.AddWithValue("@NewAmount", amount);
                        cmd.Parameters.AddWithValue("@NewName", txtName.Text);
                        Int32.TryParse(txtPrice.Text, out int price);
                        cmd.Parameters.AddWithValue("@NewPrice", price);
                        cmd.Parameters.AddWithValue("@NewClass", cbxClass.SelectedItem);
                        cmd.Parameters.AddWithValue("@NewImage", pbGoods.Tag.ToString());
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("修改成功");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("請輸入完整資料");
                    }
                    break;
            }
        }

        private void btnChoosePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "檔案類型(Jpeg, Jpg, Png)|*.jpeg;*.jpg;*.png";

            DialogResult R = ofd.ShowDialog();

            if (R == DialogResult.OK)
            {
                System.IO.FileStream fs = System.IO.File.OpenRead(ofd.FileName);
                pbGoods.Image = Image.FromStream(fs);
                pbGoods.Tag = System.IO.Path.GetFileName(ofd.SafeFileName).ToLower();
                fs.Close();
            }
        }
    }
}
