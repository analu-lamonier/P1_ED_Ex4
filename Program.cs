using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caProvaEx4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int Soma(int[] vetor, int t)
            {
                if (t == 0)
                    return 0;
                else
                    return vetor[t - 1] + Soma(vetor, t - 1);
            }

            int[] vet = new int[] { 1, 2, 3, 4, 5, 6 };


            int res = Soma(vet, 6);

            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
