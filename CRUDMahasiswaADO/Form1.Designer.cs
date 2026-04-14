namespace CRUDMahasiswaADO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNIM = new TextBox();
            label2 = new Label();
            txtNama = new TextBox();
            label4 = new Label();
            cmbJK = new ComboBox();
            label5 = new Label();
            dtpTanggalLahir = new DateTimePicker();
            label3 = new Label();
            txtAlamat = new TextBox();
            label6 = new Label();
            txtKodeProdi = new TextBox();
            btnConnect = new Button();
            btnLoad = new Button();
            dataGridView1 = new DataGridView();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 36);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "NIM";
            // 
            // txtNIM
            // 
            txtNIM.Location = new Point(133, 28);
            txtNIM.Name = "txtNIM";
            txtNIM.Size = new Size(100, 23);
            txtNIM.TabIndex = 1;
            txtNIM.TextChanged += txtNIM_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 73);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Nama";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(133, 73);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(100, 23);
            txtNama.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 122);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 4;
            label4.Text = "Jenis Kelamin";
            // 
            // cmbJK
            // 
            cmbJK.FormattingEnabled = true;
            cmbJK.Location = new Point(133, 122);
            cmbJK.Name = "cmbJK";
            cmbJK.Size = new Size(100, 23);
            cmbJK.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 172);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 6;
            label5.Text = "Tanggal Lahir";
            // 
            // dtpTanggalLahir
            // 
            dtpTanggalLahir.Location = new Point(133, 164);
            dtpTanggalLahir.Name = "dtpTanggalLahir";
            dtpTanggalLahir.Size = new Size(200, 23);
            dtpTanggalLahir.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 212);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 8;
            label3.Text = "Alamat";
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(133, 209);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(200, 23);
            txtAlamat.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 265);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 10;
            label6.Text = "Kode Prodi";
            // 
            // txtKodeProdi
            // 
            txtKodeProdi.Location = new Point(133, 262);
            txtKodeProdi.Name = "txtKodeProdi";
            txtKodeProdi.Size = new Size(100, 23);
            txtKodeProdi.TabIndex = 11;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(429, 32);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(136, 23);
            btnConnect.TabIndex = 12;
            btnConnect.Text = "Membuka Koneksi";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(429, 73);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(136, 23);
            btnLoad.TabIndex = 13;
            btnLoad.Text = "Menampilkan Data";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(133, 382);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(651, 178);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(429, 122);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(136, 23);
            btnInsert.TabIndex = 15;
            btnInsert.Text = "Menambah Data";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(429, 164);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(136, 23);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Mengubah Data";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(429, 209);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(136, 23);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Menghapus Data";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 572);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(dataGridView1);
            Controls.Add(btnLoad);
            Controls.Add(btnConnect);
            Controls.Add(txtKodeProdi);
            Controls.Add(label6);
            Controls.Add(txtAlamat);
            Controls.Add(label3);
            Controls.Add(dtpTanggalLahir);
            Controls.Add(label5);
            Controls.Add(cmbJK);
            Controls.Add(label4);
            Controls.Add(txtNama);
            Controls.Add(label2);
            Controls.Add(txtNIM);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNIM;
        private Label label2;
        private TextBox txtNama;
        private Label label4;
        private ComboBox cmbJK;
        private Label label5;
        private DateTimePicker dtpTanggalLahir;
        private Label label3;
        private TextBox txtAlamat;
        private Label label6;
        private TextBox txtKodeProdi;
        private Button btnConnect;
        private Button btnLoad;
        private DataGridView dataGridView1;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
