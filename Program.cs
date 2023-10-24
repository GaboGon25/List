using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CPunto> listaPuntos = new List<CPunto>();

            listaPuntos.Add(new CPunto(2, 0)); 
            listaPuntos.Add(new CPunto(1, 7)); 
            listaPuntos.Add(new CPunto(2, 9));
            listaPuntos.Add(new CPunto(6, 3));
            listaPuntos.Add(new CPunto(9, 1));
            
            foreach (var lp in listaPuntos)
            {
                Console.WriteLine(lp);

            }

            Console.WriteLine("---------------------------------------------------------------------");

            listaPuntos.Insert(2, new CPunto(1, 1));
            
            foreach(var lp in listaPuntos)
            {
                Console.WriteLine(lp);
            }


        }
        
    }
}

