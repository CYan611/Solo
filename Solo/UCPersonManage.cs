using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solo
{
    public partial class UCPersonManage : UserControl
    {
        public UCPersonManage()
        {
            InitializeComponent();
        }

        private void UCPersonManage_Load(object sender, EventArgs e)
        {

        }

        private void lblDetail_Click(object sender, EventArgs e)
        {
            Int32.TryParse(lblPersonID.Text, out int id);
            GlobalVar.SearchID = id;
            GlobalVar.selectMode = "detail";
            PersonDetail personDetail = new PersonDetail();
            personDetail.ShowDialog();
        }
    }
}
