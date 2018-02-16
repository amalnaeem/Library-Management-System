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
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
        @"Data source= C:\Users\OK\Documents\Library.accdb";

            try
            {
                conn.Open();
                String username = textBox1.Text.ToString();
                String Paswrd = textBox2.Text.ToString();

                String my_querry = "select * from tblMembers where UserName = '" + username + "' and Pasword = '" + Paswrd + "'";


                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                //OleDbDataReader dr = cmd.ExecuteReader();
                var dr = cmd.ExecuteReader();

                if (dr.Read() == true)
                {
                     MessageBox.Show("Login Successful" );

                    // MessageBox.Show(dr[0].ToString());
                     this.Hide();
                    //Form3 f3 = new Form3();
                    //f3.Show();
                    //this.Hide();
                    Form4 f4 = new Form4();
                    f4.Show();

                }
                else
                {
                    MessageBox.Show("Invalid Credentials, Please Re-Enter");
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
