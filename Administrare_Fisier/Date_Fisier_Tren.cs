using System;
using System.Collections.Generic;
using System.Text;
using Clase_Tren;
using System.IO;
using System.Collections;
using System.Linq;
using System.ComponentModel.Design;

namespace Administrare_Fisier
{
    public class Date_Fisier_Tren
    {
        private const int NR_MAX_TRENURI = 20;
        private string dateTren;
        private const int ID_PRIMUL_TREN = 1;
        private const int INCREMENT = 1;

        public Date_Fisier_Tren(string numeFisier)
        {
            this.dateTren = numeFisier;
            Stream streamFisierText = File.Open(dateTren, FileMode.OpenOrCreate);
            streamFisierText.Close();

        }
        public void AddTren(Train tren)
        {
            tren.id_tren = GetId();
            using (StreamWriter streamWriterFisierText = new StreamWriter(dateTren, true))
            {
                streamWriterFisierText.WriteLine(tren.ConversieFisierText());
            }
        }
        private int GetId()
        {
            int idTren = ID_PRIMUL_TREN;
            using (StreamReader streamReader = new StreamReader(dateTren))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Train tren = new Train(linieFisier);
                    idTren = tren.id_tren + INCREMENT;
                }
            } 
            
            return idTren;
        }

        public List<Train> GetTrenuri()
        {
            ArrayList trenuri = new ArrayList();

            using (StreamReader streamReader = new StreamReader(dateTren))
            {
                string liniefisier;
                while((liniefisier= streamReader.ReadLine()) !=null)
                {
                    Train tren = new Train(liniefisier);
                    trenuri.Add(tren);
                }


            }
            return trenuri.Cast<Train>().ToList();

        }
        public List<Train> GetTrenuriLibere()
        {
            ArrayList trenuri = new ArrayList();

            using (StreamReader streamReader = new StreamReader(dateTren))
            {
                string liniefisier;
                while ((liniefisier = streamReader.ReadLine()) != null)
                {   
                    Train tren = new Train(liniefisier);
                    if(tren.status=="Liber")
                        trenuri.Add(tren);
                }


            }
            return trenuri.Cast<Train>().ToList();

        }
        public Train[] GetTrains(out int nrTrenuri)
        {
            Train[] tren = new Train[NR_MAX_TRENURI];
            using (StreamReader streamReader = new StreamReader(dateTren))
            {
                string liniefisier;
                nrTrenuri = 0;
                while ((liniefisier = streamReader.ReadLine()) != null)
                {
                    tren[nrTrenuri++] = new Train(liniefisier);
                }

            }
            Array.Resize(ref tren, nrTrenuri);

            return tren;

        }

        public bool UpdateTren(Train tren_editat)
        {
            List<Train> trenuri = GetTrenuri();
            bool actualizare = false;

            using (StreamWriter streamWriterFisierText= new StreamWriter(dateTren,false))
            {

                foreach(Train tren in trenuri)
                {
                    Train tren_de_scris = tren;
                    if(tren.id_tren==tren_editat.id_tren)
                    {
                        tren_de_scris = tren_editat;
                    }
                    streamWriterFisierText.WriteLine(tren_de_scris.ConversieFisierText());

                }
                actualizare = true;

            }
            return actualizare;
        }
        
        
    }
}
