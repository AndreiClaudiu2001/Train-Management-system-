using System;
using System.Collections.Generic;
using System.Text;
using Clase_Tren;
using System.IO;
using System.Collections;
using System.Linq;

namespace Administrare_Fisier
{
    public class Date_Fisier_Calatorii
    {

        private string dateCalatorii;
        private const int ID_PRIMA_CALATORIE = 1;
        private const int INCREMENT = 1;

        public Date_Fisier_Calatorii(string numeFisier)
        {
            this.dateCalatorii = numeFisier;
            Stream streamFisierText = File.Open(dateCalatorii, FileMode.OpenOrCreate);
            streamFisierText.Close();

        }
        public void AddTravel(Travel travel)
        {
            travel.id_travel = GetId();
            using (StreamWriter streamWriterFisierText = new StreamWriter(dateCalatorii, true))
            {
                streamWriterFisierText.WriteLine(travel.ConversieFisierText());
            }
        }
        private int GetId()
        {
            int idTravel = ID_PRIMA_CALATORIE;
            using (StreamReader streamReader = new StreamReader(dateCalatorii))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Travel travel = new Travel(linieFisier);
                    idTravel = travel.id_travel + INCREMENT;
                }
            }

            return idTravel;
        }
        public List<Travel> GetCalatorii()
        {
            ArrayList travels = new ArrayList();

            using (StreamReader streamReader = new StreamReader(dateCalatorii))
            {
                string liniefisier;
                while ((liniefisier = streamReader.ReadLine()) != null)
                {
                    Travel travel = new Travel(liniefisier);
                    travels.Add(travel);
                    
                }
            }
            return travels.Cast<Travel>().ToList();
        }

        public List<Travel> GetCalatoriiCautare(string plecare,string destinatie)
        {
            ArrayList travels = new ArrayList();

            using (StreamReader streamReader = new StreamReader(dateCalatorii))
            {
                string liniefisier;
                while ((liniefisier = streamReader.ReadLine()) != null)
                {
                    Travel travel = new Travel(liniefisier);
                    if(travel.GetPlecare()==plecare && travel.GetSosire()==destinatie)
                    travels.Add(travel);

                }
            }
            return travels.Cast<Travel>().ToList();
        }

    }

}
