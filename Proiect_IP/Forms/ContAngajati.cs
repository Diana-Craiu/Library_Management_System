using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_IP.Forms
{
    public partial class ContAngajati : Form
    {
        private LoginManager _loginManager;
        public ContAngajati()
        {
            InitializeComponent();
            _loginManager = new LoginManager();
        }

        private void ListaAbonatiButton_Click(object sender, EventArgs e)
        {
            //Preluarea numelui si parolei utilizatorului din form-ul asociat
            string username = auxUserBox.Text;
            string password = auxPassBox.Text;

            //Preluarea nivelului de acces al utilizatorului din form-ul asociat
            int accessLevel = comboBoxAccessLevel.SelectedIndex;

            //Apelarea functiei AddUser din clasa LoginManager pentru a adauga un nou utilizator
            _loginManager.AddUser(username, password, accessLevel);

            //Inchiderea form-ului
            this.Close();
        }
    }
}
