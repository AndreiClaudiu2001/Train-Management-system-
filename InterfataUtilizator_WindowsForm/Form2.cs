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
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
            
        }
       // Application.Run(new Form2());
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Trenuri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 trenuri = new Form1();
            trenuri.Tag = this;
            trenuri.StartPosition = FormStartPosition.Manual;
            trenuri.Location = this.Location;
           
            trenuri.ShowDialog();
            this.Close();

        }

        private void PASAGERI_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 pasageri = new Form3();
            pasageri.Tag = this;
            pasageri.StartPosition = FormStartPosition.Manual;
            pasageri.Location = this.Location;
            pasageri.ShowDialog();
            this.Close();
        }

        private void CALATORII_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 calatorii = new Form4();
            calatorii.StartPosition = FormStartPosition.Manual;
            calatorii.Location = this.Location;
            calatorii.ShowDialog();
            this.Close();

        }

        private void BILETE_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 bilete = new Form5();
            bilete.StartPosition = FormStartPosition.Manual;
            bilete.Location = this.Location;
            bilete.ShowDialog();
            this.Close();

        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
