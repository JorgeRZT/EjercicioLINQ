using System;
using System.Collections.Generic;
using System.Linq;

namespace EjercicioLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista1 = new List<int>()
            {
                1,2,3,4,5,6,7,8
            };

            var lista2 = new List<int>()
            {
                1,4,3
            };

            Metodo3(lista2, lista1);

            Console.ReadLine();
        }

        private static void Metodo3(List<int> lista1, List<int> lista2)
        {
            if(lista1 == null || lista2 == null)
            {
                throw new Exception("No puede haber listas vacias");
            }

            var consulta = from n in lista1 join m in lista2 on n equals m select m;
            Console.WriteLine(string.Join(",", consulta.ToList()));
        }
      
    }
}