using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    /// <summary>
    ///     <para>
    ///         Representation of Rectangle Shape
    ///     </para>
    /// </summary>
    public class Triangle : Shape
    {

        /// <summary>
        ///     <para>
        ///         Representation of Rectangle Shape
        ///     </para>
        ///     <para>
        ///         Provides methods for calculating Area
        ///     </para>
        /// </summary>
        /// <param name="base">base</param>
        /// <param name="height">height</param>
        public Triangle(double @base ,double height):base(@base,height,0,0) {
           this.W = @base;
            this.X = height;
           
        }

        public override double Area()
        {
            return 0.5 * base.W * base.X;
        }

        public override string ToString()
        {
            return  $"Triangle Area : {Area():F2}";
        }
    }
}
