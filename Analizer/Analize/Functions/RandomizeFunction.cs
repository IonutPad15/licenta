

using Analizer.Entities;
using System;
using System.Collections.Generic;

namespace Analizer.Functions
{
    public class RandomizeFunction
    {
        public static List<NormalizedProperty> Randomize()
        {
            Random random = new Random();
            List<NormalizedProperty> normalizedProperties = new List<NormalizedProperty>();
            while(Sets.TrainingNorm.Count > 0)
            {
                int index = random.Next(Sets.TrainingNorm.Count);
                normalizedProperties.Add(Sets.TrainingNorm[index]);
                Sets.TrainingNorm.RemoveAt(index);
            }
            return normalizedProperties;
        }
    }
}
