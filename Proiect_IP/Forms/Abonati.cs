using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_IP
{
    public partial class Abonati : Form
    {
        public Abonati()
        {
            InitializeComponent();
        }

        private void Abonati_Load(object sender, EventArgs e)
        {
            try
            {
                //creeaza o instanta a bazei de date
                DatabaseFacade database = DatabaseFacade.GetInstance;

                //face conexiunea cu tabela Utilizatori
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Utilizatori", database.Connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                //Se afiseaza pe interfata datele din baza de date
                dataGridView1.DataSource = dt;
                database.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AddPenalizareButton_Click(object sender, EventArgs e)
        {

            try
            {
                //Preia id-ul din form-ul asociat
                double id = Convert.ToDouble(updateUserTextBox.Text);
                Admin admin = new Admin();

                //Preia numarul de penalitati de la utilizator
                int penalizari = admin.GetUserPenalizari(id);

                //Incrementeaza numarul de penalitati
                if (penalizari < 5)
                {
                    penalizari++;
                    admin.UpdateUserPenalizari(id, penalizari);
                }

                //Daca numarul de penalitati a ajuns la maxim, se actualizeaza status-ul utilizatorului in "DA"
                if (penalizari == 5)
                {
                    admin.UpdateUserStatus(id, "DA");
                }

                //Daca numarul de penalitati a ajuns din nou la 0, se actualizeaza status-ul utilizatorului in "NU"
                if (penalizari == 0)
                {
                    admin.UpdateUserStatus(id, "NU");
                }
                MessageBox.Show("S-a adaugat penalizare!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "A aparut o eroare la adaugarea penalizarii!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DeletePenalizareButton_Click(object sender, EventArgs e)
        {

            try
            {
                double id = Convert.ToDouble(updateUserTextBox.Text);
                Admin admin = new Admin();

                int penalizari = admin.GetUserPenalizari(id);

                //Decrementeaza numarul penalitatilor
                if (penalizari <= 5 && penalizari > 0)
                {
                    penalizari--;
                    admin.UpdateUserPenalizari(id, penalizari);
                }

                //Daca utilizatorul a ajuns la 0 penalitati dupa stergere, status-ul utilizatorului se actualizeaza in "NU" 
                if (penalizari == 0)
                {
                    admin.UpdateUserStatus(id, "NU");
                }
                MessageBox.Show("S-a sters penalizare!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "A aparut o eroare la stergerea penalizarii!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
