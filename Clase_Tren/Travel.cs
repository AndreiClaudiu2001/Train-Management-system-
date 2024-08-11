using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_Tren
{
    public class Travel
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const int ID = 0;
        private const int DATA = 1;
        private const int ORA = 2;
        private const int ID_TREN = 3;
        private const int PLECARE = 4;
        private const int SOSIRE = 5;
        private const int COST = 6;
        public int id_travel { get; set; }
        public string data
        {
            get; set;
         }
        public string ora
        {
            get; set;
         }
        
        public int id_tren
        {
            get; set;
         }
        public string plecare { get; set; }
        public string destinatie
        {
            get; set;
         }
        public int cost_calatorie
        {
            get; set;
         }

        public Travel()
        {
            data = "NULL";
            ora = "NULL";
            id_travel = 0;
            id_tren = 0;
            plecare = "NULL";
            destinatie = "NULL";
            cost_calatorie = 0;
        }
        public Travel(int id_travel, string data,string ora, int id_tren, string plecare, string destinatie, int cost_calatorie)
        {
            this.id_travel = id_travel;
            this.data = data;
            this.ora = ora;
            this.id_tren = id_tren;
            this.plecare = plecare;
            this.destinatie = destinatie;
            this.cost_calatorie = cost_calatorie;

        }
        public Travel(string liniefisier)
        {
            string[] date_fisier = liniefisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            this.id_travel = Convert.ToInt32(date_fisier[ID]);
            this.data = date_fisier[DATA];
            this.ora = date_fisier[ORA];
            this.id_tren = Convert.ToInt32(date_fisier[ID_TREN]);
            this.plecare = date_fisier[PLECARE];
            this.destinatie = date_fisier[SOSIRE];
            this.cost_calatorie = Convert.ToInt32(date_fisier[COST]);

        }
        public string ConversieFisierText()
        {
            string date_f = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                id_travel.ToString(),
                (data ?? "NECUNOSCUT"),
                (ora ?? "NECUNOSCUT"),
                id_tren.ToString(),
                (plecare ?? "NECUNOSCUT"),
                (destinatie ?? "NECUNOSCUT"),
                 cost_calatorie.ToString());
            return date_f;
        }
        public int GetIDTravel()
        { return id_travel; }

        public string GetData()
        {
            return data;
        }
        public string GetOra()
        {
            return ora;
        }

        public int GetIDtren()
        {
            return id_tren;
        }

        public string GetPlecare()
        {
            return plecare;
        }
        public string GetSosire()
        {
            return destinatie;

        }
        public int GetCost()
        { return cost_calatorie;
        }
    }

}
