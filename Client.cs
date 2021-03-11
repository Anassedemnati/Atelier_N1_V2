using System;
using System.Collections.Generic;
using System.Text;

namespace Atelier_N1_Se_2
{
    class Client
    {
        private string nom;
        private string prenom;
        private string adresse;


        public Client(string nom, string pre, string adr)
        {
            this.nom = nom;
            this.prenom = pre;
            this.adresse = adr;
        }
        public void print()
        {
            Console.WriteLine("le nom :" + this.nom + " le prenom : " + this.prenom + " l'adresse " + this.adresse);
        }











    }
}
