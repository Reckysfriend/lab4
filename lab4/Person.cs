using System.ComponentModel;

namespace lab4
{
    public class Person
    {
        //Deklarerar alla våra properties samt referenser. 
        public Genders Gender { get; private set; }
        public Hair Hair { get; private set; }
        public DateTime Birthday { get; private set; }
        public string EyeColor { get; private set; }
        public string Name { get; private set; }
        Menu mainMenu = new Menu();
        //Skapar en konstruktor som är till för att skapa en person med alla
        //dess olika värden.
        public Person(Genders gender, Hair hair, DateTime birthday, string eyecolor, string name)
        {
            Gender = gender;
            Hair = hair;
            Birthday = birthday;
            EyeColor = eyecolor;
            Name = name;
        }
        //En sekunder konstruktor som bara används när vi behöver skapa en 
        //referens till funktionerna inom vår Person klass. 
        public Person() { }
        public void Addperson()
        {
            int birthYear = 0;
            int birthMonth = 0;
            int birthDay = 0;
            double hairLength = 0;
            bool subMenu = true;
            Console.Clear();
            //Tar in anvädarens förnamn
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.Clear();
            //Tar in användarens efternamn
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            Console.Clear();
            //Tar in användarens kön från en meny då vi referar till vår
            //enum som håller könen. 
            Console.WriteLine("What is your Gender?");
            Genders gender = 0;
            bool menu = true;
            while (menu)
            {
                Console.WriteLine($"[1]Woman\n[2]Man\n[3]Nonbinary\n[4]Other\n");
                Int32.TryParse(Console.ReadLine(), out int menuChoice);
                switch (menuChoice)
                {
                    case 1:
                        gender = Genders.Woman;
                        Console.Clear();
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
            //Tar in anvädarens hårtyp
            Console.WriteLine("What is your hairtype? (ex: Wavy, Curly)");
            string hairType = Console.ReadLine();
            Console.Clear();
            //Tar in användarens hårfärg
            Console.WriteLine("What is your hair colour?");
            string hairColour = Console.ReadLine();
            Console.Clear();
            //Tar in användarens hårlängd i cm
            subMenu = true;
            while (subMenu)
            {
                Console.WriteLine("How long is your hair? (in cm)");
                Double.TryParse(Console.ReadLine(), out hairLength);
                if ( hairLength >= 0.1) 
                {
                    Console.Clear();
                    subMenu = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Please enter a valid value for your hair length");
                }
            }
           
            Console.Clear();        
            menu = true;
            subMenu = true;

            while (menu)
            {
                //Loopar tills anändaren har givit ett giltigt år.
                while (subMenu)
                {
                    Console.WriteLine("Enter the year you were born: (ex: 1998)");
                    Int32.TryParse(Console.ReadLine(), out birthYear);
                    if (birthYear >= 1925 && birthYear <= 2025)
                    {
                        Console.Clear();
                        subMenu = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"{birthYear} is not a real month, please enter a valid year");
                    }
                }
                subMenu = true;
                //Loopar tills användaren har givit en gilltig månad. 
                while (subMenu)
                {
                    Console.WriteLine("Enter the month you were born: (ex: 11)");
                    Int32.TryParse(Console.ReadLine(), out birthMonth);
                    if (birthMonth >= 1 && birthMonth <= 12)
                    {
                        Console.Clear();
                        subMenu = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"{birthMonth} is not a real month, please enter a valid month");
                    }
                }
                //Använder sig av DateTime för att hålla hur många dagar det fanns på
                //den månad och år som användaren skrivit in.
                int daysInMonth = DateTime.DaysInMonth(birthYear, birthMonth);
                subMenu = true;
                while (subMenu)
                {
                    Console.WriteLine("Enter the day you were born: (ex: 20)");
                    Int32.TryParse(Console.ReadLine(), out birthDay);
                    if (birthDay >= 1 && birthDay <= daysInMonth)
                    {
                        //Då det här är det sista steget och har användaren skrivit rätt här är det klart
                        //så avslutar vi båda looparna. 
                        Console.Clear();
                        subMenu = false;
                        menu = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"{birthDay} is not an existing day in {birthMonth} in {birthYear}, please enter a valid date");
                    }
                }
            }
            
            //Deklarerar och instansierar en DateTime variabel som håller användarens givna värden.
            DateTime birthday = new DateTime(birthYear, birthMonth, birthDay);
            Console.Clear();
            //Tar in anvädarens ögonfärg. 
            Console.WriteLine("What is your Eyecolour?");
            string eyeColour = Console.ReadLine();
            //Skapar en hår variabel med hjälp av dens konstruktor med värdena givet av användaren. 
            Hair hair = new Hair(hairLength.ToString(), hairColour, hairType);
            //Sätter ihop för och efternamn till en variabel. 
            string name = $"{firstName} {lastName}";
            //Skapar vår person med hjälp av alla givna värden.
            Person person = new Person(gender, hair, birthday, eyeColour, name);
            //Lägger en skapar personen i våran lista.
            ListOfPeople.listOfPeople.Add(person);
            Console.Clear();
            //Återgår till huvudmenyn. 
            mainMenu.GoToMenu();
        }
        //En override som även tar in overriden från Hair klasssen samt formaterar om
        //våran DateTime till ett år-mån-day format. 
        public override string ToString()
        {
            return $"--------------------\n" +
                $"{Name} ({Gender})\nBorn: {Birthday.ToString("yyyy-MM-dd")}{Hair}\nEyecolor: {EyeColor}\n" +
                $"--------------------";
        }

    }
}