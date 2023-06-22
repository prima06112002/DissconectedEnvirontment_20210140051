using Dissconected_environtment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disconnected_Environment
{
    public partial class FormDataProdi : Form
    {
        private string stringConnection = "Data Source=DESKTOP-794RG4I\\PRIMA06;" + "database=Act6;User ID=sa;Password=06112002";
        private SqlConnection koneksi;

        private void refreshform()
        {
            nn.Text = "";
            nn.Enabled = true;
            nmp.Text = "";
            nmp.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }
        public FormDataProdi()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void FormDataProdi_Load(object sender, EventArgs e)
        {

        }

    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick()
        {
            koneksi.Open();
            string query = "SELECT id_prodi, nama_prodi FROM dbo.Prodi";
            SqlDataAdapter da = new SqlDataAdapter(query, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            string nmProdi = nn.Text;
            string nmMahasiswa = nmp.Text;

            if (nmProdi == "" || nmMahasiswa == "")
            {
                MessageBox.Show("Masukkan Keduanya", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                koneksi.Open();
                string insertQuery = "INSERT INTO dbo.prodi (nama_prodi) VALUES (@nama_prodi);";
                SqlCommand insertCommand = new SqlCommand(insertQuery, koneksi);
                insertCommand.CommandType = CommandType.Text;
                insertCommand.Parameters.Add(new SqlParameter("nama_prodi", nmMahasiswa));



                string str = "insert into dbo.prodi (id_prodi) VALUES (@id_prodi)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("id_prodi", nmProdi));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1_CellContentClick();
                refreshform();
            }


        }

     

        private void FormDataProdi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 hu = new Form1();
            hu.Show();
            this.Hide();
        }

        private void nn_TextChanged(object sender, EventArgs e)
        {

        }

        private void nmp_TextChanged(object sender, EventArgs e)
        {

        }

    

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnOpen_Click_1(object sender, EventArgs e)
        {
            dataGridView1_CellContentClick();
            btnOpen.Enabled = true;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string nmProdi = nn.Text;
            string idProdi = nmp.Text;

            if (nmProdi == "")
            {
                MessageBox.Show("Masukkan Nama Prodi", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string query = "INSERT INTO dbo.prodi (id_prodi, nama_prodi) VALUES (@id_prodi, @nama_prodi)";
                SqlCommand cmd = new SqlCommand(query, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id_prodi", idProdi);
                cmd.Parameters.AddWithValue("@nama_prodi", nmProdi);
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1_CellContentClick();
                refreshform();

            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            nmp.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            nmp.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}