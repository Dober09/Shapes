using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    
    public abstract class Shape
    {
        public const double PI = Math.PI;  
        private double w { get; set; }
        private double x {  get; set; }
        private double y { get; set; }
        private double z { get; set; }
        public Shape() : this(0, 0, 0, 0) { }

        public Shape(double w, double x, double y, double z) {
            this.w = w;
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public abstract double Area();

        public virtual double SurfaceArea()
        {
            return 0;
        }
    }

}
