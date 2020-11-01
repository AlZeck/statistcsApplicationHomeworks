using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartsTask9App
{
    public class Distribution
    {
        public int Step { get; }
        public int Start { get; }
        public int End { get; }
        public int Count { get; private set; }
        public double Avg { get; private set; }
        public Dictionary<Interval, Container> Dist { get; private set; }


        public Distribution(int start, int end, int step)
        {
            this.Start = start;
            this.End = end;
            this.Step = step;

            this.Dist = new Dictionary<Interval, Container>();
            this.Avg = 0;
            this.Count = 0;

            for (int x = Start; x < End; x += Step)
            {
                this.Dist.Add(new Interval(x, this), new Container());
            }

        }

        public void Update(double entry)
        {
            this.Count++;

            Avg += (entry - Avg) / this.Count;

            this.Dist[new Interval(entry, this)].updateAvg(entry);
            foreach (Interval key in Dist.Keys)
            {
                this.Dist[key].UpdateFrequency(this.Count);
            }
        }

        public override string ToString()
        {
            string ret = "Interval\tCount\tFreq\tPerc\n";

            foreach (Interval key in Dist.Keys)
            {
                ret += String.Format("{0}\t{1}\n", key, Dist[key]);
            }

            return ret;
        }
    }
}
