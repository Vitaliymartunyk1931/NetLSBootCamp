using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerWork
{
    public class ItemSize
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }

        public ItemSize(double height, double width, double depth)
        {
            Height = height;
            Width = width;
            Depth = depth;
        }
    }
}