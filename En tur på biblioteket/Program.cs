using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace En_tur_på_biblioteket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Books libary = new Books();
            libary.Generate();
            libary.UI();
        }
    }
}
