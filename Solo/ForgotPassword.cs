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
    public partial class ForgotPassword : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            pnCheckInfo.Visible = true;
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MidternPersonalProject";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfimInfo_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "SELECT * FROM Persons where PersonID = @SearchID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            Int32.TryParse(txtMemberID.Text, out int id);
            cmd.Parameters.AddWithValue("@SearchID", id);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                if (txtName.Text.Trim() == (string)reader["name"] && txtPhone.Text.Trim() == (string)reader["phone"] && txtEmail.Text.Trim() == (string)reader["email"] && dtpBirth.Value.Date.ToString("yyyy-MM-dd") == ((DateTime)reader["birthday"]).ToString("yyyy-MM-dd"))
                {
                    pnCheckInfo.Visible = false;
                    MessageBox.Show("資料確認，請輸入新密碼");
                }
                else
                {
                    MessageBox.Show("資料錯誤");
                }

                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("查無此ID，請重新輸入");
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (txtCheckPassword.Text.Trim() == txtNewPassword.Text.Trim()) 
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "update Persons set password = @NewPassword where PersonID = @SearchID";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", Int32.TryParse(txtMemberID.Text, out int id));
                cmd.Parameters.AddWithValue("@NewPassword", txtCheckPassword.Text.Trim());
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("資料修改成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("請確認密碼");
            }
        }
    }
}
