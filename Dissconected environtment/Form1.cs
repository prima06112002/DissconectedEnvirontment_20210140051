using Disconnected_Environment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dissconected_environtment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataStatusMahasiswaToolStrpMenuItem_Click(object sender, EventArgs e)
        {
            FormDataStatusMahasiswa fr = new FormDataStatusMahasiswa();
            fr.Show();
            this.Hide();
        }

        private void dataMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMahasiswa fo = new FormMahasiswa();
            fo.Show();
            this.Hide();
        }

        private void dataProdiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDataProdi fm = new FormDataProdi();
            fm.Show();
            this.Hide();
        }
    }
}
