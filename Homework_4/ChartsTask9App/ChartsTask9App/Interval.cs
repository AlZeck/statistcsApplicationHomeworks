using System.Drawing.Text;
using System.Windows.Forms;

namespace ChartsTask9App
{
    public class Interval
    {
        public int Start { get; private set; }
        public int End { get; private set; }

        public int Id { get; private set; }
        public Interval(double cur, Distribution distribution)
        {
            Id = (int)(cur - distribution.Start) / distribution.Step;
            Start = distribution.Step * Id;
            End = Start + distribution.Step;
        }

        public Interval(double cur, int start, int step)
        {
            Id = (int)(cur - start) / step;
            Start = step * Id;
            End = Start + step;
        }


        public override bool Equals(object obj)
        {
            return obj is Interval interval &&
                   Start == interval.Start &&
                   End == interval.End &&
                   Id == interval.Id;
        }

        public override int GetHashCode()
        {
            return Id;
        }

        
        public override string ToString()
        {
            return string.Format("[{0},{1})",Start,End);
        }

    }
}
