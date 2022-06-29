using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiyetOdev
{
    public partial class Information : Form
    {
        LoginForm loginForm = new LoginForm();
        public Information()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {loginForm.Show();
            this.Hide();
           

        }

        private void Information_FormClosing(object sender, FormClosingEventArgs e)
        {
            

        }
    }
}
