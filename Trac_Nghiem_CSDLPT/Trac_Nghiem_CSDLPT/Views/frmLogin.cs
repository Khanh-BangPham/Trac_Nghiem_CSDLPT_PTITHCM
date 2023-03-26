using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trac_Nghiem_CSDLPT.Views
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_SV_Click(object sender, EventArgs e)
        {
            if (pnl_SV.Visible == false)
            {
                pnl_GV.Visible = false;
                pnl_SV.Visible = true;
            }
        }

        private void btn_GV_Click(object sender, EventArgs e)
        {
            if(pnl_GV.Visible == false)
            {
                pnl_SV.Visible = false;
                pnl_GV.Visible = true;   
            }
        }

        private void cmb_Brand_GV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Login_GV_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}