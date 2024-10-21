using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class Triangle : Shape
    {
        private double bases;
        private double height;
        private double side;

        public Triangle(double bases, double height, double side)
        {
            this.bases = bases;
            this.height = height;
            this.side = side;
        }

        public double getArea()
        {
            return 0.5 * bases * height;
        }

        public double getPerimeter()
        {
            return bases + height + side;
        }
    }
}
