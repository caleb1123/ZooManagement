namespace ZooApp
{
    partial class frmLogin
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
            label1 = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            txtUserName = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            cbPassword = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 62);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(231, 95);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(198, 27);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.KeyPress += txtPassword_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 95);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 0;
            label2.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(231, 62);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(198, 27);
            txtUserName.TabIndex = 1;
            txtUserName.KeyDown += txtEmail_KeyDown;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(171, 149);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(306, 149);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exits";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // cbPassword
            // 
            cbPassword.AutoSize = true;
            cbPassword.Location = new Point(435, 101);
            cbPassword.Name = "cbPassword";
            cbPassword.Size = new Size(18, 17);
            cbPassword.TabIndex = 4;
            cbPassword.UseVisualStyleBackColor = true;
            cbPassword.CheckedChanged += cbPassword_CheckedChanged;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 266);
            Controls.Add(cbPassword);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Name = "frmLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtUserName;
        private Button btnLogin;
        private Button btnExit;
        private CheckBox cbPassword;
    }
}