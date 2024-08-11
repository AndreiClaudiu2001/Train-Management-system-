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
    public partial class Form1 : Form
    { private const int NESELECTAT = -1;
        Date_Fisier_Tren adminTrenuri;

        public Form1()
        {
            string numeFisierTren = ConfigurationManager.AppSettings["dateTren"];
            string locatieFisierSolutieTren = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisierTren = locatieFisierSolutieTren + "\\" + numeFisierTren;
            adminTrenuri = new Date_Fisier_Tren(caleCompletaFisierTren);
            InitializeComponent();


        }
   
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Train> trenuri =adminTrenuri.GetTrenuri();
        }

        private void AfisareTrenuriDataGridView(List<Train> trenuri)
        {
            dataGridTrenuri.DataSource = null;
            dataGridTrenuri.DataSource = trenuri;
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
            List<Train> trenuri = adminTrenuri.GetTrenuri();
            radioButtonLiber.ForeColor = Color.Black;
            radioButtonOcupat.ForeColor = Color.Black;
            textNumeTr.BackColor = Color.White;
            textBoxCapacity.BackColor = Color.White;
            AfisareTrenuriDataGridView(trenuri);
        }

        
        private void Buton_Adauga_Click(object sender, EventArgs e)
        {

            int capacity;
            bool result = int.TryParse(textBoxCapacity.Text, out capacity);
            string status = null;
            if (radioButtonLiber.Checked)
                status = "Liber";
            else if (radioButtonOcupat.Checked)
                status = "Ocupat";
            if ((radioButtonLiber.Checked || radioButtonOcupat.Checked) && (textNumeTr.Text != string.Empty) && (textBoxCapacity.Text != string.Empty))
            {
                Train tren = new Train(0, textNumeTr.Text, capacity, status);
                radioButtonLiber.ForeColor = Color.Black;
                radioButtonOcupat.ForeColor = Color.Black;
                textNumeTr.BackColor = Color.White;
                textBoxCapacity.BackColor = Color.White;
                adminTrenuri.AddTren(tren);
                ResetareControale();
            }
            else
            {
                if (status != "Ocupat" && status != "Liber")
                {
                    radioButtonLiber.ForeColor = Color.Red;
                    radioButtonOcupat.ForeColor = Color.Red;
                }
                else
                {
                    radioButtonLiber.ForeColor = Color.Black;
                    radioButtonOcupat.ForeColor = Color.Black;
                }

                if (textNumeTr.Text == string.Empty)
                    {
                        textNumeTr.BackColor = Color.Red;
                    }
                else
                {
                    textNumeTr.BackColor = Color.White;
                }
                    if (textBoxCapacity.Text == string.Empty)
                    {
                        textBoxCapacity.BackColor = Color.Red;
                    }
                    else
                {
                    textBoxCapacity.BackColor = Color.White ;
                }
                    return;

                
            }

           
            
        }
        private void ResetareControale()
        {
            textNumeTr.Text = textBoxCapacity.Text = string.Empty;
            radioButtonLiber.Checked = false;
            radioButtonOcupat.Checked = false;
            
        }

        private void Buton_Stergere_Click(object sender, EventArgs e)
        {   
            


            
        }

        private void Disponibile_Click(object sender, EventArgs e)
        {
            List<Train> trenuri = adminTrenuri.GetTrenuriLibere();
            AfisareTrenuriDataGridView(trenuri);
        }
    }


}
