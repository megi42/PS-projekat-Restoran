using ControllerBL;
using Domain;
using Forme.Controller;
using Forme.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    public partial class FrmLogin : Form
    {
        private LoginController loginController;

        public FrmLogin()
        {
            InitializeComponent();
        }

        public FrmLogin(LoginController loginController)
        {
            this.loginController = loginController;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginController.Login(txtUsername, txtPassword, this);
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            loginController.Connect();
        }
    }
}
