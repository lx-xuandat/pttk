using System;
using System.Windows.Forms;

namespace Hou.WindowsForms
{
    static class Program
    {
        public static Models.NhanVien auth = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form frmLogin = new frmLogin();
            DialogResult result = frmLogin.ShowDialog();
            if(result == DialogResult.OK)
            {
                Application.Run(new frmDashBoard());
            }
            if (result == DialogResult.Cancel)
            {
                Application.Exit();
            }
        }
    }
}
