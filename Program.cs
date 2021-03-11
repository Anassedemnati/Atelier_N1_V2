using System;

namespace Atelier_N1_Se_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // creation client Anasse
            Client Anasse = new Client("Demnati", "Anasse", "Lot dhaini n9");
            Anasse.print();
            MAD sal_anasse = new MAD(1000);
            // creation Compte du Client Anasse
            Compte C_anasse = new Compte(sal_anasse,ref Anasse);
            C_anasse.print_info();
            // creation client Mohamed
            Client Zamori = new Client("Zamouri", "Mohamed", "lot dashra n15");
            MAD sal_Zamori = new MAD(20000);
            // creation Compte du Client Mohamed
            Compte C_Zamori = new Compte(sal_Zamori, ref Zamori);
            C_Zamori.print_info();
            MAD val = new MAD(100);
            //debiter le Compte du client anasse par 100 
            Console.WriteLine("debiter le Compte du client anasse par 100");
            C_anasse.Debiter(val);
            C_anasse.print_info();
            //crediter le Compte du client anasse par 100
            Console.WriteLine("crediter le Compte du client anasse par 100");
            C_anasse.crediter(val);
            C_anasse.print_info();
            // vairement du compte du client Zamouri ver le client Anasse valeur 100
            Console.WriteLine("vairement du compte du client Zamouri ver le client Anasse valeur 100");
            C_Zamori.vairement(C_anasse, val);
            C_Zamori.print_info();
            
        }
    }
}
