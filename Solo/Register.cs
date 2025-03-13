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
    public partial class Register : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MidternPersonalProject";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();
            
            txtName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            dtpBirth.Value = DateTime.Now;
            txtPassword.Text = "";
            txtCheckPassword.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtPhone.Text != "" && txtEmail.Text != "" && dtpBirth.Value != DateTime.Now && txtPassword.Text != "" && txtCheckPassword.Text != "")
            {
                if (txtPassword.Text != txtCheckPassword.Text)
                {
                    MessageBox.Show("密碼輸入不一致");
                    return;
                }
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "Insert into Persons values(@NewName, @NewPhone, @NewEmail, @NewBirthday, 'member', @NewPassword, 0)";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", $"{txtName.Text}");
                cmd.Parameters.AddWithValue("@NewPhone", $"{txtPhone.Text}");
                cmd.Parameters.AddWithValue("@NewEmail", $"{txtEmail.Text}");
                cmd.Parameters.AddWithValue("@NewBirthday", dtpBirth.Value);
                cmd.Parameters.AddWithValue("@NewPassword", $"{txtPassword}");
                cmd.ExecuteNonQuery();
                con.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("資料請輸入完整");
            }
        }
    }
}
