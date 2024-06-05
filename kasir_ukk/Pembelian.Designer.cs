namespace kasir_ukk
{
    partial class Pembelian
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
            dgvPembelian = new DataGridView();
            clmId = new DataGridViewTextBoxColumn();
            clmNama = new DataGridViewTextBoxColumn();
            clmHarga = new DataGridViewTextBoxColumn();
            clmKuantitas = new DataGridViewTextBoxColumn();
            clmSubTotal = new DataGridViewTextBoxColumn();
            txtbIdBarang = new TextBox();
            txtbNamaBarang = new TextBox();
            lblNamaBarang = new Label();
            lblIdProduk = new Label();
            txtbIdPelanggan = new TextBox();
            lblIdPelanggan = new Label();
            btnReset = new Button();
            btnTambah = new Button();
            txtbHargaSatuan = new TextBox();
            lblHargaSatuan = new Label();
            lblTotal = new Label();
            lblTunai = new Label();
            lblKembalian = new Label();
            txtbTotal = new TextBox();
            txtbTunai = new TextBox();
            txtbKembalian = new TextBox();
            btnSimpan = new Button();
            txtbKuantitas = new TextBox();
            lblKuantitas = new Label();
            txtbSubtotal = new TextBox();
            lblSubtotal = new Label();
            lblHeader = new Label();
            btnKembali = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPembelian).BeginInit();
            SuspendLayout();
            // 
            // dgvPembelian
            // 
            dgvPembelian.AllowUserToAddRows = false;
            dgvPembelian.AllowUserToDeleteRows = false;
            dgvPembelian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPembelian.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgvPembelian.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPembelian.Columns.AddRange(new DataGridViewColumn[] { clmId, clmNama, clmHarga, clmKuantitas, clmSubTotal });
            dgvPembelian.Location = new Point(33, 349);
            dgvPembelian.Name = "dgvPembelian";
            dgvPembelian.ReadOnly = true;
            dgvPembelian.RowHeadersWidth = 62;
            dgvPembelian.RowTemplate.Height = 33;
            dgvPembelian.Size = new Size(741, 225);
            dgvPembelian.TabIndex = 26;
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
            // clmKuantitas
            // 
            clmKuantitas.HeaderText = "Kuantitas";
            clmKuantitas.MinimumWidth = 8;
            clmKuantitas.Name = "clmKuantitas";
            clmKuantitas.ReadOnly = true;
            // 
            // clmSubTotal
            // 
            clmSubTotal.HeaderText = "Subtotal";
            clmSubTotal.MinimumWidth = 8;
            clmSubTotal.Name = "clmSubTotal";
            clmSubTotal.ReadOnly = true;
            // 
            // txtbIdBarang
            // 
            txtbIdBarang.BorderStyle = BorderStyle.FixedSingle;
            txtbIdBarang.Location = new Point(286, 114);
            txtbIdBarang.Name = "txtbIdBarang";
            txtbIdBarang.Size = new Size(196, 31);
            txtbIdBarang.TabIndex = 31;
            txtbIdBarang.TextChanged += txtbIdBarang_TextChanged;
            // 
            // txtbNamaBarang
            // 
            txtbNamaBarang.BorderStyle = BorderStyle.FixedSingle;
            txtbNamaBarang.Location = new Point(33, 191);
            txtbNamaBarang.Name = "txtbNamaBarang";
            txtbNamaBarang.ReadOnly = true;
            txtbNamaBarang.Size = new Size(196, 31);
            txtbNamaBarang.TabIndex = 30;
            // 
            // lblNamaBarang
            // 
            lblNamaBarang.AutoSize = true;
            lblNamaBarang.Location = new Point(30, 162);
            lblNamaBarang.Name = "lblNamaBarang";
            lblNamaBarang.Size = new Size(119, 25);
            lblNamaBarang.TabIndex = 25;
            lblNamaBarang.Text = "Nama Barang";
            // 
            // lblIdProduk
            // 
            lblIdProduk.AutoSize = true;
            lblIdProduk.Location = new Point(286, 86);
            lblIdProduk.Name = "lblIdProduk";
            lblIdProduk.Size = new Size(90, 25);
            lblIdProduk.TabIndex = 24;
            lblIdProduk.Text = "ID Barang";
            // 
            // txtbIdPelanggan
            // 
            txtbIdPelanggan.BorderStyle = BorderStyle.FixedSingle;
            txtbIdPelanggan.Location = new Point(33, 114);
            txtbIdPelanggan.MaxLength = 255;
            txtbIdPelanggan.Name = "txtbIdPelanggan";
            txtbIdPelanggan.Size = new Size(196, 31);
            txtbIdPelanggan.TabIndex = 23;
            // 
            // lblIdPelanggan
            // 
            lblIdPelanggan.AutoSize = true;
            lblIdPelanggan.Location = new Point(33, 86);
            lblIdPelanggan.Name = "lblIdPelanggan";
            lblIdPelanggan.Size = new Size(117, 25);
            lblIdPelanggan.TabIndex = 22;
            lblIdPelanggan.Text = "ID Pelanggan";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(663, 156);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(111, 38);
            btnReset.TabIndex = 29;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(663, 111);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(111, 42);
            btnTambah.TabIndex = 27;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // txtbHargaSatuan
            // 
            txtbHargaSatuan.BorderStyle = BorderStyle.FixedSingle;
            txtbHargaSatuan.Location = new Point(286, 191);
            txtbHargaSatuan.Name = "txtbHargaSatuan";
            txtbHargaSatuan.ReadOnly = true;
            txtbHargaSatuan.Size = new Size(196, 31);
            txtbHargaSatuan.TabIndex = 33;
            // 
            // lblHargaSatuan
            // 
            lblHargaSatuan.AutoSize = true;
            lblHargaSatuan.Location = new Point(283, 162);
            lblHargaSatuan.Name = "lblHargaSatuan";
            lblHargaSatuan.Size = new Size(119, 25);
            lblHargaSatuan.TabIndex = 32;
            lblHargaSatuan.Text = "Harga Satuan";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(30, 630);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(161, 32);
            lblTotal.TabIndex = 34;
            lblTotal.Text = "Total            :";
            // 
            // lblTunai
            // 
            lblTunai.AutoSize = true;
            lblTunai.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTunai.Location = new Point(30, 678);
            lblTunai.Margin = new Padding(4, 0, 4, 0);
            lblTunai.Name = "lblTunai";
            lblTunai.Size = new Size(160, 32);
            lblTunai.TabIndex = 35;
            lblTunai.Text = "Tunai           :";
            // 
            // lblKembalian
            // 
            lblKembalian.AutoSize = true;
            lblKembalian.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblKembalian.Location = new Point(30, 727);
            lblKembalian.Margin = new Padding(4, 0, 4, 0);
            lblKembalian.Name = "lblKembalian";
            lblKembalian.Size = new Size(149, 32);
            lblKembalian.TabIndex = 36;
            lblKembalian.Text = "Kembalian :";
            // 
            // txtbTotal
            // 
            txtbTotal.BorderStyle = BorderStyle.FixedSingle;
            txtbTotal.Location = new Point(183, 628);
            txtbTotal.Margin = new Padding(4, 5, 4, 5);
            txtbTotal.Name = "txtbTotal";
            txtbTotal.ReadOnly = true;
            txtbTotal.Size = new Size(231, 31);
            txtbTotal.TabIndex = 37;
            // 
            // txtbTunai
            // 
            txtbTunai.BorderStyle = BorderStyle.FixedSingle;
            txtbTunai.Location = new Point(183, 677);
            txtbTunai.Margin = new Padding(4, 5, 4, 5);
            txtbTunai.Name = "txtbTunai";
            txtbTunai.Size = new Size(231, 31);
            txtbTunai.TabIndex = 38;
            txtbTunai.TextChanged += txtbTunai_TextChanged;
            // 
            // txtbKembalian
            // 
            txtbKembalian.BorderStyle = BorderStyle.FixedSingle;
            txtbKembalian.Location = new Point(183, 725);
            txtbKembalian.Margin = new Padding(4, 5, 4, 5);
            txtbKembalian.Name = "txtbKembalian";
            txtbKembalian.ReadOnly = true;
            txtbKembalian.Size = new Size(231, 31);
            txtbKembalian.TabIndex = 39;
            // 
            // btnSimpan
            // 
            btnSimpan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSimpan.Location = new Point(597, 678);
            btnSimpan.Margin = new Padding(4, 5, 4, 5);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(177, 85);
            btnSimpan.TabIndex = 40;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // txtbKuantitas
            // 
            txtbKuantitas.BorderStyle = BorderStyle.FixedSingle;
            txtbKuantitas.Location = new Point(33, 269);
            txtbKuantitas.Name = "txtbKuantitas";
            txtbKuantitas.Size = new Size(196, 31);
            txtbKuantitas.TabIndex = 42;
            txtbKuantitas.TextChanged += txtbKuantitas_TextChanged;
            // 
            // lblKuantitas
            // 
            lblKuantitas.AutoSize = true;
            lblKuantitas.Location = new Point(33, 241);
            lblKuantitas.Name = "lblKuantitas";
            lblKuantitas.Size = new Size(84, 25);
            lblKuantitas.TabIndex = 41;
            lblKuantitas.Text = "Kuantitas";
            // 
            // txtbSubtotal
            // 
            txtbSubtotal.BorderStyle = BorderStyle.FixedSingle;
            txtbSubtotal.Location = new Point(286, 269);
            txtbSubtotal.Name = "txtbSubtotal";
            txtbSubtotal.ReadOnly = true;
            txtbSubtotal.Size = new Size(196, 31);
            txtbSubtotal.TabIndex = 44;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(286, 241);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(79, 25);
            lblSubtotal.TabIndex = 43;
            lblSubtotal.Text = "Subtotal";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(308, 24);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(154, 38);
            lblHeader.TabIndex = 46;
            lblHeader.Text = "Pembelian";
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(33, 24);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(112, 34);
            btnKembali.TabIndex = 45;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // Pembelian
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 788);
            Controls.Add(lblHeader);
            Controls.Add(btnKembali);
            Controls.Add(txtbSubtotal);
            Controls.Add(lblSubtotal);
            Controls.Add(txtbKuantitas);
            Controls.Add(lblKuantitas);
            Controls.Add(btnSimpan);
            Controls.Add(txtbKembalian);
            Controls.Add(txtbTunai);
            Controls.Add(txtbTotal);
            Controls.Add(lblKembalian);
            Controls.Add(lblTunai);
            Controls.Add(lblTotal);
            Controls.Add(txtbHargaSatuan);
            Controls.Add(lblHargaSatuan);
            Controls.Add(dgvPembelian);
            Controls.Add(txtbIdBarang);
            Controls.Add(txtbNamaBarang);
            Controls.Add(lblNamaBarang);
            Controls.Add(lblIdProduk);
            Controls.Add(txtbIdPelanggan);
            Controls.Add(lblIdPelanggan);
            Controls.Add(btnReset);
            Controls.Add(btnTambah);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Pembelian";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pembelian";
            FormClosed += Pembelian_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dgvPembelian).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPembelian;
        private TextBox txtbIdBarang;
        private TextBox txtbNamaBarang;
        private Label lblNamaBarang;
        private Label lblIdProduk;
        private TextBox txtbIdPelanggan;
        private Label lblIdPelanggan;
        private Button btnReset;
        private Button btnTambah;
        private TextBox txtbHargaSatuan;
        private Label lblHargaSatuan;
        private Label lblTotal;
        private Label lblTunai;
        private Label lblKembalian;
        private TextBox txtbTotal;
        private TextBox txtbTunai;
        private TextBox txtbKembalian;
        private Button btnSimpan;
        private DataGridViewTextBoxColumn clmId;
        private DataGridViewTextBoxColumn clmNama;
        private DataGridViewTextBoxColumn clmHarga;
        private DataGridViewTextBoxColumn clmKuantitas;
        private DataGridViewTextBoxColumn clmSubTotal;
        private TextBox txtbKuantitas;
        private Label lblKuantitas;
        private TextBox txtbSubtotal;
        private Label lblSubtotal;
        private Label lblHeader;
        private Button btnKembali;
    }
}