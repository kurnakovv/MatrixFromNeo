using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MatrixFromNeo
{
    public static class Messeges
    {
        public static void Print<T>(this IEnumerable<T> list)
        {
            foreach (var item in list)
            {
                Console.Write(item);
                Thread.Sleep(300);
            }
            Thread.Sleep(1000);
            Console.WriteLine();
            Console.Clear();
        }

    }
}
