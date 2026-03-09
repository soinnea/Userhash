using UserHash;

namespace Userhash
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            User u = Program.Manager.Login(txtUser.Text, txtPass.Text);

            if (u == null)
            {
                MessageBox.Show("Špatné pøihlášení");
                return;
            }

            MainForm f = new MainForm(u);
            f.Show();
            this.Hide();
        }
    }
}
