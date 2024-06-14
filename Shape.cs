using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    /// <summary>
    ///     <para>
    ///         Representation of all Shapes
    ///     </para>
    /// </summary>
    public abstract class Shape
    {
        public const double PI = Math.PI;

        public double W,X,Y,Z;

        public Shape() : this(0, 0, 0, 0) { }
        /// <summary>
        ///     Required parameter that must be provided
        /// </summary>
        /// <param name="w">W</param>
        /// <param name="x">X</param>
        /// <param name="y">Y</param>
        /// <param name="z">Z</param>
        public Shape(double w, double x, double y, double z) {
            this.W = w;
            this.X= x;
            this.Y = y;
            this.Z = z;
        }

       
        /// <summary>
        ///     method that must be defined in each shape
        /// </summary>
        /// <returns>The area of the shape</returns>
        public abstract double Area();

        public virtual double SurfaceArea()
        {
            return 0;
        }
    }

}
