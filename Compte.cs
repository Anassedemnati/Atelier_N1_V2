using System;
using System.Collections.Generic;
using System.Text;


namespace Atelier_N1_Se_2
{
    class Compte
    {
        
        private Int32 num_compte;
        private static Int32 cpt_campte = 0;
        
        private Client Titulaire;
        private MAD Solde;
        private static readonly MAD plafond = new MAD(2000);
        
        
        
        public Compte(MAD so,ref Client cl)
        {
            this.Solde = so;
            this.Titulaire = cl;
            this.num_compte = ++cpt_campte;
            


        }
       
        public void print_info()
        {
            Console.WriteLine("numero du compte : " + this.num_compte );
            Titulaire.print();
            Solde.print();
        }
        public bool crediter(MAD sum)
        {
            MAD test = new MAD(0);
            if (sum > test)
            {
                this.Solde = this.Solde+sum;
                return true;

            }
            else return false;
              
        }
        public bool Debiter(MAD sum)
        {
            MAD test = new MAD(0);
            if (sum > test)
            {
                if (sum < Compte.plafond)
                {
                    this.Solde -= sum;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
        public  bool vairement( Compte P2cr, MAD val)
        {
            return (this.Debiter(val) && P2cr.crediter(val));
            

        }


    }

}
