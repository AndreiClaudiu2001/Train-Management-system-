using System;
using System.Text;
using Clase_Tren;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Administrare_Fisier
{
    public class Date_Fisier_Pasager
    {
        private const int INCREMENT = 1;
        private const int ID_PRIMUL_PASAGER = 1;
        private const int NR_MAX_PASAGERI = 20;
        private string datePasager;
        public Date_Fisier_Pasager(string numeFisier)
        {
            this.datePasager = numeFisier;
            Stream streamFisierText = File.Open(datePasager, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public List<Pasager> GetPasageri()
        {
            ArrayList pasageri = new ArrayList();

            using ( StreamReader streamReader = new StreamReader(datePasager))
            {
                string liniefisier;
                while((liniefisier= streamReader.ReadLine())!=null)
                {
                    Pasager pasager = new Pasager(liniefisier);
                    pasageri.Add(pasager);
                }
            }
            return pasageri.Cast<Pasager>().ToList();

        }
        public List<Pasager> GetPasageriCautare(string nume,string prenume)
        {
            ArrayList pasageri = new ArrayList();

            using (StreamReader streamReader = new StreamReader(datePasager))
            {
                string liniefisier;
                while ((liniefisier = streamReader.ReadLine()) != null)
                {
                    Pasager pasager = new Pasager(liniefisier);
                    if (pasager.GetNumeP() == nume && pasager.GetPrenumeP() == prenume)
                        pasageri.Add(pasager);
                }
            }
            return pasageri.Cast<Pasager>().ToList();

        }

        public void AddPassager(Pasager pasager)
        {
            pasager.id_pasager = GetId();
            using (StreamWriter streamWriterFisierText = new StreamWriter(datePasager, true))
            {
                streamWriterFisierText.WriteLine(pasager.ConversieFisierText());
            }
        }

        private int GetId()
        {
            int IDPasager = ID_PRIMUL_PASAGER;
            using (StreamReader streamReader = new StreamReader(datePasager))
            {
                string linieFisier;
                while((linieFisier = streamReader.ReadLine())!=null)
                {
                    Pasager pasager = new Pasager(linieFisier);
                    IDPasager = pasager.id_pasager + INCREMENT;
                }
            }
            return IDPasager;
        }
        public Pasager[] GetPasagers(out int nrPasageri)
        {
            Pasager[] pasager = new Pasager[NR_MAX_PASAGERI];
            using (StreamReader streamReader = new StreamReader(datePasager))
            {
                string liniefisier;
                nrPasageri = 0;
                while((liniefisier=streamReader.ReadLine())!=null)
                {
                    pasager[nrPasageri++] = new Pasager(liniefisier);
                }
                
            }
            Array.Resize(ref pasager,nrPasageri);
            return pasager;


        }
        public Pasager GetPasager(string nume, string prenume)
        {
            Pasager pasager;
            using (StreamReader streamReader= new StreamReader(datePasager))
            {
                string liniefisier;
                while ((liniefisier= streamReader.ReadLine())!=null)
                {
                    pasager = new Pasager(liniefisier);
                    if (pasager.GetNumeP() == nume && pasager.GetPrenumeP() == prenume)
                        return pasager;
                }
            }
            Pasager invalid_data = new Pasager();
            return invalid_data;
        }


    }
}
