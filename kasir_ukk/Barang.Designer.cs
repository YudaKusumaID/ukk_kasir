namespace kasir_ukk
{
    partial class Barang
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
            dgvBarang = new DataGridView();
            clmId = new DataGridViewTextBoxColumn();
            clmNama = new DataGridViewTextBoxColumn();
            clmHarga = new DataGridViewTextBoxColumn();
            clmStok = new DataGridViewTextBoxColumn();
            lblStok = new Label();
            lblHarga = new Label();
            txtbNama = new TextBox();
            lblNama = new Label();
            btnHapus = new Button();
            btnEdit = new Button();
            btnTambah = new Button();
            txtbStok = new TextBox();
            txtbHarga = new TextBox();
            btnKembali = new Button();
            lblHeader = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBarang).BeginInit();
            SuspendLayout();
            // 
            // dgvBarang
            // 
            dgvBarang.AllowUserToAddRows = false;
            dgvBarang.AllowUserToDeleteRows = false;
            dgvBarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBarang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgvBarang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBarang.Columns.AddRange(new DataGridViewColumn[] { clmId, clmNama, clmHarga, clmStok });
            dgvBarang.Location = new Point(29, 280);
            dgvBarang.Name = "dgvBarang";
            dgvBarang.ReadOnly = true;
            dgvBarang.RowHeadersWidth = 62;
            dgvBarang.RowTemplate.Height = 33;
            dgvBarang.Size = new Size(741, 225);
            dgvBarang.TabIndex = 16;
            dgvBarang.CellClick += dgvBarang_CellClick;
            dgvBarang.Click += dgvBarang_Click;
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
            // clmHarga
            // 
            clmHarga.DataPropertyName = "harga";
            clmHarga.HeaderText = "Harga";
            clmHarga.MinimumWidth = 8;
            clmHarga.Name = "clmHarga";
            clmHarga.ReadOnly = true;
            // 
            // clmStok
            // 
            clmStok.DataPropertyName = "stok";
            clmStok.HeaderText = "Stok";
            clmStok.MinimumWidth = 8;
            clmStok.Name = "clmStok";
            clmStok.ReadOnly = true;
            // 
            // lblStok
            // 
            lblStok.AutoSize = true;
            lblStok.Location = new Point(29, 171);
            lblStok.Name = "lblStok";
            lblStok.Size = new Size(47, 25);
            lblStok.TabIndex = 14;
            lblStok.Text = "Stok";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Location = new Point(281, 91);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(60, 25);
            lblHarga.TabIndex = 12;
            lblHarga.Text = "Harga";
            // 
            // txtbNama
            // 
            txtbNama.BorderStyle = BorderStyle.FixedSingle;
            txtbNama.Location = new Point(29, 120);
            txtbNama.MaxLength = 255;
            txtbNama.Name = "txtbNama";
            txtbNama.Size = new Size(196, 31);
            txtbNama.TabIndex = 11;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(29, 91);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(59, 25);
            lblNama.TabIndex = 10;
            lblNama.Text = "Nama";
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(659, 196);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(111, 38);
            btnHapus.TabIndex = 19;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(659, 156);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(111, 40);
            btnEdit.TabIndex = 18;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(659, 116);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(111, 42);
            btnTambah.TabIndex = 17;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // txtbStok
            // 
            txtbStok.BorderStyle = BorderStyle.FixedSingle;
            txtbStok.Location = new Point(29, 196);
            txtbStok.Name = "txtbStok";
            txtbStok.Size = new Size(196, 31);
            txtbStok.TabIndex = 20;
            // 
            // txtbHarga
            // 
            txtbHarga.BorderStyle = BorderStyle.FixedSingle;
            txtbHarga.Location = new Point(281, 120);
            txtbHarga.Name = "txtbHarga";
            txtbHarga.Size = new Size(196, 31);
            txtbHarga.TabIndex = 21;
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(29, 26);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(112, 34);
            btnKembali.TabIndex = 22;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(344, 26);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(110, 38);
            lblHeader.TabIndex = 23;
            lblHeader.Text = "Barang";
            // 
            // Barang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 531);
            Controls.Add(lblHeader);
            Controls.Add(btnKembali);
            Controls.Add(txtbHarga);
            Controls.Add(txtbStok);
            Controls.Add(dgvBarang);
            Controls.Add(lblStok);
            Controls.Add(lblHarga);
            Controls.Add(txtbNama);
            Controls.Add(lblNama);
            Controls.Add(btnHapus);
            Controls.Add(btnEdit);
            Controls.Add(btnTambah);
            Name = "Barang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Barang";
            FormClosed += Barang_FormClosed;
            Load += Barang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBarang).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBarang;
        private Label lblStok;
        private Label lblHarga;
        private TextBox txtbNama;
        private Label lblNama;
        private Button btnHapus;
        private Button btnEdit;
        private Button btnTambah;
        private DataGridViewTextBoxColumn clmId;
        private DataGridViewTextBoxColumn clmNama;
        private DataGridViewTextBoxColumn clmHarga;
        private DataGridViewTextBoxColumn clmStok;
        private TextBox txtbStok;
        private TextBox txtbHarga;
        private Button btnKembali;
        private Label lblHeader;
    }
}