using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP2
{
    public class AreaCalculator
    {

        public string Area(List<IShape> shapes)
        {
            string area = "";
            foreach (var shape in shapes)
            {
                area += shape.Area();

                area += Environment.NewLine;
            }
            return area;
        }
    }
}
