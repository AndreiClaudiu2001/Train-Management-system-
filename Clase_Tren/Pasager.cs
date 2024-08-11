using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_Tren
{
    public class Pasager
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const int ID = 0;
        private const int NUME = 1;
        private const int PRENUME = 2;
        private const int ADRESA = 3;
        private const int NATIONALITATE = 4;
        private const int NR_TEL = 5;
        private const int SEX = 6;
        
        public int id_pasager{get; set;}
        public string nume
        {
            get; set;
        }
        public string prenume
        {
            get; set;
         }
        public string adresa
        {
            get; set;
        }
        public string nationalitate
        {
            get; set;
         }
        public string nr_telefon
        {
            get;set; }
        public  string sex
        {
            get; set;
         }
        public Pasager()
        {
            id_pasager = 0;
            nume = prenume = adresa = nationalitate = nr_telefon = sex = string.Empty;
          
        }
        public Pasager(int id_pasager, string nume, string prenume, string adresa, string nationalitate, string nr_telefon, string sex)
        {
            this.id_pasager = id_pasager;
            this.nume = nume;
            this.prenume = prenume;
            this.adresa = adresa;
            this.nationalitate = nationalitate;
            this.nr_telefon = nr_telefon;
            this.sex = sex;

        }
        public Pasager(string liniefisier)
        {
            string[] date_fisier = liniefisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            this.id_pasager = Convert.ToInt32(date_fisier[ID]);
            this.nume = date_fisier[NUME];
            this.prenume = date_fisier[PRENUME];
            this.adresa = date_fisier[ADRESA];
            this.nationalitate = date_fisier[NATIONALITATE];
            this.nr_telefon = date_fisier[NR_TEL];
            this.sex = date_fisier[SEX];
        }
        public string ConversieFisierText()
        {
            string date_f = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}",

                SEPARATOR_PRINCIPAL_FISIER,
                id_pasager.ToString(),
                (nume ?? "NECUNOSCUT"),
                (prenume ?? "NECUNOSCUT"),
                (adresa ?? "NECUNOSCUTA"),
                (nationalitate ?? "NECUNOSCUTA"),
                (nr_telefon ?? "NECUNOSCUT"),
                (sex ?? "NECUNOSCUT"));
            return date_f;
        }
        public int getIDP()
        {
            return id_pasager;
        }
        public string GetNumeP()
        {
            return nume;
        }
        public string GetPrenumeP()
        {
            return prenume;
        }
        public string GetAdresaP()
        {
            return adresa;
        }
        public string GetNationalitateaP()
        {
            return nationalitate;
        }
        public string GetNr_TelP()
        {
            return nr_telefon;
        }
        public string GetSexP()
        {
            return sex;
        }


    }
}
