using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHATKYHOTRO
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

     

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text.Trim() !="" && txtPassword.Text.Trim() != "")
            {
                MessageBox.Show("Đăng nhập thành công ");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập liệu");
            }
        }
    }
}
