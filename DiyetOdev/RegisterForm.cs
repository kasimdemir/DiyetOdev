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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            rdbtnErkek.Checked=true;
        }


        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            //todo      ...


            this.Close();

        }
    }
}
