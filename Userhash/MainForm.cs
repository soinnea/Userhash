using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Userhash
{
    public partial class MainForm : Form
    {
        User user;

        public MainForm(User u)
        {
            InitializeComponent();
            user = u;

            if (!user.IsAdmin())
                btnAdmin.Visible = false;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm f = new ChangePasswordForm(user);
            f.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminForm f = new AdminForm();
            f.ShowDialog();
        }
    }
}
