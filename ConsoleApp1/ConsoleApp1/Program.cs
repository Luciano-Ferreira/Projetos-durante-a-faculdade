using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Par
    {
        int a; float b;
        public Par(int a)
        {
            this.a = a;
            b = 0;
        }
        public Par(int a, float b)
        {
            this.a = a;
            this.b = b;
        }
    }
    public class Teste
    {
        public static void Main(String[] args)
        {
            int x = 5; float y = 7; double z = 10.3;
            Par p = new Par(1,1);
            Console.WriteLine(p);
        }
    }
}

