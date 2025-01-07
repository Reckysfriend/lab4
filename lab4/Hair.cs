namespace lab4
{
    public struct Hair
    {
        //Instansierar våra properties.
        public string HairLength {  get; private set; }
        public string HairColor { get; private set; }
        public string HairType { get; private set; }

        //Skapar en simple konstruktor som tar in ett värde för alla våra
        //properties. 
        public Hair(string hairLength, string hairColor, string hairType)
        {
            HairLength = hairLength;
            HairColor = hairColor;
            HairType = hairType;
        }
        //Använder oss av en override för att lättare kunna skriva ut 
        //hår information när den samspelar med vår Person klass.
        public override string ToString()
        {
            return $"\nHair Length: {HairLength}cm \nHair Color: {HairColor} \nHair Type: {HairType}";
        }
    }
}