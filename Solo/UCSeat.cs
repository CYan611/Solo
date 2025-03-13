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
    public partial class UCSeat : UserControl
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        public UCSeat()
        {
            InitializeComponent();
        }

        private void UCSeat_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @".";
            scsb.InitialCatalog = "MidternPersonalProject";
            scsb.IntegratedSecurity = true;
            GlobalVar.strDBConnectionString = scsb.ConnectionString.ToString();

            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "SELECT SeatID, usage FROM Seat where SeatID = @ID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@ID", btnSeat.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int seatID = (int)reader["SeatID"];
                var usageValue = reader["usage"];
                bool? usage = usageValue == DBNull.Value ? null : (bool?)usageValue;
                switch (usage)
                {
                    case null:
                        btnSeat.BackColor = Color.Red;
                        break;
                    case true:
                        btnSeat.BackColor = Color.LightGreen;
                        break;
                    case false:
                        btnSeat.BackColor = Color.Gray;
                        break;
                }
            }
            reader.Close();
            con.Close();
        }

        private void UpdateSeatUsage(int seatID, bool? usage)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strDBConnectionString);
            con.Open();
            string strSQL = "UPDATE Seat SET usage = @usage WHERE SeatID = @seatID;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@usage", (object)usage ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@seatID", seatID);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnSeat_Click(object sender, EventArgs e)
        {
            Int32.TryParse(btnSeat.Text, out int ID);
            if (btnSeat.BackColor == Color.Red)
            {
                btnSeat.BackColor = Color.Gray;
                UpdateSeatUsage(ID, false);
            }
            else
            {
                btnSeat.BackColor = Color.Red;
                UpdateSeatUsage(ID, null);
            }
        }
    }
}
