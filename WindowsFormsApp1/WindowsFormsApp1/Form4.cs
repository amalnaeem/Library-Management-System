using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {


            string option = comboBox2.Text;

            if (option == "Author")
            {
                label9.Visible = true;
                textBox2.Visible = true;
                label2.Visible = false;
                textBox4.Visible = false;
                label1.Visible = false;
                textBox3.Visible = false;
                button2.Visible = true;
            }

            else if (option == "Title")
            {
                label2.Visible = true;
                textBox4.Visible = true;
                label9.Visible = false;
                textBox2.Visible = false;
                label1.Visible = false;
                textBox3.Visible = false;
                button2.Visible = true;
            }

            else if (option == "Genre")
            {
                label1.Visible = true;
                textBox3.Visible = true;
                label9.Visible = false;
                textBox2.Visible = false;
                label2.Visible = false;
                textBox4.Visible = false;
                button2.Visible = true;
            }


            /* System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
        @"Data source= C:\Users\OK\Documents\Library.accdb";

            conn.Open();
            string selected = (string)comboBox2.SelectedItem;
            if (selected == "Author")
            {
                label1.Visible = false;
                label2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                label9.Visible = true;
                textBox2.Visible = true;
                button2.Visible = true;
               String my_querry = "select * from tblBooks where Author = '" + selected + "' ";


                OleDbCommand cmd1 = new OleDbCommand(my_querry, conn);

                //OleDbDataReader dr = cmd.ExecuteReader();
                var dr1 = cmd1.ExecuteReader();
                if (dr1.Read() == true)
                {
                    listBox5.Visible = true;
                    while (dr1.Read())
                    {
                        listBox5.Items.Add(dr1[1].ToString() + "                                 " + dr1[11].ToString());

                    }
                }
                
               
            }

           else if (selected == "Genre")
            {
                label1.Visible = true;
                label2.Visible = false;
                label9.Visible = false;
                textBox3.Visible = true;
                textBox2.Visible = false;
                textBox4.Visible = false;
                button2.Visible = true;
                String my_querry = "select * from tblBooks where Genre = '" + selected + "' ";


                OleDbCommand cmd1 = new OleDbCommand(my_querry, conn);

                //OleDbDataReader dr = cmd.ExecuteReader();
                var dr1 = cmd1.ExecuteReader();
                if (dr1.Read() == true)
                {
                    listBox5.Visible = true;
                    while (dr1.Read())
                    {
                        listBox5.Items.Add(dr1[1].ToString() + "                                 " + dr1[11].ToString());

                    }
                }
                //else { listBox5.Visible = true; listBox5.Items.Add("Genre not found"); }
               
            }

            else if (selected == "Title")
            {
                label2.Visible = true;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = true;
                label9.Visible = false;
                label1.Visible = false;
                button2.Visible = true;
                String my_querry = "select * from tblBooks where Title = '" + selected + "' ";


                OleDbCommand cmd1 = new OleDbCommand(my_querry, conn);

                //OleDbDataReader dr = cmd.ExecuteReader();
                var dr1 = cmd1.ExecuteReader();
                if (dr1.Read() == true)
                {
                    listBox5.Visible = true;
                    while (dr1.Read())
                    {
                        listBox5.Items.Add(dr1[1].ToString() + "                                 " + dr1[11].ToString());

                    }
                }
               // else { listBox5.Visible = true; listBox5.Items.Add("Book not found"); }

            }*/
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
        @"Data source= C:\Users\OK\Documents\Library.accdb";

            conn.Open();
            string selected = (string)comboBox2.SelectedItem;
            if (selected == "Author")
            {
                listBox5.Visible = true;
                String my_querry = "select * from tblBooks where Author = '" + textBox2.Text + "' ";


                OleDbCommand cmd1 = new OleDbCommand(my_querry, conn);

                //OleDbDataReader dr = cmd.ExecuteReader();
                var dr1 = cmd1.ExecuteReader();
               
                    while (dr1.Read())
                    {
                        MessageBox.Show(dr1[1].ToString());
                        listBox5.Items.Add(dr1[1].ToString() + "                                 " + dr1[11].ToString());
                        
                    }
                
               
            }

           else if (selected == "Genre")
            {
                listBox5.Items.Clear();
                listBox5.Visible = true;
                textBox3.Visible = true;
                
                String my_querry = "select * from tblBooks where Genre = '" + textBox3.Text + "' ";


                OleDbCommand cmd1 = new OleDbCommand(my_querry, conn);

                //OleDbDataReader dr = cmd.ExecuteReader();
                var dr1 = cmd1.ExecuteReader();
                 while (dr1.Read())
                    {
                    MessageBox.Show(dr1[1].ToString());
                    listBox5.Items.Add(dr1[1].ToString() + "                                 " + dr1[11].ToString());

                    }
                
                
            }

            else if (selected == "Title")
            {

                listBox5.Items.Clear();
                listBox5.Items.Add("Title                                     Status");
                OleDbCommand sqlcommand = new OleDbCommand("select * from tblArtifacts where Title = '" + textBox4.Text + "'", conn);
                OleDbDataReader rd = sqlcommand.ExecuteReader(); // Execute the sql command and store the results in a reader object
                listBox5.Visible = true;

                while (rd.Read())
                {
                    listBox5.Items.Add(rd.GetString(1) + "                              " + rd.GetString(11));
                }
                /*listBox5.Items.Clear();
                listBox5.Visible = true;
                String my_querry = "select * from tblBooks where Title = '" + textBox4.Text + "' ";


                OleDbCommand cmd1 = new OleDbCommand(my_querry, conn);

                //OleDbDataReader dr = cmd.ExecuteReader();
                var dr1 = cmd1.ExecuteReader();
                
                    while (dr1.Read())
                    {
                        listBox5.Items.Add(dr1[1].ToString() + "                                 " + dr1[11].ToString());

                    }*/

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
