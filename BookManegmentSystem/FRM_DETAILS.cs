using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManegmentSystem
{
    public partial class FRM_DETAILS : Form
    {
        public FRM_DETAILS()
        {
            InitializeComponent();
        }

        private void FRM_DETAILS_Load(object sender, EventArgs e)
        {

        }

        private void txt_name_OnValueChanged(object sender, EventArgs e)
        {

        }
   
        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            FRM_DETAILS frm_det = new FRM_DETAILS();
            frm_det.txt_name.Text = "";
            frm_det.TXT_AUTHOR.Text = "";
            frm_det.TXT_PRICE.Text = "";
            frm_det.CAT.Text = "";
   
            frm_det.RATE.Value = 0;
            this.Close();
        }

        private void CAT_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void TXT_AUTHOR_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void TXT_PRICE_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
