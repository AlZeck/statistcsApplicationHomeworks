using System;
using System.Security.Cryptography;

namespace ContinuousVarArithmeticMeanTask2
{
    class Container
    {
        private int Count;
        private double Frequency; 

        public Container()
        {
            Count = 0;
            Frequency = 0;
        }

        public void IncrementCount()
        {
            Count++;
        }
        
        public override string ToString()
        {
            return String.Format("{0}\t{1,0:F2}\t{1,0:P2}", Count, Frequency);
        }

        public void UpdateFrequency(int total)
        {
            Frequency = ((double) this.Count) / total;
        }
    }
}
