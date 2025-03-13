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
    public partial class UCMemberCenter : UserControl
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        
        private MainMenu menu;
        public UCMemberCenter(MainMenu form)
        {
            InitializeComponent();
            menu = form;
        }

        private void UCMemberCenter_Load(object sender, EventArgs e)
        {
            lblChangeData_Click(sender, e);
        }

        private void btnChangeData_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtPhone.Text != "" && txtEmail.Text != "" && dtpBirthday.Value.Year < DateTime.Now.Year) {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = $"update Persons set name = @NewName, phone = @NewPhone, email = @NewEmail, birthday = @NewBirthday where PersonID = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", GlobalVar.userID);
                cmd.Parameters.AddWithValue("@NewName", txtName.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@NewBirthday", dtpBirthday.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("修改成功");
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入完整資料");
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            
            if (txtOldPassword.Text == txtOldPassword.Tag.ToString() && txtNewPassword.Text == txtCheckPassword.Text) 
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = $"update Persons set password = @NewPassword where PersonID = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", GlobalVar.userID);
                cmd.Parameters.AddWithValue("@NewPassword", txtNewPassword.Text);
                cmd.ExecuteNonQuery();
                txtCheckPassword.Clear();
                txtOldPassword.Clear();
                txtNewPassword.Clear();
                MessageBox.Show("修改成功");
                con.Close();
            }
            else
            {
                MessageBox.Show("請確認密碼");
            }
        }

        private void lblChangeData_Click(object sender, EventArgs e)
        {
            if (GlobalVar.userID > 0) // 確保 GlobalVar.userID 已正確設置
            {
                using (SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString))
                {
                    con.Open();
                    string strSQL = "select * from Persons where PersonID = @SearchID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", GlobalVar.userID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // 確保查詢結果不為空
                        {
                            // 讀取資料
                            txtID.Text = GlobalVar.userID.ToString();
                            txtID.Enabled = false;
                            txtName.Text = reader["name"] != DBNull.Value ? (string)reader["name"] : "";
                            txtPhone.Text = reader["phone"] != DBNull.Value ? (string)reader["phone"] : "";
                            txtEmail.Text = reader["email"] != DBNull.Value ? (string)reader["email"] : "";
                            dtpBirthday.Value = reader["birthday"] != DBNull.Value ? (DateTime)reader["birthday"] : DateTime.Today;
                            txtOldPassword.Tag = reader["password"] != DBNull.Value ? (string)reader["password"] : "";
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("尚未設置有效的使用者ID");
            }
            dgvUsingHistory.Visible = false;
        }

        private void lblHistory_Click(object sender, EventArgs e)
        {
            dgvUsingHistory.Visible = true;
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select PersonID as 會員編號, date as 日期, usingTime as 花費時間, total as 總花費, SeatID as 桌號 from History;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            int dgvRows = 0;
            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvRows = dt.Rows.Count;
                dgvUsingHistory.DataSource = dt;

                MessageBox.Show($"共{dgvRows}筆資料");
            }
            else
            {
                MessageBox.Show("查無資料");
                dgvUsingHistory.Visible = false;
            }
            reader.Close();
            con.Close();
        }
        private void lblReturnHome_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            UCMenu uCMenu = new UCMenu();
            menu.sCBig.Panel2.Controls.Add(uCMenu);
        }

        private void lblDiscount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("暫無優惠");
        }
    }
}
