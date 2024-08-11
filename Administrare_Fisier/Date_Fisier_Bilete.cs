using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;
using System.Linq;
using Clase_Tren;

namespace Administrare_Fisier
{
    public class Date_Fisier_Bilete
    {
        private string dateBilete;
        private const int ID_PRIMUL_BILET = 1;
        private const int INCREMENT = 1;
        public Date_Fisier_Bilete(string numeFisier)
        {
            this.dateBilete = numeFisier;
            Stream streamFisierText = File.Open(dateBilete, FileMode.OpenOrCreate);
            streamFisierText.Close();

        }
        public void AddTicket(Ticket ticket)
        {
            ticket.id_bilet = GetId();
            using (StreamWriter streamWriterFisierText = new StreamWriter(dateBilete, true))
            {
                streamWriterFisierText.WriteLine(ticket.ConversieFisierText());
            }
        }

        private int GetId()
        {
            int idBilet = ID_PRIMUL_BILET;
            using (StreamReader streamReader = new StreamReader(dateBilete))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Ticket bilet = new Ticket(linieFisier);
                    idBilet = bilet.id_bilet + INCREMENT;
                    
                }
            }

            return idBilet;
        }
        public List<Ticket> GetBilete()
        {
            ArrayList bilete = new ArrayList();

            using (StreamReader streamReader = new StreamReader(dateBilete))
            {
                string liniefisier;
                while ((liniefisier = streamReader.ReadLine()) != null)
                {
                    Ticket bilet = new Ticket(liniefisier);
                    bilete.Add(bilet);
                  

                }
            }
            return bilete.Cast<Ticket>().ToList();
        }
        public List<Ticket> GetPasagerID(int id_pasager)
        {
            ArrayList bilete = new ArrayList();

            using (StreamReader streamReader = new StreamReader(dateBilete))
            {
                string liniefisier;
                while ((liniefisier = streamReader.ReadLine()) != null)
                {
                    Ticket bilet = new Ticket(liniefisier);
                    if(bilet.GetIDPersoana()== id_pasager)
                    bilete.Add(bilet);

                }
            }
            return bilete.Cast<Ticket>().ToList();
        }
    }
}
