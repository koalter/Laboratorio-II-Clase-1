using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<int> numeros = new List<int>();
            Queue<int> queue = new Queue<int>();
            Stack<int> positivos = new Stack<int>();
            Stack<int> negativos = new Stack<int>();
            int signo;
            const int length = 20;

            Console.WriteLine("a. Mostrar el vector tal como fue ingresado");
            for (int i = 0; i < length; i++)
            {
                int num = rand.Next() + 1;
                signo = rand.Next(2);
                if (signo == 0)
                {
                    num *= -1;
                }
                numeros.Add(num);
                Console.WriteLine(num);
            }
            Console.WriteLine("");
            Console.WriteLine("b. Luego mostrar los positivos ordenados en forma decreciente.");
            foreach (int item in numeros)
            {

            }
            Console.WriteLine("");
            Console.WriteLine("c. Por último, mostrar los negativos ordenados en forma creciente.");
            foreach (int n in numeros)
            {
                if (n < 0)
                {
                    Console.WriteLine(n);
                }
            }

            Console.ReadKey();
        }
    }
}
