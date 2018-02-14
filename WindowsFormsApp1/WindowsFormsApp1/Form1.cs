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
using System.Data;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
        @"Data source= C:\Users\OK\Documents\Library.accdb";

            try
            {
                conn.Open();
                String username = textBox2.Text.ToString();
                String Paswrd = textBox3.Text.ToString();
                String FirstName = textBox5.Text.ToString();
                String LastName = textBox4.Text.ToString();
                String my_querry = "INSERT INTO tblMembers(UserName,FirstName,LastName,Pasword)VALUES('" + username + "','" + FirstName + "','" + LastName + "','"+Paswrd + "')";

                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Registration Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            // OleDbConnection dbcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data source=C:\\Users\\OK\\Documents\\Library.accdb; Persist Security Info=False;");
            /// dbcon.Open();
            //OleDbCommand sqlcommand = new OleDbCommand("insert into tblMembers (UserName, Password) values('textBox3.Text','textBox2.Text'",dbcon);
            //sqlcommand.ExecuteNonQuery();
            //Run query to add login name and password in the stUser table*/
            //OleDbCommand sqlcommand = new OleDbCommand("insert into tblMembers (UserName, FirstName,LastName,Password) values('" + textBox2.Text + "','"+textBox5.Text+"','"+textBox4.Text+"','"+textBox2.Text+"')", dbcon);

            //OleDbCommand sqlcommand0 = new OleDbCommand("insert into tblMembers (UserName) values('"+textBox2.Text+"')", dbcon);
            //sqlcommand0.ExecuteNonQuery();

            /*OleDbCommand sqlcommand2 = new OleDbCommand("insert into tblMembers (FirstName) values('" + textBox5.Text + "')", dbcon);
            sqlcommand2.ExecuteNonQuery();

            OleDbCommand sqlcommand1 = new OleDbCommand("insert into tblMembers (Password) values('"+textBox3.Text+"')", dbcon);
            sqlcommand1.ExecuteNonQuery();

            

            OleDbCommand sqlcommand3 = new OleDbCommand("insert into tblMembers (LastName) values('" + textBox4.Text + "')", dbcon);
            sqlcommand3.ExecuteNonQuery();*/

            // Redirect to the login page
            //Response.Redirect("Form2.cs");
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
