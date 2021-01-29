using Domain;
using Forme.Exceptions;
using Forme.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme.Controller
{
    public class LoginController
    {
        internal void Login(TextBox txtUsername, TextBox txtPassword, FrmLogin frmLogin)
        {
            if (!UserControlHelpers.
                EmptyFieldValidation(txtUsername)
                | !UserControlHelpers.EmptyFieldValidation(txtPassword))
            {
                MessageBox.Show("Oba polja su obavezna!");
                return;
            }
            try
            {
                User k = Communication.Communication.Instance.Login(txtUsername.Text, txtPassword.Text);
                MainCoordinator.Instance.User = k;
                MessageBox.Show($"Korisnik {k.FirstName} {k.LastName} se uspesno prijavio!");
                MainCoordinator.Instance.OpenMainForm();
                frmLogin.Dispose();
            }
            catch (SystemOperationException)
            {
                MessageBox.Show("Sistem ne može da prepozna radnika!");
            }
        }

        internal void Connect()
        {
            try
            {
                Communication.Communication.Instance.Connect();
            }
            catch (SocketException)
            {
                MessageBox.Show("Greska pri povezivanju sa serverom!");
                Environment.Exit(0);
            }
        }
    }
}
