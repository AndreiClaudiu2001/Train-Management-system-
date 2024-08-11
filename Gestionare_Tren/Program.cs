using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Administrare_Fisier;
using Clase_Tren;
using System.IO;
using System.Configuration;

namespace Gestionare_Tren
{
    class Program
    {
        static void Main(string[] args)
        {
            string datePasager = ConfigurationManager.AppSettings.Get("datePasager");

            Date_Fisier_Pasager adminPasageri = new Date_Fisier_Pasager(datePasager);

            string dateTren = ConfigurationManager.AppSettings.Get("dateTren");
            Date_Fisier_Tren adminTrenuri = new Date_Fisier_Tren(dateTren);

            int nrPasageri, id_pasageri; 
            int nrTrenuri, id_trenuri;
            string nume, prenume,adresa,nationalitatea,nr_tel,sex;
          
            string optiune;
            do
            {

                //Console.Clear();
                Console.WriteLine("PF. Afisare pasageri din fisier");
                Console.WriteLine("PS. Salvare pasageri in fisier");
                Console.WriteLine("PC. Citire date pasager de la tastatura");
                Console.WriteLine("PL. Cauta pasager dupa nume.");
                Console.WriteLine("------------------------------");
                Console.WriteLine("TF. Afisare trenuri din fisier");
                Console.WriteLine("TS. Salvare trenuri in fisier");
                Console.WriteLine("TC. Citire date tren de la tastatura");
                Console.WriteLine("TL. Cauta trenurile disponibile ");
                Console.WriteLine("------------------------------");
                Console.WriteLine("X. Inchidere program");
                Console.Write("Alegeti o optiune: ");
                optiune = Console.ReadLine();
                adminPasageri.GetPasagers(out nrPasageri);
                adminTrenuri.GetTrains(out nrTrenuri);
                switch (optiune.ToUpper())
            {
                case "PF":

                    Pasager[] pasageri = adminPasageri.GetPasagers(out nrPasageri);
                    afisarePasager(pasageri, nrPasageri);
                    break;

                case "PS":

                    id_pasageri = nrPasageri + 1;
                    nrPasageri=nrPasageri+1;
                    Pasager pasager = new Pasager(id_pasageri, "Luca", "Alin", "Botosani", "Romania", "0732334123", "M");
                    adminPasageri.AddPassager(pasager);
                    break;
                    case "PC":

                        id_pasageri = nrPasageri + 1;
                        nrPasageri = nrPasageri + 1;
                        Console.Write("Introduceti numele: ");
                        nume = Console.ReadLine();
                        Console.Write("Introduceti prenumele: ");
                        prenume = Console.ReadLine();
                        Console.Write("Introduceti adresa: ");
                        adresa = Console.ReadLine();
                        Console.Write("Introduceti nationalitatea: ");
                        nationalitatea = Console.ReadLine();
                        Console.Write("Introduceti numarul de telefon: ");
                        nr_tel = Console.ReadLine();
                        Console.Write("Introduceti sexul: ");
                        sex = Console.ReadLine();
                        Pasager pasager_tastatura = new Pasager(id_pasageri, nume, prenume, adresa, nationalitatea, nr_tel, sex);
                        adminPasageri.AddPassager(pasager_tastatura);
                        break;

                    case "PL":

                        Console.Write("Dati numele pasagerului cautat: ");
                        nume = Console.ReadLine();
                        Console.Write("Dati prenumele pasagerului cautat: ");
                        prenume = Console.ReadLine();

                        Pasager pasager_cautat = adminPasageri.GetPasager(nume, prenume);
                        if (string.IsNullOrEmpty(pasager_cautat.GetNumeP()) && string.IsNullOrEmpty(pasager_cautat.GetPrenumeP()))
                            Console.WriteLine("Nu exista pasagerul in baza de date\n");
                        else
                        {
                            string info_pasager_cautat = string.Format("Pasagerul cu numele {1} {2} are id-ul {0}\n",
                                pasager_cautat.getIDP(), pasager_cautat.GetNumeP(), pasager_cautat.GetPrenumeP());
                            Console.WriteLine(info_pasager_cautat);
                        }
                        break;
                    case "TF":
                        Train[] trenuri = adminTrenuri.GetTrains(out nrTrenuri);
                        afisareTrenuri(trenuri, nrTrenuri);
                        break;
                    case "TS":
                        id_trenuri = nrTrenuri + 1;
                        nrTrenuri = nrTrenuri + 1;
                        Train tren = new Train(id_trenuri, "InterRegio",200, "Liber");
                        adminTrenuri.AddTren(tren);

                        break;
                    case "TC":
                        id_trenuri = nrTrenuri + 1;
                        nrTrenuri = nrTrenuri + 1;
                        Console.WriteLine("Introduceti numele trenului(InterRegio/Regio/InterCity): ");
                        string numet = Console.ReadLine();
                        Console.WriteLine("Introduceti capacitatea trenului: ");
                        int capacitate = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Statusul trenului este(true/false): ");
                        string status= Console.ReadLine();
                        Train tren_tastatura = new Train(id_trenuri, "Regio",capacitate, status);
                        adminTrenuri.AddTren(tren_tastatura);
                        break;
                    case "TL":
                        Console.WriteLine("Trenurile disponibile sunt:\n");
                        Train[] trenuri_s= adminTrenuri.GetTrains(out nrTrenuri);
                        
                        for(int i=0;i<nrTrenuri;i++)
                        {
                            if (trenuri_s[i].GetStatusT() == "Liber")
                            {
                                string infoTren = string.Format("Trenul cu id-ul #{0} este: {1} {2} {3} \n",
                                           trenuri_s[i].getIDT(),
                                              trenuri_s[i].GetNUMET(),
                                              trenuri_s[i].GetCapacityT(),
                                              trenuri_s[i].GetStatusT());

                                Console.WriteLine(infoTren);
                            }
                        }   
                       
                      break;


                    case "X":

                    return;

                default:

                    Console.WriteLine("Nu exista aceasta optiune, va rug selectati o optiune valida\n");
                    break;

            }
        }
            while (optiune.ToUpper() != "X");
            
            Console.ReadKey();
        }
        public static void afisarePasager(Pasager[] pasager, int nrPasager)
        {
            Console.WriteLine("Pasagerii sunt: ");
            for (int contor = 0; contor < nrPasager; contor++)
            {
                string infoPasager = string.Format("Pasagerul cu id-ul #{0} este: {1} {2} {3} {4} {5} {6}",
                    pasager[contor].getIDP(),
                    pasager[contor].GetNumeP(),
                    pasager[contor].GetPrenumeP(),
                    pasager[contor].GetAdresaP(),
                    pasager[contor].GetNationalitateaP(),
                    pasager[contor].GetNr_TelP(),
                    pasager[contor].GetSexP());
                Console.WriteLine(infoPasager);
            }
        }
        public static void afisareTrenuri(Train[] tren, int nrTrenuri)
        {
            Console.WriteLine("Trenurile sunt: ");
            for (int contor = 0; contor < nrTrenuri; contor++)
            {
                string infoTren = string.Format("Trenul cu id-ul #{0} este: {1} {2} {3} ",
                    tren[contor].getIDT(),
                    tren[contor].GetNUMET(),
                    tren[contor].GetCapacityT(),
                    tren[contor].GetStatusT()); ;

                Console.WriteLine(infoTren);
            }
        }
      

    }
}
