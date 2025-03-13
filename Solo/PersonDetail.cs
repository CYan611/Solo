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
    public partial class PersonDetail : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string role = "";
        public PersonDetail()
        {
            InitializeComponent();
        }

        private void PersonDetail_Load(object sender, EventArgs e)
        {
            if (GlobalVar.page == "employee")
            {
                lblData.Text = "員工資料";
                lblID.Text = "員工編號";
                lblRole.Visible = true;
                cbxRole.Visible = true;
            }

            scsb.DataSource = @".";
            scsb.InitialCatalog = "MidternPersonalProject";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();
            switch (GlobalVar.selectMode)
            {
                case "add":
                    btnChangeOrAdd.Text = "新增資料";
                    cbxRole.SelectedIndex = 2;
                    break;
                case "detail":
                    btnChangeOrAdd.Text = "修改資料";
                    SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                    con.Open();
                    string strSQL = $"SELECT * FROM Persons where PersonID = @ID;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@ID", GlobalVar.SearchID);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lblPersonID.Text = GlobalVar.SearchID.ToString();
                        txtName.Text = (string)reader["name"];
                        txtPhone.Text = (string)reader["phone"];
                        txtEmail.Text = (string)reader["email"];
                        txtPassword.Text = (string)reader["password"];
                        dtpBirthday.Value = (DateTime)reader["birthday"];
                        cbxRole.SelectedItem = reader["role"];
                    }
                    reader.Close();
                    con.Close();
                    break;
            }
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private void btnChangeOrSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            switch (GlobalVar.selectMode)
            {
                case "add":
                    if (txtName.Text != "" && txtPhone.Text != "" && txtEmail.Text != "" && dtpBirthday.Value.Year < DateTime.Now.Year)
                    {
                        con.Open();
                        role = "member";
                        string strSQL = $"Insert into Persons values(@NewName, @NewPhone, @NewEmail, @NewBirthday, @NewRole, @NewPassword, 0)";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        if (GlobalVar.permission == "boss")
                        {
                            role = cbxRole.SelectedItem.ToString();
                        }
                        cmd.Parameters.AddWithValue("@NewName", $"{txtName.Text}");
                        cmd.Parameters.AddWithValue("@NewPhone", $"{txtPhone.Text}");
                        cmd.Parameters.AddWithValue("@NewEmail", $"{txtEmail.Text}");
                        cmd.Parameters.AddWithValue("@NewBirthday", dtpBirthday.Value);
                        cmd.Parameters.AddWithValue("@NewRole", $"{role}");
                        cmd.Parameters.AddWithValue("@NewPassword", $"{txtPassword}");
                        cmd.ExecuteNonQuery();
                        con.Close();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("請輸入完整資料");
                    }
                    break;
                case "detail":
                    if (txtName.Text != "" && txtPhone.Text != "" && txtEmail.Text != "" && dtpBirthday.Value.Year < DateTime.Now.Year)
                    {
                        con.Open();
                        if (GlobalVar.permission == "boss")
                        {
                            role = cbxRole.SelectedItem.ToString();
                        }
                        string strSQL = $"update Persons set name = @NewName, phone = @NewPhone, email = @NewEmail, birthday = @NewBirthday, password = @NewPasword, role = {role}  where PersonID = @SearchID";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@SearchID", GlobalVar.userID);
                        cmd.Parameters.AddWithValue("@NewName", txtName.Text);
                        cmd.Parameters.AddWithValue("@NewPhone", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@NewEmail", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@NewBirthday", dtpBirthday.Value);
                        cmd.Parameters.AddWithValue("@NewPasword", txtPassword.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("修改成功");
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("請輸入完整資料");
                    }
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
