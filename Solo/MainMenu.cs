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
    public partial class MainMenu : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        public MainMenu()
        {
            InitializeComponent();
        }

        private void mainmenu_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MidternPersonalProject";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();

            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = $"update Seat set usage = 1 where SeatID = @ID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@ID",GlobalVar.tableID);
            cmd.ExecuteNonQuery();
            con.Close();

            timer1.Start();
            GlobalVar.StartTime = DateTime.Now;
            GlobalVar.TimePass = DateTime.Now - GlobalVar.StartTime;
            sCBig.Panel2.Controls.Clear();
            UCMenu Menu = new UCMenu();
            UCManage Manage = new UCManage();
            switch (GlobalVar.permission)
            {
                case "boss":
                    lblLauncher.Visible = false;
                    lblUserName.Visible = false;
                    lblTime.Text = $"現在時間 {DateTime.Now.ToString("HH:mm")}";
                    sCBig.Panel2.Controls.Add(Manage);
                    btnSwitchRole.Visible = true;
                    break;
                case "employee":
                    lblUserName.Text = $"員工登入\n編號 {GlobalVar.userID}";
                    lblLauncher.Visible = false;
                    sCBig.Panel2.Controls.Add(Manage);
                    lblTime.Text = $"現在時間 {DateTime.Now.ToString("HH:mm")}";
                    break;
                case "member":
                    lblTime.Text = $"使用時間: {GlobalVar.TimePass:hh\\:mm}";
                    lblUserName.Text = $"{GlobalVar.userID} 會員\n{GlobalVar.tableID} 桌";
                    sCBig.Panel2.Controls.Add(Menu);
                    break;
                case "guest":
                    lblTime.Text = $"使用時間: {GlobalVar.TimePass:hh\\:mm}";
                    lblUserName.Text = $"訪客登入\n{GlobalVar.tableID} 桌";
                    lblLauncher.Visible = false;
                    sCBig.Panel2.Controls.Add(Menu);
                    break;
            }
        }

        private void btnMemberCenter_Click(object sender, EventArgs e)
        {
            if (GlobalVar.permission == "guest")
            {
                Register userRegister = new Register();
                LogIn logIn = new LogIn();
                userRegister.FormClosed += (s, args) => logIn.Show();
                
                userRegister.ShowDialog();
            }
            else
            {
                pnMemberMenu.Visible = false;
                sCBig.Panel2.Controls.Clear();
                UCMemberCenter MemberCenter = new UCMemberCenter(this);
                sCBig.Panel2.Controls.Add(MemberCenter);
            }
        }

        private void lblLauncher_Click(object sender, EventArgs e)
        {
            pnMemberMenu.Visible = !pnMemberMenu.Visible; ;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            GlobalVar.TimePass = DateTime.Now - GlobalVar.StartTime;
            switch (GlobalVar.permission)
            {
                case "boss":
                    lblTime.Text = $"現在時間 {DateTime.Now:HH:mm}";
                    break;
                case "employee":
                    lblUserName.Text = $"員工登入\n編號 {GlobalVar.userID}";
                    lblTime.Text = $"現在時間 {DateTime.Now:HH:mm}";
                    break;
                case "member":
                    lblTime.Text = $"使用時間: {GlobalVar.TimePass:hh\\:mm}";
                    lblUserName.Text = $"{GlobalVar.userID} 會員\n{GlobalVar.tableID} 桌";
                    break;
                case "guest":
                    lblTime.Text = $"使用時間: {GlobalVar.TimePass:hh\\:mm}";
                    lblUserName.Text = $"訪客登入\n{GlobalVar.tableID} 桌";
                    break;
            }
        }

        private void btnSwitchRole_Click(object sender, EventArgs e)
        {
            switch (GlobalVar.permission)
            {
                case "boss":
                    GlobalVar.permission = "employee";
                    break;
                case "employee":
                    GlobalVar.permission = "boss";
                    break;
            }
            mainmenu_Load(sender ,e);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
