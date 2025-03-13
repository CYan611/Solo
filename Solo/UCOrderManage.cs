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
    public partial class UCOrderManage : UserControl
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        public UCOrderManage()
        {
            InitializeComponent();
        }

        private void UCOrderManage_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MidternPersonalProject";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();

        }

        private void lblIsDone_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "update Orders set IsDone = @IsDone";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            bool done = false;
            if (lblIsDone.BackColor == Color.Green)
            {
                done = false;
                lblIsDone.BackColor = Color.Red;
            }
            else if (lblIsDone.BackColor == Color.Red)
            {
                done = true;
                lblIsDone.BackColor = Color.Green;
            }
            cmd.Parameters.AddWithValue("@IsDone", done);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
