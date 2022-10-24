using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BookManegmentSystem
{
    public partial class FRM_CAT : Form
    {
        // var for sql con
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public FRM_CAT()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(TXT_CAT.Text!="")
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Abdelrahman samir\3rd year\C#\BookManegmentSystem\BookManegmentSystem\DBBOOK.mdf;Integrated Security=True");
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO TBCAT (CAT) VALUES (@CAT)";
                cmd.Parameters.AddWithValue("@CAT", TXT_CAT.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                Form frm_add = new FRM_DIADD();
                frm_add.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Enter the category's name first.");
            }
        }
    }
}
