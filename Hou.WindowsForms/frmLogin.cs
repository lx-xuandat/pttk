using Hou.Models;
using Hou.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hou.WindowsForms
{
    public partial class frmLogin : Form
    {
        protected AuthService auth;
        public frmLogin()
        {
            InitializeComponent();
            lbHelper.Visible = false;
            auth = new AuthService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            NhanVien result = auth.Login(readInfoLogin());
            if (result != null)
            {
                Program.auth = result;
                this.DialogResult = DialogResult.OK;
            } else
            {
                lbHelper.Visible = true;
            }
        }

        private NhanVien readInfoLogin()
        {
            return new NhanVien() {
                sUser = txtUsername.Text.Trim(),
                sPass = txtPassword.Text.Trim()
            };
        }

        private void txtUsername_txtPasswrod_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = !(
                    String.IsNullOrEmpty(txtPassword.Text)
                    ||
                    String.IsNullOrEmpty(txtPassword.Text)
                );
        }

        private void txtUsername_txtPasswrod_TextReset(object sender, EventArgs e)
        {
            txtUsername.Text = txtPassword.Text = String.Empty;
        }
    }
}
