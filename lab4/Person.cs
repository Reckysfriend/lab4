namespace lab4
{
    public class Person
    {
        public Genders Gender { get; private set; }
        public Hair Hair { get; private set; }
        public DateTime Birthday { get; private set; }
        public string EyeColor { get; private set; }

        public Person(Genders gender, Hair hair, DateTime birthday, string eyecolor)
        {
            Gender = gender;
            Hair = hair;
            Birthday = birthday;
            EyeColor = eyecolor;
        }


        public override string ToString()
        {
            return $"Gender: {Gender},\n{Hair},\nBirthday: {Birthday},\nEyecolor: {EyeColor}";
        }

    }
}
