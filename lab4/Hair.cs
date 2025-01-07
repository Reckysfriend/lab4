namespace lab4
{
    public struct Hair
    {
        public string HairLength;
        public string HairColor;
        public string HairType;

        public Hair(string hairLength, string hairColor, string hairType)
        {
            HairLength = hairLength;
            HairColor = hairColor;
            HairType = hairType;
        }
        public override string ToString()
        {
            return $"\nHair Length: {HairLength}, \nHair Color: {HairColor}, \nHair Type: {HairType}";
        }
    }
}