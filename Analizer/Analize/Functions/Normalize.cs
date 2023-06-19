namespace Analizer
{
    public class Normalize
    {
        public static double Start(double value,double rawMin, double rawMax, double min, double max)
        {
            if(rawMin == min && rawMax == max)
            {
                return value;
            }
            if (rawMin == rawMax) return 1;
            //if(rawMin == min)
            double m = (min - max) / (rawMin - rawMax);
            double n = (rawMin * max - rawMax * min) / (rawMin - rawMax);
            return m * value + n;
        }
    }
}
