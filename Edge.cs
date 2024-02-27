using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellmanFord
{
    public class Edge
    {
        public int Source, Destination, Weight;
        public Edge()
        {
            Source = Destination = Weight = 0;
        }
    }
}
