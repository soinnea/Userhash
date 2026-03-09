using System;
using System.Windows.Forms;
using Userhash;

namespace UserHash
{
    static class Program
    {
        public static UserManager Manager = new UserManager();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Manager.Load();

            if (Manager.Users.Count == 0)
            {
                AdminUser admin = new AdminUser();
                admin.Username = "admin";
                admin.PasswordHash = UserManager.Hash("admin");

                Manager.Users.Add(admin);
                Manager.Save();
            }


            Application.Run(new LoginForm());
        }
    }
}