namespace kasir_ukk
{
    partial class Registrasi
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
            lblNama = new Label();
            txtbNama = new TextBox();
            txtbAlamat = new TextBox();
            lblAlamat = new Label();
            txtbNomorTelepon = new TextBox();
            lblNomorTelepon = new Label();
            dgvPelanggan = new DataGridView();
            clmId = new DataGridViewTextBoxColumn();
            clmNama = new DataGridViewTextBoxColumn();
            clmAlamat = new DataGridViewTextBoxColumn();
            clmNoTelepon = new DataGridViewTextBoxColumn();
            btnTambah = new Button();
            btnEdit = new Button();
            btnHapus = new Button();
            lblHeader = new Label();
            btnKembali = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPelanggan).BeginInit();
            SuspendLayout();
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(33, 73);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(59, 25);
            lblNama.TabIndex = 0;
            lblNama.Text = "Nama";
            // 
            // txtbNama
            // 
            txtbNama.BorderStyle = BorderStyle.FixedSingle;
            txtbNama.Location = new Point(33, 101);
            txtbNama.MaxLength = 255;
            txtbNama.Name = "txtbNama";
            txtbNama.Size = new Size(197, 31);
            txtbNama.TabIndex = 1;
            txtbNama.TextChanged += txtbNama_TextChanged;
            // 
            // txtbAlamat
            // 
            txtbAlamat.BorderStyle = BorderStyle.FixedSingle;
            txtbAlamat.Location = new Point(286, 101);
            txtbAlamat.MaxLength = 255;
            txtbAlamat.Name = "txtbAlamat";
            txtbAlamat.Size = new Size(197, 31);
            txtbAlamat.TabIndex = 3;
            // 
            // lblAlamat
            // 
            lblAlamat.AutoSize = true;
            lblAlamat.Location = new Point(286, 73);
            lblAlamat.Name = "lblAlamat";
            lblAlamat.Size = new Size(68, 25);
            lblAlamat.TabIndex = 2;
            lblAlamat.Text = "Alamat";
            // 
            // txtbNomorTelepon
            // 
            txtbNomorTelepon.BorderStyle = BorderStyle.FixedSingle;
            txtbNomorTelepon.Location = new Point(33, 180);
            txtbNomorTelepon.MaxLength = 15;
            txtbNomorTelepon.Name = "txtbNomorTelepon";
            txtbNomorTelepon.Size = new Size(197, 31);
            txtbNomorTelepon.TabIndex = 5;
            // 
            // lblNomorTelepon
            // 
            lblNomorTelepon.AutoSize = true;
            lblNomorTelepon.Location = new Point(33, 152);
            lblNomorTelepon.Name = "lblNomorTelepon";
            lblNomorTelepon.Size = new Size(102, 25);
            lblNomorTelepon.TabIndex = 4;
            lblNomorTelepon.Text = "No Telepon";
            // 
            // dgvPelanggan
            // 
            dgvPelanggan.AllowUserToAddRows = false;
            dgvPelanggan.AllowUserToDeleteRows = false;
            dgvPelanggan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPelanggan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPelanggan.Columns.AddRange(new DataGridViewColumn[] { clmId, clmNama, clmAlamat, clmNoTelepon });
            dgvPelanggan.Location = new Point(33, 260);
            dgvPelanggan.Name = "dgvPelanggan";
            dgvPelanggan.ReadOnly = true;
            dgvPelanggan.RowHeadersWidth = 62;
            dgvPelanggan.RowTemplate.Height = 33;
            dgvPelanggan.Size = new Size(742, 225);
            dgvPelanggan.TabIndex = 6;
            dgvPelanggan.CellClick += dgvPelanggan_CellClick;
            dgvPelanggan.CellContentClick += dgvPelanggan_CellContentClick;
            // 
            // clmId
            // 
            clmId.DataPropertyName = "id";
            clmId.HeaderText = "ID";
            clmId.MinimumWidth = 8;
            clmId.Name = "clmId";
            clmId.ReadOnly = true;
            // 
            // clmNama
            // 
            clmNama.DataPropertyName = "nama";
            clmNama.HeaderText = "Nama";
            clmNama.MinimumWidth = 8;
            clmNama.Name = "clmNama";
            clmNama.ReadOnly = true;
            // 
            // clmAlamat
            // 
            clmAlamat.DataPropertyName = "alamat";
            clmAlamat.HeaderText = "Alamat";
            clmAlamat.MinimumWidth = 8;
            clmAlamat.Name = "clmAlamat";
            clmAlamat.ReadOnly = true;
            // 
            // clmNoTelepon
            // 
            clmNoTelepon.DataPropertyName = "nomor_telepon";
            clmNoTelepon.HeaderText = "No Telepon";
            clmNoTelepon.MinimumWidth = 8;
            clmNoTelepon.Name = "clmNoTelepon";
            clmNoTelepon.ReadOnly = true;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(663, 98);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(112, 34);
            btnTambah.TabIndex = 7;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(663, 138);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(663, 178);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(112, 34);
            btnHapus.TabIndex = 9;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(308, 15);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(143, 38);
            lblHeader.TabIndex = 48;
            lblHeader.Text = "Registrasi";
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(33, 17);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(112, 34);
            btnKembali.TabIndex = 47;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // Registrasi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 503);
            Controls.Add(lblHeader);
            Controls.Add(btnKembali);
            Controls.Add(btnHapus);
            Controls.Add(btnEdit);
            Controls.Add(btnTambah);
            Controls.Add(dgvPelanggan);
            Controls.Add(txtbNomorTelepon);
            Controls.Add(lblNomorTelepon);
            Controls.Add(txtbAlamat);
            Controls.Add(lblAlamat);
            Controls.Add(txtbNama);
            Controls.Add(lblNama);
            Name = "Registrasi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrasi";
            Activated += Registrasi_Activated;
            FormClosed += Registrasi_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dgvPelanggan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNama;
        private TextBox txtbNama;
        private TextBox txtbAlamat;
        private Label lblAlamat;
        private TextBox txtbNomorTelepon;
        private Label lblNomorTelepon;
        private DataGridView dgvPelanggan;
        private Button btnTambah;
        private Button btnEdit;
        private Button btnHapus;
        private DataGridViewTextBoxColumn clmId;
        private DataGridViewTextBoxColumn clmNama;
        private DataGridViewTextBoxColumn clmAlamat;
        private DataGridViewTextBoxColumn clmNoTelepon;
        private Label lblHeader;
        private Button btnKembali;
    }
}