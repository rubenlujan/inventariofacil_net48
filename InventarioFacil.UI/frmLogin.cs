using InventarioFacil.Domain;
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
            lblMessageError.ForeColor = Color.Red;
            lblMessageError.Text =  string.Empty;
            txtPwd.Enter += TxtPwd_Enter;
        }

        private void TxtPwd_Enter(object sender, EventArgs e)
        {
            EnableTxtPwd();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUser.Text))
            {
                lblMessageError.Text = "Debe introducir el usuario.";
                return;
            }
            if (string.IsNullOrEmpty(txtPwd.Text))
            {
                lblMessageError.Text = "Debe introducir la contraseña.";
                return;
            }
            Login();
        }

        #region Methods
        private void MainForm_SessionClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            // Logout();////Invocar el método Cerrar sesión, cuando en el formulario principal se haya cerrado sesión.
        }

        private void Login()
        {
            this.Cursor = Cursors.WaitCursor;
            var welcomeForm = new frmSplash();
            welcomeForm.ShowDialog();
            var userModel = new UserModel().Login(txtUser.Text, txtPwd.Text);
            if (userModel != null)
            {
                var mainForm = new frmMainForm();
                this.Hide();
                mainForm.FormClosed += new FormClosedEventHandler(MainForm_SessionClosed);
                mainForm.Show();
            }
            else
            {
                lblMessageError.ForeColor = Color.Red;
                lblMessageError.Text = "Usuario o contraseña incorrecto";
            }
        }

        #endregion




    }
}
    