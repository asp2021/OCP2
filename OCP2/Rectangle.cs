using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP2
{
    class Rectangle: IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public string Area()
        {
            return "Rectangulo: " + Width * Height;
        }
    }
}
