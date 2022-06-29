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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        RegisterForm RegisterForm = new RegisterForm();
        private void lblKayitOl_Click(object sender, EventArgs e)
        {
            RegisterForm.ShowDialog();
        }
        MainForm mainForm = new MainForm();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Hide();

        }
    }
}
