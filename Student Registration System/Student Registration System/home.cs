using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project__ESOFT
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            register r = new register();
            r.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure,Do you really want to Exit...?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
