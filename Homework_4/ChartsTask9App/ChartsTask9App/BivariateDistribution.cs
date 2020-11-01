using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace ChartsTask9App
{
    public class BivariateDistribution
    {
        public int StepX { get; }
        public int StartX { get; }
        public int EndX { get; }
        public int StepY { get; }
        public int StartY { get; }
        public int EndY { get; }

        public int Count { get; private set; }

        public List<Interval> IntX { get; private set; }
        public List<Interval> IntY { get; private set; }

        public List<List<int>> Matrix;


        public BivariateDistribution(int startx, int endx, int stepx, int starty, int endy, int stepy)
        {
            this.StartX = startx;
            this.EndX = endx;
            this.StepX = stepx;

            this.StartY = starty;
            this.EndY = endy;
            this.StepY = stepy;

            Count = 0;

            IntX = new List<Interval>();
            IntY = new List<Interval>();

            Matrix = new List<List<int>>();

            for (int x = StartX; x < EndX; x += StepX)
            {
                IntX.Add(new Interval(x, StartX, StepX));
            }
            for (int y = StartY; y < EndY; y += StepY)
            {
                IntY.Add(new Interval(y, StartY, StepY));
            }

            for (int y = 0; y < IntY.Count; y++)
            {
                Matrix.Add(new List<int>());
                for (int x = 0; x < IntX.Count; x++)
                {
                    Matrix[y].Add(0);
                }
            }

        }

        public void Update(double x, double y)
        {
            int indx = new Interval(x, StartX, StepX).Id;
            int indy = new Interval(y, StartY, StepY).Id;

            Count++;

            Matrix[indy][indx] += 1;
        }

        public int GetMarginal(Variable v, int interval_id)
        {
            int sum = 0;
            if (v == Variable.X)
            {
                for (int y = 0; y < IntY.Count; y++)
                {
                    sum += Matrix[y][interval_id];
                }
            }
            else if (v == Variable.Y )
            {
                for (int x = 0; x < IntX.Count; x++)
                {
                    sum += Matrix[interval_id][x];
                }
            }
            return sum; 
        }

    }

    public enum Variable { X, Y }
}