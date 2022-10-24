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
using System.IO;
namespace BookManegmentSystem
{
    public partial class FRM_ADD : Form
    {
        // var con sql
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        List<string> List = new List<string>();
        public int state;
        public FRM_ADD()
        {
            InitializeComponent();

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(txt_name.Text==""||TXT_AUTHOR.Text==""||TXT_PRICE.Text==""||CAT.Text=="")
            {
                MessageBox.Show("Finish book's information first !");
            }
            else
            {
                if(state==0)
                {
                    // insert
                    // var convert img to binary
                    MemoryStream ma = new MemoryStream();
                    Cover.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    var _cover = ma.ToArray();
                    // sql command
                    con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Abdelrahman samir\3rd year\C#\BookManegmentSystem\BookManegmentSystem\DBBOOK.mdf;Integrated Security=True");
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO BOOKS (TITLE,ATHOUR,PRICE,CAT,DATE,RATE,COVER) VALUES (@TITLE,@ATHOUR,@PRICE,@CAT,@DATE,@RATE,@COVER)";
                    cmd.Parameters.AddWithValue("@TITLE", txt_name.Text);
                    cmd.Parameters.AddWithValue("@ATHOUR", TXT_AUTHOR.Text);
                    cmd.Parameters.AddWithValue("@PRICE",Convert.ToInt16(TXT_PRICE.Text));
                    cmd.Parameters.AddWithValue("@CAT", CAT.Text);
                    cmd.Parameters.AddWithValue("@DATE", Convert.ToDateTime(DATE.Value));
                    cmd.Parameters.AddWithValue("@RATE", Convert.ToInt16(RATE.Value));
                    cmd.Parameters.AddWithValue("@COVER", _cover);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Form frm_add = new FRM_DIADD();
                    frm_add.Show();
                    this.Close();
                }
                else
                {
                    //edit
                    // var convert img to binary
                    MemoryStream ma = new MemoryStream();
                    Cover.Image.Save(ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                    var _cover = ma.ToArray();
                    // sql command
                    con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Abdelrahman samir\3rd year\C#\BookManegmentSystem\BookManegmentSystem\DBBOOK.mdf;Integrated Security=True");
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "UPDATE BOOKS SET TITLE=@TITLE,ATHOUR=@ATHOUR,PRICE=@PRICE,CAT=@CAT,DATE=@DATE,RATE=@RATE,COVER=@COVER WHERE ID=@ID";
                    cmd.Parameters.AddWithValue("@TITLE", txt_name.Text);
                    cmd.Parameters.AddWithValue("@ATHOUR", TXT_AUTHOR.Text);
                    cmd.Parameters.AddWithValue("@PRICE", Convert.ToInt16(TXT_PRICE.Text));
                    cmd.Parameters.AddWithValue("@CAT", CAT.Text);
                    cmd.Parameters.AddWithValue("@DATE",Convert.ToDateTime( DATE.Value));
                    cmd.Parameters.AddWithValue("@RATE", Convert.ToInt16(RATE.Value));
                    cmd.Parameters.AddWithValue("@COVER", _cover);
                    cmd.Parameters.AddWithValue("@ID", state);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Form frm_edit = new FRM_EDIT();
                    frm_edit.Show();
                    this.Close();
                }
                cmd.Parameters.Clear();
            }
            
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm_CAT = new FRM_CAT();
            bunifuTransition1.ShowSync(frm_CAT);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FRM_ADD_Load(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Abdelrahman samir\3rd year\C#\BookManegmentSystem\BookManegmentSystem\DBBOOK.mdf;Integrated Security=True");
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "SELECT CAT FROM TBCAT";
                var rd = cmd.ExecuteReader();
               
                while (rd.Read())
                {
                    List.Add(Convert.ToString(rd[0]));
                }
                List<string> unq = List.Distinct().ToList();
                int i = 0;
                while (i < unq.LongCount())
                {
                    CAT.Items.Add(unq[i]);
                    i = i + 1;
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void FRM_ADD_Activated(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var dia = new OpenFileDialog();
            var result = dia.ShowDialog();
            if(result==DialogResult.OK)
            {
                Cover.Image = Image.FromFile(dia.FileName);
            }
        }

        private void TXT_PRICE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar<'0'||e.KeyChar>'9')
            {
                e.Handled = true;
            }
          
        }

        private void TXT_PRICE_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void CAT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TXT_AUTHOR_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void TXT_AUTHOR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 'a' || e.KeyChar > 'z')
            {
                e.Handled = true;
            }
        }
    }
}
