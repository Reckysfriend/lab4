namespace lab4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Genders myGender = Genders.Nonbinary;
            Console.WriteLine(myGender.ToString());
            Hair myHair = new Hair("10cm", "blå", "curly");
            Console.WriteLine(myHair.ToString());
            Person myBirthday = new Person();
            myBirthday.Birthday = "1925-06-13";
            Console.WriteLine(myBirthday.Birthday);
            Person myEyeColor = new Person();
            myEyeColor.EyeColor = "blå";
            Console.WriteLine(myEyeColor.EyeColor);
        }
    }
    public class Person
    {
        public Genders CurrentGender { get; set; }
        public Hair CurrentHair { get; set; }
        private string birthday;
        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        private string eyeColor;
        public string EyeColor
        {
            get { return eyeColor; }
            set { eyeColor = value; }
        }
    }
}
