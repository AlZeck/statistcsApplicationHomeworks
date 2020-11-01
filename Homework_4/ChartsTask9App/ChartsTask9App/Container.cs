using System;
using System.Security.Cryptography;

namespace ChartsTask9App
{
    public class Container
    {
        public int Count { get; private set; }
        public double Frequency { get; private set; }

        public Container()
        {
            Count = 0;
            Frequency = 0;
        }


        public double Avg { get; private set; }


        public void updateAvg( double entry )
        {
            Count++;
            Avg += (entry - Avg) / Count;
        }

        public override string ToString()
        {
            return String.Format("{0}\t{1,0:F2}\t{1,0:P2}", Count, Frequency);
        }

        public void UpdateFrequency(int total)
        {
            Frequency = ((double)this.Count) / total;
        }
    }
}
