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
    public partial class Status : Form
    {
        public Status()
        {
            InitializeComponent();
        }

        private void ModifcaButton_Click(object sender, EventArgs e)
        {
            //Preia detaliile cartii din form-ul asociat
            double isbn = Convert.ToDouble(ISBNStatusBox.Text);
            double exemplare = Convert.ToDouble(nrExBox.Text);
            string status = Convert.ToString(statusComboBox.SelectedItem);

            try
            {
                Admin admin = new Admin();

                //Actualizeaza status-ul cartii si numarul de copii in baza de date
                admin.UpdateBookStatus(isbn, status);
                admin.UpdateBookNrExemplare(isbn, exemplare);

                MessageBox.Show("Statusul cartii s-a modificat cu succes!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "A aparut o eroare la adaugarea cartii!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Elibereaza campurile
            ISBNStatusBox.Clear();
            nrExBox.Clear();
        }

        private void Status_Load(object sender, EventArgs e)
        {
            try
            {
                DatabaseFacade database = DatabaseFacade.GetInstance;

                //Preia datele din tabela Carti si le afiseaza pe form
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Carti", database.Connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                database.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
