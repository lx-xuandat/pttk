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
    public partial class frmDashBoard : Form
    {
        protected Models.NhanVien authUser = Program.auth;
        public frmDashBoard()
        {
            InitializeComponent();
        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            label1.Text = authUser.sUser;
        }
    }
}
