using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cerchio
{
    internal class Cerchio
    {
        public double Raggio { get; set; }

        public override string ToString()
        {
            return string.Format("{0}", Raggio);
        }

        public static Cerchio Parse(string s)
        {
            Cerchio cerchio = new Cerchio();
            cerchio.Raggio = int.Parse(s);
            return cerchio;
        }
    }
}
