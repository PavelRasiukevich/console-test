using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initial
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int[] PointToMove { get; set; }

        public Point()
        {
            PointToMove = new int[2];
        }
    }
}
