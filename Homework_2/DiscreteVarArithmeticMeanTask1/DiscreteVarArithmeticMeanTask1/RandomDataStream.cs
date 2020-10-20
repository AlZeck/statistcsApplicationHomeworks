using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscreteVarArithmeticMeanTask1
{
    class RandomDataStream
    {
        public RandomDataStream(int start, int end, String unitName, String attributeName, RandForm form, int limit) 
        {
            this.start = start;
            this.end = end;
            this.unitName = unitName;
            this.attributeName = attributeName;
            this.form = form;
            this.average = 0;
            this.unitCounter = 0;
            this.random = new Random();
            this.limit = limit;
            this.distribution = new Dictionary<int, container>();
            if( limit < 0 && limit != -1)
            {
                throw new FormatException("Check limit must be a positive integer or -1 for infinite");
            }
            this.form.ResetDistribution();
            for (int x = start; x<end; x++)
            {
                this.distribution.Add(x, new container());
                this.form.UpdateDistribution(String.Format("{0}\t{1}", x, this.distribution[x].ToString()));
            }
        }

       
        private int generateRandom() {
            return this.random.Next(this.start, this.end);
        }


        public void next()
        {
            if (limit == -1 || unitCounter <= limit)
            {
                int current = generateRandom();
                this.unitCounter++;
                this.average = this.average + (current - this.average) / this.unitCounter;
                this.updateDistribution(current);
                this.updateForm(current);
            }
            else
                this.form.stop();
        }

        public void updateForm(int last)
        {
            this.form.updateInfo(unitName + unitCounter + ": " + last);
            this.form.updateAverage( this.average );
        }

        public void updateDistribution(int last)
        {
            this.form.ResetDistribution();
            this.distribution[last].count++;
            for (int x = start; x < end; x++)
            {
                this.distribution[x].updateFrequency(this.unitCounter);
                this.form.UpdateDistribution(String.Format("{0}\t{1}",x,this.distribution[x].ToString()));
            }
            this.form.UpdateDistribution("\nTotal "+this.unitName+": "+this.unitCounter);
        }
        public double getAvg()
        {
            return this.average;
        }

        private Random random;
        private int start;
        private int end;
        private String attributeName;
        private String unitName;
        private RandForm form;
        private double average;
        private int unitCounter;
        private Dictionary<int, container> distribution;
        private int step;
        private int limit;
    }

    class container
    {
        public int count;
        public double frequency;
        public double percentage;

        public container()
        {
            count = 0;
            frequency = 0;
            percentage = 0;
        }

        public void updateFrequency(int n)
        {
            frequency = ((double) count) / n;
            percentage = ((double)count) / n * 100.0; 
        }

        override public string ToString()
        {
            return String.Format("{0}\t{1,0:F3}\t\t{2,0:F2}%", count,frequency,percentage);
        }
    }

}

