using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUP
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            foreach(int v in a)
            {
                
                Console.WriteLine(v);
            }
            for(int i=0; i< a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
