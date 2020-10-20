using System.Drawing.Text;
using System.Windows.Forms;

namespace ContinuousVarArithmeticMeanTask2
{
    class Interval
    {
        private int start;
        private int end; 


        private int id;
        public Interval(double cur, Distribution distribution)
        {
            id = (int)(cur - distribution.Start) / distribution.Step;
            start = distribution.Step * id;
            end = start + distribution.Step;
        }

        public override bool Equals(object obj)
        {
            return obj is Interval interval &&
                   start == interval.start &&
                   end == interval.end &&
                   id == interval.id;
        }

        public override int GetHashCode()
        {
            return id;
        }

        
        public override string ToString()
        {
            return string.Format("[{0},{1})",start,end);
        }

    }
}
