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
    public partial class LogIn : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        
        public LogIn()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MidternPersonalProject";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();
            
            txtID.Clear();
            txtPassword.Clear();
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "select* from Seat where usage = 0";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            cboxTable.Items.Clear();
            while (reader.Read())
            {
                cboxTable.Items.Add(reader["SeatID"].ToString());
            }
            reader.Close();
            con.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtPassword.Text != "" )
            {
                SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
                con.Open();
                string strSQL = "select * from Persons where PersonID = @SearchID and password = @SearchPass;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                Int32.TryParse(txtID.Text, out int intID);
                cmd.Parameters.AddWithValue("@SearchID", $"{intID}");
                cmd.Parameters.AddWithValue("@SearchPass", $"{txtPassword.Text.Trim()}");
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    bool IsTable = Int32.TryParse(cboxTable.Text.Trim(), out int userTable);
                    GlobalVar.permission = (string)reader["role"];
                    if (GlobalVar.permission == "member" && (IsTable == false || (userTable > 50 && userTable <1)))
                    {
                        MessageBox.Show("請填桌號");
                        return;
                    }
                    GlobalVar.tableID = userTable;
                    GlobalVar.userID = (int)reader["PersonID"];
                    MainMenu menu = new MainMenu();
                    menu.FormClosed += (s, args) => this.Show();
                    this.Hide();
                    menu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("ID或密碼錯誤\n請確認ID密碼正確");
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入ID密碼");
            }
        }

        private void btnGuestLogin_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(cboxTable.Text.Trim(),out int userTable) && userTable <=50 && userTable >0)
            {
                GlobalVar.userID = 10000000;
                GlobalVar.permission = "guest";
                GlobalVar.tableID = userTable;
                MainMenu menu = new MainMenu();
                menu.FormClosed += (s, args) => this.Show();
                this.Hide();
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("請填桌號");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register userRegister = new Register();
            userRegister.FormClosed += (s, args) => this.Show();
            this.Hide();
            userRegister.ShowDialog();
        }

        private void btnForgot_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.FormClosed += (s, args) => this.Show();
            this.Hide();
            forgotPassword.ShowDialog();
        }
    }
}
