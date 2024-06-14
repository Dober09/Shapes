using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    /// <summary>
    ///     <para>
    ///          Representation of Tripezium Shape
    ///     </para>
    /// </summary>
    public class Tripezium : Shape
    {
        /// <summary>
        ///     <para>
        ///         Representation of Tripezium Shape
        ///     </para>
        ///     <para>
        ///         Provides methods for calculating Area
        ///     </para>
        ///     
        /// </summary>
        /// <param name="sideA">sideA</param>
        /// <param name="sideB">SideB</param>
        /// <param name="height">height</param>
        public Tripezium(double sideA,double sideB, double height):base(sideA,sideB,height,0) { 
            this.W = sideA;
            this.X= sideB;
            this.Y= height;
        
        }
        public override double Area()
        {
            return 0.5 * (base.W + base.X) * base.Y;
        }

        public override string ToString()
        {
            return $"Tripezium Area : {Area():F2}";
        }
    }
}
