using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public struct Hair
    {
        // Make fields public or provide properties to access them
        public string HairLength;
        public string HairColor;
        public string HairType;

        // Constructor to initialize the fields
        public Hair(string hairLength, string hairColor, string hairType)
        {
            HairLength = hairLength;
            HairColor = hairColor;
            HairType = hairType;
        }
        public override string ToString()
        {
            return $"Hair Length: {HairLength}, Hair Color: {HairColor}, Hair Type: {HairType}";
        }
    }
}