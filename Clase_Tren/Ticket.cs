using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_Tren
{
    public class Ticket
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const int ID_BILET = 1;
        private const int ID_PERSOANA = 1;
        private const int ID_CALATORIE = 2;
        public int id_bilet { get; set; }
        public int id_travel { get; set; }
        public int id_persoana
        {
            get; set;
         }

        public Ticket()
        {
            id_bilet = 0;
            id_travel = 0;
            id_persoana = 0;
        }
        public Ticket(int id_bilet,int id_travel, int id_persoana)
        {
            this.id_bilet = id_bilet;
            this.id_persoana = id_persoana;
            this.id_travel = id_travel;
        }
        public Ticket(string liniefisier)
        {
            string[] date_fisier = liniefisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            this.id_bilet = Convert.ToInt32(date_fisier[ID_BILET]);
            this.id_persoana = Convert.ToInt32(date_fisier[ID_PERSOANA]);
            this.id_travel = Convert.ToInt32(date_fisier[ID_CALATORIE]);
            

        }
        public string ConversieFisierText()
        {
            string date_f = string.Format("{1}{0}{2}{0}{3}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                id_bilet.ToString(),
                id_travel.ToString(),
                id_persoana.ToString());


            return date_f;
        }
        public int GetIDBilet()
        { return id_bilet; }
        public int GetIDTravel()
        { return id_travel; }

        public int GetIDPersoana()
        {
            return id_persoana;
        }
    }
}

