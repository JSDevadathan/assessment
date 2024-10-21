using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double getArea()
        {
            return Math.PI * radius * radius;
        }

        public double getPerimeter()
        {
            return 2 * 3.14 * radius;
        }
    }


}
