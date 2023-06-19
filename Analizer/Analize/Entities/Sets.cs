using System.Collections.Generic;

namespace Analizer.Entities
{
    internal class Sets
    {
        public static List<CsvProperty> TrainingRaw { get; set; } = new List<CsvProperty>();
        public static List<CsvProperty> TestingRaw { get; set; } = new List<CsvProperty>();
        public static List<CsvProperty> StoppingRaw { get; set; } = new List<CsvProperty>();
        public static List<NormalizedProperty> StoppingNorm { get; set; } = new List<NormalizedProperty>();
        public static List<NormalizedProperty> TrainingNorm { get; set; } = new List<NormalizedProperty>();
        public static List<NormalizedProperty> TestingNorm { get; set; } = new List<NormalizedProperty>(); 
    }
}
