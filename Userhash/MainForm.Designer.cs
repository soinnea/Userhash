namespace Userhash
{
    partial class MainForm
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
            btnChangePassword = new Button();
            btnAdmin = new Button();
            SuspendLayout();
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new Point(307, 159);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(109, 48);
            btnChangePassword.TabIndex = 0;
            btnChangePassword.Text = "Změnit Heslo";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(307, 259);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.RightToLeft = RightToLeft.Yes;
            btnAdmin.Size = new Size(109, 48);
            btnAdmin.TabIndex = 1;
            btnAdmin.Text = "Adminek";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdmin);
            Controls.Add(btnChangePassword);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnChangePassword;
        private Button btnAdmin;
    }
}