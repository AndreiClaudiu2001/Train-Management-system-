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
    public partial class Form3 : Form
    {
        Date_Fisier_Pasager adminPasageri;
        public Form3()
        {
            string numeFisierPasageri = ConfigurationManager.AppSettings["datePasager"];
            string locatieFisierSolutiePasageri = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisierPasageri = locatieFisierSolutiePasageri + "\\" + numeFisierPasageri;
            adminPasageri = new Date_Fisier_Pasager(caleCompletaFisierPasageri);
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            List<Pasager> pasageri = adminPasageri.GetPasageri();
        }

        private void AfisarePasageriinDataGridView(List<Pasager> pasageri)
        {
            dataGridPasageri.DataSource = null;
            dataGridPasageri.DataSource = pasageri;
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
            List<Pasager> pasagers = adminPasageri.GetPasageri();
            radioButtonM.ForeColor = Color.Black;
            radioButtonF.ForeColor = Color.Black;
            TxtNume.BackColor = Color.White;
            TxtPrenume.BackColor = Color.White;
            TxtAdresa.BackColor = Color.White;
            TxtTelefon.BackColor = Color.White;
            ComboNationalitate.BackColor = Color.White;
            AfisarePasageriinDataGridView(pasagers);
            ResetareControale();
        }
        private void Buton_Adauga_Click(object sender, EventArgs e)
        {   
            string sex = null;
            if (radioButtonM.Checked)
                sex = "M";
            else if (radioButtonF.Checked)
                sex = "F";
            if ((radioButtonF.Checked || radioButtonM.Checked) && (TxtNume.Text != string.Empty) && (TxtPrenume.Text != string.Empty) && (TxtAdresa.Text != string.Empty) && (TxtTelefon.Text != string.Empty) && (ComboNationalitate.Text != string.Empty))
            {
                Pasager pasager = new Pasager(0, TxtNume.Text, TxtPrenume.Text, TxtAdresa.Text, ComboNationalitate.Text, TxtTelefon.Text, sex);
                radioButtonM.ForeColor = Color.Black;
                radioButtonF.ForeColor = Color.Black;
                TxtNume.BackColor = Color.White;
                TxtPrenume.BackColor = Color.White;
                TxtAdresa.BackColor = Color.White;
                TxtTelefon.BackColor = Color.White;
                ComboNationalitate.BackColor = Color.White;
                adminPasageri.AddPassager(pasager);
                ResetareControale();
            }
            else
            {
                if (sex != "F" && sex != "M")
                {
                    radioButtonM.ForeColor = Color.Red;
                    radioButtonF.ForeColor = Color.Red;

                }
                else
                {
                    radioButtonM.ForeColor = Color.Black;
                    radioButtonF.ForeColor = Color.Black;
                }
                if (TxtNume.Text == string.Empty)
                {
                    TxtNume.BackColor = Color.Red;
                }
                else
                { TxtNume.BackColor = Color.White; }

                if (TxtPrenume.Text == string.Empty)
                {
                    TxtPrenume.BackColor = Color.Red;
                }
                else { TxtPrenume.BackColor = Color.White; }
                if (TxtAdresa.Text == string.Empty)
                {
                    TxtAdresa.BackColor = Color.Red;
                }
                else
                { TxtAdresa.BackColor = Color.White; }
                if (TxtTelefon.Text == string.Empty)
                {
                    TxtTelefon.BackColor = Color.Red;
                }
                else { TxtTelefon.BackColor = Color.White; }

                if (ComboNationalitate.Text == string.Empty)
                {
                    ComboNationalitate.BackColor = Color.Red;
                }
                else
                {
                    ComboNationalitate.BackColor = Color.White;
                }

                return;

            }
           


        }

        private void ResetareControale()
        {
            TxtNume.Text= TxtPrenume.Text= TxtAdresa.Text=TxtTelefon.Text = string.Empty;
            ComboNationalitate.SelectedIndex = -1;
            radioButtonM.Checked = false;
            radioButtonF.Checked = false;
        }

        private void ButtonCautare_Click(object sender, EventArgs e)
        {
            List<Pasager> pasageri = adminPasageri.GetPasageriCautare(TxtNume.Text,TxtPrenume.Text);
            AfisarePasageriinDataGridView(pasageri);


        }
    }

}
