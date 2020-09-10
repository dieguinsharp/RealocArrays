using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realocando_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array inicializado com apenas uma posição.
            int[] test = new int[0];

            Console.Write("Deseja executar o loop de testes quantas vezes?");
            int qtd = Convert.ToInt32(Console.ReadLine());

            for (int x = 0; x < qtd; x++)
            {
                test = Realoc.Size(ref test, x);
                Console.WriteLine("Posição: " + x);
                Console.WriteLine("Tamanho da array: " + test.Length);
            }

            foreach (int i in test)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
