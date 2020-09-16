using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Rational
    {
        public int numerator;
        public int denumarator;
   
        public Rational (int numerator,int denumarator)
        {
            this.denumarator = denumarator;
            this.numerator = numerator;
        }
        public Rational Cut(Rational result)
        {
            int res = result.numerator;
            int resznam = result.denumarator;

            while (res != resznam)
            {
                if (res > resznam)
                {
                    res = res - resznam;
                }
                else
                {
                    resznam = resznam - res;
                }
            }

            int nod = resznam;
            if (nod == 0)
                nod = 1;
            Rational result2 = new Rational(result.numerator / nod, result.denumarator / nod);
            return result2;
        }

        public static Rational operator +(Rational x, Rational y)
        {
            return x.Sum(y);
        }

        public static Rational operator -(Rational x, Rational y)
        {
            return x.Subtr(y);
        }

        public static Rational operator *(Rational x, Rational y)
        {
            return x.Multip(y);
        }

        public static Rational operator /(Rational x, Rational y)
        {
            return x.Divis(y);
        }

        public string Tostring(Rational result)
        {
            string resultre;
            
            if (result.denumarator!=0 && result.numerator % result.denumarator == 0)
            {
                int re = result.numerator / result.denumarator;
                resultre = Convert.ToString(re);
            }
            else
                resultre = Convert.ToString(result.numerator + "/" + result.denumarator);
            return resultre;
        }

        public Rational Sum(Rational other)
        {
            int resznam = 0;
            int resch = 0;
                resznam = this.denumarator * other.denumarator;
                resch = this.numerator * other.denumarator + other.numerator * this.denumarator;
                Rational result = new Rational(resch, resznam);
                return Cut(result);
        }

        public Rational Subtr(Rational other)
        {
            int resznam = 0;
            int resch = 0;
            resznam = this.denumarator * other.denumarator;
            resch = this.numerator * other.denumarator - other.numerator * this.denumarator;
                      Rational result = new Rational(resch, resznam);
            return Cut(result);
             
        }

        public Rational Multip(Rational other)
        {
            int resznam = 0;
            int resch = 0;
            resznam = this.denumarator * other.denumarator;
            resch = this.numerator * other.numerator;
            Rational result = new Rational(resch, resznam);
            return Cut(result);
            
        }

        public Rational Divis(Rational other)
        {
            int resznam = 0;
            int resch = 0;
            resznam = this.denumarator * other.numerator;
            resch = this.numerator * other.denumarator;
            Rational result = new Rational(resch, resznam);
            return Cut(result);
        }
    }
}
