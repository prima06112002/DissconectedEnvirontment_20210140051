using Act6_Disconnected_Environment;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dissconected_environtment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataProdiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDataProdi fm = new FormDataProdi();
            fm.Show();
            this.Hide();
        }


        private void dataMahasiswaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            mahasiswa fo = new mahasiswa();
            fo.Show();
            this.Hide();
        }

        private void dataStatusMahasiswaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormDataStatusMahasiswa fr = new FormDataStatusMahasiswa();
            fr.Show();
            this.Hide();
        }
    }
}
