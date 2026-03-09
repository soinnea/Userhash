namespace Userhash
{
    partial class AdminForm
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
            listUsers = new ListBox();
            txtNewPassword = new TextBox();
            btnReset = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // listUsers
            // 
            listUsers.FormattingEnabled = true;
            listUsers.ItemHeight = 15;
            listUsers.Location = new Point(38, 46);
            listUsers.Name = "listUsers";
            listUsers.Size = new Size(433, 289);
            listUsers.TabIndex = 0;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(541, 155);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(187, 23);
            txtNewPassword.TabIndex = 1;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(573, 233);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(127, 102);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(609, 115);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 3;
            label1.Text = "new heslo";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnReset);
            Controls.Add(txtNewPassword);
            Controls.Add(listUsers);
            Name = "AdminForm";
            Text = "AdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listUsers;
        private TextBox txtNewPassword;
        private Button btnReset;
        private Label label1;
    }
}