using System;

namespace Analizer
{
    public class CsvAttribute : Attribute
    {
        public const char DefaultDelimiter = ',';
        public char Delimiter { get; set; }

        public CsvAttribute(char delimiter = DefaultDelimiter)
        {
            Delimiter = delimiter;
        }
    }
}
