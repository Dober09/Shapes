using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Tripezium : Area
    {

        public double getArea(double a, double b, double h)
        {

            return 0.5 * (a + b) * h;

        }

    }
}
