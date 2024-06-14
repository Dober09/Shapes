using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Circle : Area
    {
        double pi = Math.PI;
        public double getArea(double s)
        {

            return 6 * s * s;

        }

    }
}
