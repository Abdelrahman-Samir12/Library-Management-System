﻿using System;
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
    public partial class Form1 : Form
    {
        // var for move form without border
        int move;
        int movx;
        int movy;

        // var for sqlcon
        SqlConnection con = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        List<String> List = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count==0)
            {
                MessageBox.Show("No books were found!");
            }
            else
            {
                FRM_DETAILS frm_det = new FRM_DETAILS();

                bunifuTransition1.ShowSync(frm_det);
                try
                {
                    con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Abdelrahman samir\3rd year\C#\BookManegmentSystem\BookManegmentSystem\DBBOOK.mdf;Integrated Security=True");
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "SELECT TITLE,ATHOUR,PRICE,CAT,DATE,RATE FROM BOOKS WHERE ID=@ID";
                    cmd.Parameters.AddWithValue("@ID", Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                    var rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        List.Add(Convert.ToString(rd[0]));
                        List.Add(Convert.ToString(rd[1]));
                        List.Add(Convert.ToString(rd[2]));
                        List.Add(Convert.ToString(rd[3]));
                        List.Add(Convert.ToString(rd[4]));
                        List.Add(Convert.ToString(rd[5]));
                    }

                    frm_det.txt_name.Text = List[0];
                    frm_det.TXT_AUTHOR.Text = List[1];
                    frm_det.TXT_PRICE.Text = List[2];
                    frm_det.CAT.Text = List[3];
                    frm_det.DATE.Value = Convert.ToDateTime(List[4]);
                    frm_det.RATE.Value = Convert.ToInt16(List[5]);
                    con.Close();
                    // Read image from database
                    con.Open();
                    cmd.CommandText = "SELECT COVER FROM BOOKS WHERE ID=@IDIMAGE";
                    cmd.Parameters.AddWithValue("@IDIMAGE", Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                    byte[] imge = (byte[])cmd.ExecuteScalar();
                    MemoryStream ma = new MemoryStream();
                    ma.Write(imge, 0, imge.Length);
                    frm_det.Cover.Image = Image.FromStream(ma);
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);
                }
                finally
                {
                    con.Close();
                }
                List.Clear();
                cmd.Parameters.Clear();
            }
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count==0)
            {
                MessageBox.Show("No books were found!");
            }
            else
            {
                con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Abdelrahman samir\3rd year\C#\BookManegmentSystem\BookManegmentSystem\DBBOOK.mdf;Integrated Security=True");
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "DELETE FROM BOOKS WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID", dataGridView1.CurrentRow.Cells[0].Value);
                cmd.ExecuteNonQuery();
                con.Close();
                FRM_DEL frmd = new FRM_DEL();
                frmd.Show();
                cmd.Parameters.Clear();
            }
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            FRM_ADD frm_add = new FRM_ADD();
            frm_add.btnadd.ButtonText = "ADD";
            frm_add.state = 0;
            bunifuTransition1.ShowSync(frm_add);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if(WindowState==FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movx = e.X;
            movy = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(move==1)
            {
                this.SetDesktopLocation(MousePosition.X - movx, MousePosition.Y - movy);
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Abdelrahman samir\3rd year\C#\BookManegmentSystem\BookManegmentSystem\DBBOOK.mdf;Integrated Security=True");
            var sql = "SELECT ID ,TITLE,ATHOUR,PRICE,CAT FROM BOOKS";
            da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Title";
            dataGridView1.Columns[2].HeaderText = "Athour";
            dataGridView1.Columns[3].HeaderText = "Price";
            dataGridView1.Columns[4].HeaderText = "Category";

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count==0)
            {
                MessageBox.Show("No books were found!");
            }
            else
            {
                FRM_ADD frm_add = new FRM_ADD();
                frm_add.btnadd.ButtonText = "Edit";
                frm_add.state = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                bunifuTransition1.ShowSync(frm_add);
                try
                {
                    con.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Abdelrahman samir\3rd year\C#\BookManegmentSystem\BookManegmentSystem\DBBOOK.mdf;Integrated Security=True");
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "SELECT TITLE,ATHOUR,PRICE,CAT,DATE,RATE FROM BOOKS WHERE ID=@ID";
                    cmd.Parameters.AddWithValue("@ID", Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                    var rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        List.Add(Convert.ToString(rd[0]));
                        List.Add(Convert.ToString(rd[1]));
                        List.Add(Convert.ToString(rd[2]));
                        List.Add(Convert.ToString(rd[3]));
                        List.Add(Convert.ToString(rd[4]));
                        List.Add(Convert.ToString(rd[5]));
                    }

                    frm_add.txt_name.Text = List[0];
                    frm_add.TXT_AUTHOR.Text = List[1];
                    frm_add.TXT_PRICE.Text = List[2];
                    frm_add.CAT.Text = List[3];
                    frm_add.DATE.Value = Convert.ToDateTime(List[4]);
                    frm_add.RATE.Value = Convert.ToInt16(List[5]);
                    con.Close();
                    // Read image from database
                    con.Open();
                    cmd.CommandText = "SELECT COVER FROM BOOKS WHERE ID=@IDIMAGE";
                    cmd.Parameters.AddWithValue("@IDIMAGE", Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                    byte[] imge = (byte[])cmd.ExecuteScalar();
                    MemoryStream ma = new MemoryStream();
                    ma.Write(imge, 0, imge.Length);
                    frm_add.Cover.Image = Image.FromStream(ma);
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);
                }
                finally
                {
                    con.Close();
                }
                List.Clear();
                cmd.Parameters.Clear();
            }
           
        }
    }
}
