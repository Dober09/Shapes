using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    /// <summary>
    ///     <para>
    ///          Representation of Rectangle Shape
    ///     </para>
    /// </summary>
    public class Rectangle : Shape
    {
        /// <summary>
        ///         <para>
        ///             Representation of Rectangle Shape
        ///         </para>
        ///         <par>
        ///              Provides methods for calculating Area
        ///         </par>
        /// </summary>
        /// <param name="legnth">Legnth</param>
        /// <param name="width">Width</param>
        public Rectangle(double legnth,double width) : base(legnth,width,0,0) {
            this.W = legnth;
            this.X = width;
        }
        public override double Area()
        {
            return base.W * base.X;
        }


        public override string ToString()
        {
            return $"Rectangle Area : {Area():F2}";
        }
    }
}
