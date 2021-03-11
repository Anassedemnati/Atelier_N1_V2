using System;
using System.Collections.Generic;
using System.Text;

namespace Atelier_N1_Se_2
{
    class MAD
    {
        private double valeur;
       
        public MAD(double va)
        {
            this.valeur = va;
        }
        public void print()
        {
            Console.WriteLine(this.valeur+" MAD ");
        }
        public static MAD operator +(MAD n1, MAD n2)
        {
            MAD res = new MAD(0.0);
            res.valeur = n1.valeur + n2.valeur;
            return res;
        }
        public static bool operator >(MAD n1, MAD n2)
        {
            if (n1.valeur > n2.valeur)
            {
                return true;
            }
            else return false;
        }
        public static bool operator <(MAD n1, MAD n2)
        {
            if (n1.valeur < n2.valeur)
            {
                return true;
            }
            else return false;
        }

        public static MAD operator -(MAD n1, MAD n2)
        {
            MAD res = new MAD(0.0);
            res.valeur = n1.valeur - n2.valeur;
            return res;
        }

    }
}
