using System;

namespace Clase_Tren
{
    public class Train
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const int ID = 0;
        private const int NUME = 1;
        private const int CAPACITATE = 2;
        private const int STATUS = 3;

        public int id_tren { get; set; }
        public string nume { get; set; }
        public int capacitate { get; set; }
        public string status {  get; set; }

        public Train()

        {
            id_tren = 0;
            this.nume = string.Empty;
            capacitate = 0;
            status = string.Empty;
        }
        public Train(int id_tren, string nume, int capacitate, string status)
        {
            this.id_tren = id_tren;
            this.nume = nume;
            this.capacitate = capacitate;
            this.status = status;
        }
        public Train(string liniefisier)
        {
            string[] date_fisier = liniefisier.Split(SEPARATOR_PRINCIPAL_FISIER);
            this.id_tren = Convert.ToInt32(date_fisier[ID]);
            this.nume = date_fisier[NUME];
            this.capacitate = Convert.ToInt32(date_fisier[CAPACITATE]);
            this.status = date_fisier[STATUS];
            
        }

        public string ConversieFisierText()
        {
            string date_f = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                id_tren.ToString(),
                (nume ?? "NECUNOSCUT"),
                (capacitate.ToString() ?? "NECUNOSCUT"),
                (status.ToString() ?? "NECUNOSCUT")); 
            return date_f;
        }
        public int getIDT()
        {
            return id_tren;
        }
        public string GetNUMET()
        {
            return nume;
        }

        public int GetCapacityT()
        {
            return capacitate;
        }
        public string GetStatusT()
        {
            return status;
        }
    }
}
