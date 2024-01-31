using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerchio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cerchio n = new Cerchio();
            Console.WriteLine("Quanto vale il raggio?");
            n.Raggio=double.Parse(Console.ReadLine());

            Console.WriteLine("Il raggio del cherchio = {0}", n.ToString());
            Console.ReadLine();

        }
    }
}
