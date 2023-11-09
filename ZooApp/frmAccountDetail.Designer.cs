namespace ZooApp
{
    partial class frmAccountDetail
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
            txtUserID = new TextBox();
            txtUserName = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label4 = new Label();
            txtRole = new TextBox();
            label5 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 41);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "UserID";
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(183, 38);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(274, 27);
            txtUserID.TabIndex = 1;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(183, 71);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(274, 27);
            txtUserName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 74);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 2;
            label2.Text = "User Name";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(183, 104);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(274, 27);
            txtPassword.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 107);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // txtName
            // 
            txtName.Location = new Point(183, 137);
            txtName.Name = "txtName";
            txtName.Size = new Size(274, 27);
            txtName.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 140);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 6;
            label4.Text = "Name";
            // 
            // txtRole
            // 
            txtRole.Location = new Point(183, 170);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(274, 27);
            txtRole.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 173);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 8;
            label5.Text = "Role";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(149, 224);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "button1";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmAccountDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 290);
            Controls.Add(btnSave);
            Controls.Add(txtRole);
            Controls.Add(label5);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(txtUserID);
            Controls.Add(label1);
            Name = "frmAccountDetail";
            Text = "Form1";
            Load += frmAccountDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUserID;
        private TextBox txtUserName;
        private Label label2;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtName;
        private Label label4;
        private TextBox txtRole;
        private Label label5;
        private Button btnSave;
    }
}