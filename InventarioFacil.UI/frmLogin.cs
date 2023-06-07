using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioFacil.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
       

        private void txtPwd_Click(object sender, EventArgs e)
        {
            EnableTxtPwd();
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            txtUser.BackColor = Color.White;
            pnlUser.BackColor = Color.White;
            pnlPwd.BackColor = SystemColors.Control;
            txtPwd.BackColor = SystemColors.Control;
        }

        private void pnViewPwd_MouseDown(object sender, MouseEventArgs e)
        {
            txtPwd.UseSystemPasswordChar = false;
        }

        private void pnViewPwd_MouseUp(object sender, MouseEventArgs e)
        {
            txtPwd.UseSystemPasswordChar = true;
        }

        private void EnableTxtPwd() {
            txtPwd.BackColor = Color.White;
            pnlPwd.BackColor = Color.White;
            pnlUser.BackColor = SystemColors.Control;
            txtUser.BackColor = SystemColors.Control;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPwd.Enter += TxtPwd_Enter;
        }

        private void TxtPwd_Enter(object sender, EventArgs e)
        {
            EnableTxtPwd();
        }
    }
}
    