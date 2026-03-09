namespace Userhash
{
    partial class LoginForm
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
            txtPass = new TextBox();
            txtUser = new TextBox();
            btnLogin = new Button();
            User = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtPass
            // 
            txtPass.Location = new Point(293, 217);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(139, 23);
            txtPass.TabIndex = 0;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(293, 153);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(139, 23);
            txtUser.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(293, 275);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(139, 42);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // User
            // 
            User.AutoSize = true;
            User.Location = new Point(345, 135);
            User.Name = "User";
            User.Size = new Size(39, 15);
            User.TabIndex = 3;
            User.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(345, 199);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(User);
            Controls.Add(btnLogin);
            Controls.Add(txtUser);
            Controls.Add(txtPass);
            Name = "LoginForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPass;
        private TextBox txtUser;
        private Button btnLogin;
        private Label User;
        private Label label2;
    }
}
