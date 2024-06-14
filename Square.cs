using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

    /// <summary>
    ///     <para>
    ///         Representation of Square Shape
    ///     </para>
    /// </summary>
    public class Square : Shape
    {

        /// <summary>
        ///     <para>
        ///         Representation of Square Shape
        ///     </para>
        ///     <par>
        ///          Provides methods for calculating Area
        ///      </par>
        /// </summary>
        /// <param name="side">side</param>
        public Square(double side) : base(side , 0,0,0) {
            this.W = side;
        }

        public override double Area()
        {
            return Math.Pow(base.W,2);
        }

        public override string ToString()
        {
            return $"Square Area : {Area():F2}";
        }

    }
}
