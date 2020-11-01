namespace ChartsTask9App
{
    internal class BiDimInterval
    {
        private int startx;
        private int endx;

        private int starty;
        private int endy;

        private int idx;
        private int idy;

        public BiDimInterval(double x, double y, BivariateDistribution distribution)
        {
            idx = (int)(x - distribution.StartX) / distribution.StepX;
            idy = (int)(y - distribution.StartY) / distribution.StepY;
            startx = distribution.StepX * idx;
            endx = startx + distribution.StepX;
            starty = distribution.StepY * idy;
            endy = starty + distribution.StepY;
        }

        public override bool Equals(object obj)
        {
            return obj is BiDimInterval interval &&
                   startx == interval.startx &&
                   endx == interval.endx &&
                   idx == interval.idx &&
                   starty == interval.starty &&
                   endy == interval.endy &&
                   idy == interval.idy;
        }

        public override int GetHashCode()
        {
            return idx*1000+idy;
        }

    }
}
