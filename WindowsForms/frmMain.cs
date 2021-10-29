using App.Models;
using App.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class frmMain : Form
    {
        protected AuthService authService;
        public frmMain()
        {
            InitializeComponent();

            authService = new AuthService();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            NhanVien nhanVien = authService.login(this.readInfoLogin());

            if (nhanVien != null)
            {
                MessageBox.Show("Login Thah Cong");
                return;
            }
            MessageBox.Show("Login That Bai");
        }

        private NhanVien readInfoLogin()
        {
            return new NhanVien()
            {
                sUser = "xuandat",
                sPass = "123",
            };
        }
    }
}
