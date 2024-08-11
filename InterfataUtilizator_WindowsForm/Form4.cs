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
     
    public partial class Form4 : Form
    {
        Date_Fisier_Calatorii adminCalatorii;
        Date_Fisier_Tren adminTrenuri;


        private ComboBox comboID_Tren;
        public Form4()
        {
            string numeFisierCalatorie = ConfigurationManager.AppSettings["dateCalatorii"];
            string locatieFisierSolutieCalatorie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisierCalatorie = locatieFisierSolutieCalatorie + "\\" + numeFisierCalatorie;
            adminCalatorii = new Date_Fisier_Calatorii(caleCompletaFisierCalatorie);

            string numeFisierTren= ConfigurationManager.AppSettings["dateTren"];
            string locatieFisierSolutieTren = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisierTren = locatieFisierSolutieTren + "\\" + numeFisierTren;
            adminTrenuri = new Date_Fisier_Tren(caleCompletaFisierTren);
            List<Train> trenuri = adminTrenuri.GetTrenuri();

            comboID_Tren = new ComboBox();
            comboID_Tren.Location = new Point(410, 106);
            comboID_Tren.Size = new Size(100, 20);
            foreach (Train trenul in trenuri)
            {
                comboID_Tren.Items.Add(trenul.id_tren.ToString());
              
            }
            this.Controls.Add(comboID_Tren);
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
        private void AfisareCalatoriinDataGridView(List<Travel> calatorii)
        {
            dataGridCalatorii.DataSource = null;
            dataGridCalatorii.DataSource = calatorii;
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
            List<Travel> calatorii = adminCalatorii.GetCalatorii();
            AfisareCalatoriinDataGridView(calatorii);
            
        }

        private void Buton_Adauga_Click(object sender, EventArgs e)
        {
            int id_tren;
            bool rezultat = int.TryParse(comboID_Tren.Text, out id_tren);

            int cost;
            bool result = int.TryParse(textBoxCost.Text, out cost);

            if ((textBoxOra.Text != string.Empty) && (comboID_Tren.Text != string.Empty) && (textBoxPlecare.Text != string.Empty) && (textBoxSosire.Text != string.Empty) && (textBoxCost.Text != string.Empty))
            {
                Travel calatorie = new Travel(0, dateTimePicker.Text, textBoxOra.Text, id_tren, textBoxPlecare.Text, textBoxSosire.Text, cost);
                textBoxOra.BackColor = Color.White;
                textBoxPlecare.BackColor = Color.White;
                textBoxSosire.BackColor = Color.White;
                textBoxCost.BackColor = Color.White;
                comboID_Tren.BackColor = Color.White;
                dateTimePicker.CalendarTitleBackColor = Color.White;
                adminCalatorii.AddTravel(calatorie);
                ResetareControale();
            }
            else
            {
                if (textBoxOra.Text == string.Empty)
                {
                    textBoxOra.BackColor = Color.Red;
                }
                else
                { textBoxOra.BackColor = Color.White; }

                if (textBoxPlecare.Text == string.Empty)
                {
                    textBoxPlecare.BackColor = Color.Red;
                }
                else { textBoxPlecare.BackColor = Color.White; }
                if (textBoxSosire.Text == string.Empty)
                {
                    textBoxSosire.BackColor = Color.Red;
                }
                else
                { textBoxSosire.BackColor = Color.White; }
                if (textBoxCost.Text == string.Empty)
                {
                    textBoxCost.BackColor = Color.Red;
                }
                else
                { textBoxCost.BackColor = Color.White; }
                if (comboID_Tren.Text == string.Empty)
                {
                    comboID_Tren.BackColor = Color.Red;
                }
                else
                {
                    comboID_Tren.BackColor = Color.White;
                }
                return;
                /*Travel calatorie = new Travel(0, dateTimePicker.Text, textBoxOra.Text, id_tren, textBoxPlecare.Text, textBoxSosire.Text, cost);
                adminCalatorii.AddTravel(calatorie);
                ResetareControale();*/
            }
        }
        
        private void ResetareControale()
        {
            textBoxCost.Text = textBoxOra.Text = textBoxPlecare.Text = textBoxSosire.Text = string.Empty;
            comboID_Tren.SelectedIndex = -1;
            
            
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            List<Travel> calatorii = adminCalatorii.GetCalatorii();
        }
        

        private void comboID_Tren_SelectedIndexChanged(object sender, EventArgs e)
        {
            
               
                
                }

        private void ButonCautaare_Click(object sender, EventArgs e)
        {
            List<Travel> calatorii = adminCalatorii.GetCalatoriiCautare(textBoxPlecare.Text, textBoxSosire.Text);
            AfisareCalatoriinDataGridView(calatorii);
        }
    }
}
