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
    public partial class ChangePasswordForm : Form
    {
        User user;

        public ChangePasswordForm(User u)
        {
            InitializeComponent();
            user = u;
        }
        

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            user.PasswordHash = UserManager.Hash(txtNewPassword.Text);

            Program.Manager.Save();

            MessageBox.Show("Heslo změněno");
            Close();
        }
    }
}
