namespace kasir_ukk
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
            lblUsername = new Label();
            txtbUsername = new TextBox();
            txtbPassword = new TextBox();
            lblPassword = new Label();
            lblHeader = new Label();
            btnLogin = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(33, 91);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(91, 25);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // txtbUsername
            // 
            txtbUsername.BorderStyle = BorderStyle.FixedSingle;
            txtbUsername.Location = new Point(33, 119);
            txtbUsername.MaxLength = 255;
            txtbUsername.Name = "txtbUsername";
            txtbUsername.Size = new Size(186, 31);
            txtbUsername.TabIndex = 0;
            // 
            // txtbPassword
            // 
            txtbPassword.BorderStyle = BorderStyle.FixedSingle;
            txtbPassword.Location = new Point(33, 204);
            txtbPassword.MaxLength = 255;
            txtbPassword.Name = "txtbPassword";
            txtbPassword.Size = new Size(186, 31);
            txtbPassword.TabIndex = 2;
            txtbPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(33, 176);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.Location = new Point(83, 21);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(87, 32);
            lblHeader.TabIndex = 4;
            lblHeader.Text = "Log In";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(33, 272);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(186, 34);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(33, 312);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(186, 34);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(251, 374);
            Controls.Add(btnClear);
            Controls.Add(btnLogin);
            Controls.Add(lblHeader);
            Controls.Add(txtbPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtbUsername);
            Controls.Add(lblUsername);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosed += Form1_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private TextBox txtbUsername;
        private TextBox txtbPassword;
        private Label lblPassword;
        private Label lblHeader;
        private Button btnLogin;
        private Button btnClear;
    }
}