using System;
using System.Collections.Generic;
using System.Linq;

namespace Analizer
{
    public class GlobalInput
    {
        public static double Value(List<Entry> entries, GICode code)
        {
            switch (code)
            {
                case GICode.Suma:
                    return Sum(entries);
                case GICode.Produs:
                    return Product(entries);
                case GICode.Min:
                    return Min(entries);
                case GICode.Max:
                    return Max(entries);
                default:
                    throw new Exception("Not good");
            }
        }
        private static double Sum(List<Entry> entries)
        {
            double sum = 0;
            foreach (var entry in entries)
            {
                sum += entry.X.Value * entry.W;
            }
            return sum;
        }
        private static double Product(List<Entry> entries)
        {
            double prod = 1;
            foreach (var entry in entries)
            {
                prod = prod * entry.X.Value * entry.W;
            }
            return prod;
        }
        private static double Min(List<Entry> entries)
        {
            var first = entries.First();
            double min = first.X.Value * first.W;
            foreach (var entry in entries.Skip(1))
            {
                var result = entry.X.Value * entry.W;
                if (result < min) min = result;

            }
            return min;
        }
        private static double Max(List<Entry> entries)
        {
            var first = entries.First();
            double max = first.X.Value * first.W;
            foreach (var entry in entries.Skip(1))
            {
                var result = entry.X.Value * entry.W;
                if (result > max) max = result;

            }
            return max;
        }
    }
    
    public enum GICode
    {
        Suma ,
        Produs ,
        Min ,
        Max 
    }
}
