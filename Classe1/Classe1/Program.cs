using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe1
{
    public class Classe1
    {
        public float d1;

        public Classe1(float p)
        {
            this.d1 = p;
        }
        public void metodo1(float m, float n)
        {
            d1 *= (m + n);
        }
        public void metodo1(float m)
        {
            this.metodo1(m, m);
            d1 *= m;
        }
        public void metodo1()
        {
            this.metodo1(this.d1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Classe1 c1 = new Classe1(3);
            c1.metodo1();
            Console.WriteLine(c1.d1);
        }
    }
}
