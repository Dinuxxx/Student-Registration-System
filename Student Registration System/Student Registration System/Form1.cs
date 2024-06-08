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
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.user_DBConnectionString);
        SqlDataAdapter da;
        SqlCommand cmd;
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM Users WHERE Username='"+textBox1.Text+"' and Password='"+textBox2.Text+"'", con);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i == 1)
            {
                register r = new register();
                r.Show();
                this.Hide();
   
            }
            
            else
            {
               MessageBox.Show("Invalid Login credentials, please check Username and Password and try again", "Invalid login details", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            con.Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure,Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();     
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
    }
}
