namespace Disconnected_Environment
{
    partial class FormDataStatusMahasiswa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNIM = new System.Windows.Forms.Label();
            this.mahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.act6DataSet = new Dissconected_environtment.Act6DataSet();
            this.cbxNama = new System.Windows.Forms.ComboBox();
            this.cbxStatusMahasiswa = new System.Windows.Forms.ComboBox();
            this.cbxTahunMasuk = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.mahasiswaTableAdapter = new Dissconected_environtment.Act6DataSetTableAdapters.mahasiswaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.act6DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(117, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(449, 173);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama Mahasiswa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nomor Induk Mahasiswa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Status Mahasiswa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tahun Masuk";
            // 
            // txtNIM
            // 
            this.txtNIM.AutoSize = true;
            this.txtNIM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "nim", true));
            this.txtNIM.Location = new System.Drawing.Point(341, 267);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(55, 20);
            this.txtNIM.TabIndex = 5;
            this.txtNIM.Text = "txtNIM";
            // 
            // mahasiswaBindingSource
            // 
            this.mahasiswaBindingSource.DataMember = "mahasiswa";
            this.mahasiswaBindingSource.DataSource = this.act6DataSet;
            // 
            // act6DataSet
            // 
            this.act6DataSet.DataSetName = "Act6DataSet";
            this.act6DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxNama
            // 
            this.cbxNama.FormattingEnabled = true;
            this.cbxNama.Location = new System.Drawing.Point(345, 223);
            this.cbxNama.Name = "cbxNama";
            this.cbxNama.Size = new System.Drawing.Size(121, 28);
            this.cbxNama.TabIndex = 6;
            // 
            // cbxStatusMahasiswa
            // 
            this.cbxStatusMahasiswa.FormattingEnabled = true;
            this.cbxStatusMahasiswa.Items.AddRange(new object[] {
            "Aktif",
            "Tidak Aktif"});
            this.cbxStatusMahasiswa.Location = new System.Drawing.Point(345, 300);
            this.cbxStatusMahasiswa.Name = "cbxStatusMahasiswa";
            this.cbxStatusMahasiswa.Size = new System.Drawing.Size(121, 28);
            this.cbxStatusMahasiswa.TabIndex = 7;
            this.cbxStatusMahasiswa.SelectedIndexChanged += new System.EventHandler(this.cbxStatusMahasiswa_SelectedIndexChanged);
            // 
            // cbxTahunMasuk
            // 
            this.cbxTahunMasuk.FormattingEnabled = true;
            this.cbxTahunMasuk.Location = new System.Drawing.Point(345, 352);
            this.cbxTahunMasuk.Name = "cbxTahunMasuk";
            this.cbxTahunMasuk.Size = new System.Drawing.Size(121, 28);
            this.cbxTahunMasuk.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(544, 228);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 36);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(544, 289);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 39);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(544, 346);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 39);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(642, 43);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 37);
            this.btnOpen.TabIndex = 12;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(663, 142);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 41);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // mahasiswaTableAdapter
            // 
            this.mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // FormDataStatusMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxTahunMasuk);
            this.Controls.Add(this.cbxStatusMahasiswa);
            this.Controls.Add(this.cbxNama);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDataStatusMahasiswa";
            this.Text = "data_status_mahasiswa";
            this.Load += new System.EventHandler(this.FormDataStatusMahasiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.act6DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtNIM;
        private System.Windows.Forms.ComboBox cbxNama;
        private System.Windows.Forms.ComboBox cbxStatusMahasiswa;
        private System.Windows.Forms.ComboBox cbxTahunMasuk;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnBack;
        private Dissconected_environtment.Act6DataSet act6DataSet;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource;
        private Dissconected_environtment.Act6DataSetTableAdapters.mahasiswaTableAdapter mahasiswaTableAdapter;
    }
}