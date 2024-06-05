namespace kasir_ukk
{
    partial class Main
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
            btnRegistrasi = new Button();
            btnBarang = new Button();
            Kasir = new Button();
            btnLogout = new Button();
            panel1 = new Panel();
            lblTipeUser = new Label();
            lblHeader = new Label();
            lblHeader2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegistrasi
            // 
            btnRegistrasi.Location = new Point(34, 244);
            btnRegistrasi.Name = "btnRegistrasi";
            btnRegistrasi.Size = new Size(166, 40);
            btnRegistrasi.TabIndex = 0;
            btnRegistrasi.Text = "Registrasi";
            btnRegistrasi.UseVisualStyleBackColor = true;
            btnRegistrasi.Click += btnRegistrasi_Click;
            // 
            // btnBarang
            // 
            btnBarang.Location = new Point(34, 153);
            btnBarang.Name = "btnBarang";
            btnBarang.Size = new Size(166, 40);
            btnBarang.TabIndex = 1;
            btnBarang.Text = "Barang";
            btnBarang.UseVisualStyleBackColor = true;
            btnBarang.Click += btnBarang_Click;
            // 
            // Kasir
            // 
            Kasir.Location = new Point(34, 198);
            Kasir.Name = "Kasir";
            Kasir.Size = new Size(166, 40);
            Kasir.TabIndex = 2;
            Kasir.Text = "Kasir";
            Kasir.UseVisualStyleBackColor = true;
            Kasir.Click += Kasir_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(34, 385);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(166, 40);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(lblTipeUser);
            panel1.Controls.Add(btnRegistrasi);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnBarang);
            panel1.Controls.Add(Kasir);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(231, 450);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // lblTipeUser
            // 
            lblTipeUser.AutoSize = true;
            lblTipeUser.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipeUser.ForeColor = Color.White;
            lblTipeUser.Location = new Point(68, 76);
            lblTipeUser.Name = "lblTipeUser";
            lblTipeUser.Size = new Size(99, 30);
            lblTipeUser.TabIndex = 4;
            lblTipeUser.Text = "TipeUser";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeader.Location = new Point(306, 153);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(140, 48);
            lblHeader.TabIndex = 5;
            lblHeader.Text = "Selamat";
            // 
            // lblHeader2
            // 
            lblHeader2.AutoSize = true;
            lblHeader2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader2.Location = new Point(306, 201);
            lblHeader2.Name = "lblHeader2";
            lblHeader2.Size = new Size(193, 65);
            lblHeader2.TabIndex = 6;
            lblHeader2.Text = "Datang";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHeader2);
            Controls.Add(lblHeader);
            Controls.Add(panel1);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            FormClosed += Main_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrasi;
        private Button btnBarang;
        private Button Kasir;
        private Button btnLogout;
        private Panel panel1;
        private Label lblHeader;
        private Label lblHeader2;
        private Label lblTipeUser;
    }
}