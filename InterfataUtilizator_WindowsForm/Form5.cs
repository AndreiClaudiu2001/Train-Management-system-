using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_Tren;
using Administrare_Fisier;
using System.Configuration;
using System.IO;

namespace InterfataUtilizator_WindowsForm
{
    public partial class Form5 : Form
    {
        Date_Fisier_Bilete adminBilete;
        Date_Fisier_Calatorii adminCalatorii;
        Date_Fisier_Pasager adminPasageri;

        private ComboBox comboID_Pasager;
        private ComboBox comboID_Calatorie;
        public Form5()
        {
            string numeFisierBilet = ConfigurationManager.AppSettings["dateBilete"];
            string locatieFisierSolutieBilet = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisierBilet = locatieFisierSolutieBilet + "\\" + numeFisierBilet;
            adminBilete = new Date_Fisier_Bilete(caleCompletaFisierBilet);
            string numeFisierPasageri = ConfigurationManager.AppSettings["datePasager"];
            string locatieFisierSolutiePasageri = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisierPasageri = locatieFisierSolutiePasageri + "\\" + numeFisierPasageri;
            adminPasageri = new Date_Fisier_Pasager(caleCompletaFisierPasageri);
            string numeFisierCalatorie = ConfigurationManager.AppSettings["dateCalatorii"];
            string locatieFisierSolutieCalatorie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisierCalatorie = locatieFisierSolutieCalatorie + "\\" + numeFisierCalatorie;
            adminCalatorii = new Date_Fisier_Calatorii(caleCompletaFisierCalatorie);

            List<Pasager> pasageri = adminPasageri.GetPasageri();
            List<Travel> calatorii = adminCalatorii.GetCalatorii();

            comboID_Pasager = new ComboBox();
            comboID_Pasager.Location = new Point(290, 106);
            comboID_Pasager.Size = new Size(100, 20);
            foreach (Pasager pasager in pasageri)
            {
                comboID_Pasager.Items.Add(pasager.id_pasager.ToString());

            }
            this.Controls.Add(comboID_Pasager);

            comboID_Calatorie = new ComboBox();
            comboID_Calatorie.Location = new Point(550, 106);
            comboID_Calatorie.Size = new Size(100, 20);
            foreach (Travel travel in calatorii)
            {
                comboID_Calatorie.Items.Add(travel.id_travel.ToString());

            }
            this.Controls.Add(comboID_Calatorie);


            InitializeComponent();
        }
        private void AfisareBileteinDataGridView(List<Ticket> bilete)
        {
            dataGridViewBilete.DataSource = null;
            dataGridViewBilete.DataSource = bilete;
        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 meniu = new Form2();

            meniu.ShowDialog();
            this.Close();
        }

        private void Buton_Reset_Click(object sender, EventArgs e)
        {
            List<Ticket> bilete = adminBilete.GetBilete();
            AfisareBileteinDataGridView(bilete);
            comboID_Pasager.BackColor = Color.White;
            comboID_Calatorie.BackColor = Color.White;
            ResetareControale();
        }

        private void Buton_Cautare_Click(object sender, EventArgs e)
        {
            List<Ticket> bilete = adminBilete.GetPasagerID(comboID_Pasager.SelectedIndex+1);
            AfisareBileteinDataGridView(bilete);

        }

        private void Buton_Adauga_Click(object sender, EventArgs e)
        {
            int id_calatorie;
            bool rezultat = int.TryParse(comboID_Calatorie.Text, out id_calatorie);


            int id_pasager;
            bool result = int.TryParse(comboID_Pasager.Text, out id_pasager);
            if ((comboID_Calatorie.Text != string.Empty) && (comboID_Pasager.Text != string.Empty))
            {
                Ticket bilet = new Ticket(0, id_pasager, id_calatorie);
                adminBilete.AddTicket(bilet);
                comboID_Pasager.BackColor = Color.White;
                comboID_Calatorie.BackColor = Color.White;

                ResetareControale();
            }
            else
            {
                if (comboID_Calatorie.Text == string.Empty)
                { comboID_Calatorie.BackColor = Color.Red; }
                else
                {
                    comboID_Calatorie.BackColor = Color.White;
                }
                if (comboID_Pasager.Text == string.Empty)
                {
                    comboID_Pasager.BackColor = Color.Red;
                }
                else
                {
                    comboID_Pasager.BackColor = Color.White;
                }
                return;
            }
        }
        private void ResetareControale()
        {
            comboID_Pasager.SelectedIndex = -1;
            comboID_Calatorie.SelectedIndex = -1;



        }
    }
}
