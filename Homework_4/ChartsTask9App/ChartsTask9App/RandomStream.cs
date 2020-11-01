using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartsTask9App
{
    class RandomStream
    {
        private int start;
        private int end;
        private Random rand;
        public double Next()
        {
            return rand.Next(this.start, this.end) + rand.NextDouble();
        }

        public RandomStream(int start, int end)
        {
            this.start = start;
            this.end = end;
            this.rand = new Random(); 
        }
    }
}
