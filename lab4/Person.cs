using System.ComponentModel;

namespace lab4
{
    public class Person
    {
        public Genders Gender { get; private set; }
        public Hair Hair { get; private set; }
        public DateTime Birthday { get; private set; }
        public string EyeColor { get; private set; }
        public string Name { get; private set; }
        Menu mainMenu = new Menu();
        public Person(Genders gender, Hair hair, DateTime birthday, string eyecolor, string name)
        {
            Gender = gender;
            Hair = hair;
            Birthday = birthday;
            EyeColor = eyecolor;
            Name = name;
        }
        public Person() { } 
        public void Addperson()
        {
            Console.Clear();
            Console.WriteLine("What is your first name");
            string firstName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What is your last name");
            string lastName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What is your Gender");
            Genders gender = 0;
            bool menu = true;
            while (menu) 
            {
                Console.WriteLine($"[1]Woman\n[2]Man\n[3]Nonbinary\n[4]Other\n");
                Int32.TryParse(Console.ReadLine(),out int menuChoice);
                switch (menuChoice) 
                {
                    case 1:
                        gender = Genders.Woman;
                        Console.Clear ();
                        menu = false;
                        break;
                    case 2:
                        gender = Genders.Man;
                        Console.Clear();
                        menu = false;
                        break;
                    case 3:
                        gender = Genders.Nonbinary;
                        Console.Clear();
                        menu = false;   
                        break;
                    case 4:
                        gender = Genders.Other;
                        Console.Clear();
                        menu = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please enter a valid input");
                        break;
                }
            }
            Console.WriteLine("What is your hairtype");
            string hairType = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("What is your haircolour");
            string hairColour = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("How long is your hair");
            string hairLength = Console.ReadLine();
            Console.Clear();
            int birthYear = 0;
            int birthMonth = 0;
            int birthDay = 0;
            menu = true;
            while (menu)
            {
                Console.WriteLine("Enter the year you were born");
                Int32.TryParse(Console.ReadLine(), out birthYear);
                if (birthYear >= 1925 && birthYear <= 2025)
                {
                    Console.Clear();
                    menu = false; 
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"{birthYear} is not a real month, please enter a valid year");
                }
            }
            menu = true;
            while (menu)
            {
                Console.WriteLine("Enter the month you were born");
                Int32.TryParse(Console.ReadLine(), out birthMonth);
                if (birthMonth >= 1 && birthMonth <= 12) 
                {
                    Console.Clear();
                    menu = false; 
                }
                else 
                {
                    Console.Clear();
                    Console.WriteLine($"{birthMonth} is not a real month, please enter a valid month"); 
                }
            }
            menu = true;
            while (menu)
            {
                Console.WriteLine("Enter the day you were born");
                Int32.TryParse(Console.ReadLine(), out birthDay);
                if (birthDay >= 1 && birthDay <= 31)
                {
                    Console.Clear();
                    menu = false; 
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"{birthDay} is not a real day, please enter a valid date");
                }
            }
            DateTime birthday = new DateTime(birthYear, birthMonth, birthDay);
            Console.Clear();
            Console.WriteLine("What is your Eyecolour");
            string eyeColour = Console.ReadLine();
            Hair hair = new Hair(hairLength, hairColour, hairType);
            string name = $"{firstName} {lastName}";
            Person person = new Person(gender, hair, birthday, eyeColour, name);
            ListOfPeople.listOfPeople.Add(person);
            Console.Clear();
            mainMenu.GoToMenu();
        }       
        public override string ToString()
        {
            return $"--------------------\n" +
                $"{Name} ({Gender})\nBorn: {Birthday.ToString("yyyy-MM-dd")}{Hair}\nEyecolor: {EyeColor}\n" +
                $"--------------------";
        }

    }
}
