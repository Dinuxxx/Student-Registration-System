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

namespace Final_Project__ESOFT
{
    public partial class register : Form
    {
        
        public register()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DINU\\MYSQL;Initial Catalog=Student;Integrated Security=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string regNo = comboBox1.Text;
            string firstName = txtfname.Text;
            string lastName = txtlname.Text;
            DateTime dateOfBirth = DateTime.Parse(dateTimePicker1.Text);
            string gender = "";
            if (radioButton1.Checked == true)
                gender = "Male";
            if (radioButton2.Checked == true)
                gender = "Female";
            string address = txtaddress.Text;
            string email = txtemail.Text;
            string mobilePhone = txtmobile.Text;
            string homePhone = txthome.Text;
            string parentName = txtparent.Text;
            string nic = txtpnic.Text;
            string contactNo = txtconno.Text;
           
            try
            {
                if (string.IsNullOrWhiteSpace(txtemail.Text) && string.IsNullOrWhiteSpace(txtfname.Text) && string.IsNullOrWhiteSpace(txtlname.Text))
                {
                    MessageBox.Show("Before you register, You should enter your Firstname, Lastname and Email.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string query_insert = "INSERT INTO [Registration Table] VALUES('"+regNo+"','"+firstName+"','"+lastName+"','"+dateOfBirth+"','"+gender+"','"+address+"','"+email+"','"+mobilePhone+"','"+homePhone+"','"+parentName+"','"+nic+"','"+contactNo+"')";
                    SqlCommand cmnd = new SqlCommand(query_insert, con);
                    con.Open();
                    cmnd.ExecuteNonQuery();
                    MessageBox.Show("Record Added Successfully", "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    home h = new home();
                    h.Show();
                    this.Hide();
                }
            }
            catch (Exception cmnd)
            {
                MessageBox.Show(cmnd.ToString()); 
            }
            finally
            { 
                con.Close();
            }     
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            string regNo = comboBox1.Text;
            string firstName = txtfname.Text;
            string lastName = txtlname.Text;
            DateTime dateOfBirth = DateTime.Parse(dateTimePicker1.Text);
            string gender = "";
            if (radioButton1.Checked == true)
                gender = "Male";
            if (radioButton2.Checked == true)
                gender = "Female";
            string address = txtaddress.Text;
            string email = txtemail.Text;
            string mobilePhone = txtmobile.Text;
            string homePhone = txthome.Text;
            string parentName = txtparent.Text;
            string nic = txtpnic.Text;
            string contactNo = txtconno.Text;

            try
            {
                if (string.IsNullOrWhiteSpace(txtemail.Text) && string.IsNullOrWhiteSpace(txtfname.Text) && string.IsNullOrWhiteSpace(txtlname.Text))
                {
                    MessageBox.Show("Before you Update, You should enter your Firstname, Lastname and Email.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string query_update = "UPDATE [Registration Table] SET regNo='" + regNo + "',firstName='" + firstName + "',lastName='" + lastName + "',dateOfBirth='" + dateOfBirth + "',gender='" + gender + "',address='" + address + "',email='" + email + "',mobilePhone='" + mobilePhone + "',homePhone='" + homePhone + "',parentName='" + parentName + "',nic='" + nic + "',contactNo='" + contactNo + "'WHERE email='" + email + "'";
                    SqlCommand cmnd = new SqlCommand(query_update, con);
                    con.Open();
                    cmnd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    home h = new home();
                    h.Show();
                    this.Hide();
                }
            }
            catch (Exception cmnd)
            {
                MessageBox.Show(cmnd.ToString());
            }
            finally
            {
                con.Close();
            }
  
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string regNo = comboBox1.Text;
            string firstName = txtfname.Text;
            string lastName = txtlname.Text;
            DateTime dateOfBirth = DateTime.Parse(dateTimePicker1.Text);
            string gender = "";
            if (radioButton1.Checked == true)
                gender = "Male";
            if (radioButton2.Checked == true)
                gender = "Female";
            string address = txtaddress.Text;
            string email = txtemail.Text;
            string mobilePhone = txtmobile.Text;
            string homePhone = txthome.Text;
            string parentName = txtparent.Text;
            string nic = txtpnic.Text;
            string contactNo = txtconno.Text;

            try
            {
                if (string.IsNullOrWhiteSpace(txtemail.Text) && string.IsNullOrWhiteSpace(txtfname.Text) && string.IsNullOrWhiteSpace(txtlname.Text))
                {
                    MessageBox.Show("Before you Delete your data, You should enter your Firstname, Lastname and Email.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("Are you sure, Do you really want to delete this Record...?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string query_delete = "DELETE FROM [Registration Table] WHERE email='" + email + "'";
                        SqlCommand cmnd = new SqlCommand(query_delete, con);
                        con.Open();
                        cmnd.ExecuteNonQuery();
                        MessageBox.Show("Record Deleted succesfully", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                
                }
               
                    
            }
            catch (Exception cmnd)
            {
                MessageBox.Show(cmnd.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login x = new login();
            x.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Are you sure,Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtfname.Clear();
            txtlname.Clear();
            txtaddress.Clear();
            txtemail.Clear();
            txtmobile.Clear();
            txthome.Clear();
            txtparent.Clear();
            txtpnic.Clear();
            txtconno.Clear();
            comboBox1.ResetText();
            dateTimePicker1.Value = DateTime.Now;
            if (radioButton1.Checked == true)
            {
                radioButton1.Checked = false;
            }
            else
            {
                radioButton2.Checked = false;
            }
            comboBox1.Focus();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            home h = new home();
            h.Show();
            this.Hide();

        }
        private void register_Load(object sender, EventArgs e)
        {

        }
    }
}
