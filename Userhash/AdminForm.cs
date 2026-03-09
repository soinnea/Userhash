using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserHash;

namespace Userhash
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();

            listUsers.DataSource = Program.Manager.Users;
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            User u = (User)listUsers.SelectedItem;

            u.PasswordHash = UserManager.Hash(txtNewPassword.Text);

            Program.Manager.Save();

            MessageBox.Show("Heslo změněno");
        }
    }
}
