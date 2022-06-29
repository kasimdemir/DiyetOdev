using DiyetOdev.ChildForms;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

   
        OgunEkle ogunEkle = new OgunEkle();
        private void OgunEkle()
        {
            foreach (Form item in this.MdiChildren)
            {
                item.Hide();
            }
            ogunEkle.StartPosition = FormStartPosition.Manual;

           
            ogunEkle.MdiParent = MainForm.ActiveForm;
            ogunEkle.Show();

        }
        GunlukOzetForm gunlukOzetForm = new GunlukOzetForm();
        private void GunlukOzetFormYukle()
        {
            
            foreach (Form item in this.MdiChildren)
            {
                item.Hide();
            }
            
            gunlukOzetForm.StartPosition = FormStartPosition.Manual;
            gunlukOzetForm.MdiParent = MainForm.ActiveForm;
            
            

            gunlukOzetForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            GunlukOzetFormYukle();
        }

        private void vGünlükÖzetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GunlukOzetFormYukle();
        }

        private void tspOgunEkle_Click(object sender, EventArgs e)
        {
            OgunEkle();

        }
    }



}
