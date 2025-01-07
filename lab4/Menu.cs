namespace lab4
{
    public class Menu
    {
        public void GoToMenu()
        {
            //Skapar referenser för dom klassar vars funktioner
            //vi behöver nå från våran meny. 
            Person person = new Person();
            ListOfPeople listOfPeople = new ListOfPeople();
            //Startar en loop som går tills anändaren väljer att avsluta
            //programmet eller går till en annan funktion. 
            bool menu = true;
            while (menu)
            {
                Console.WriteLine("\t\n Evil Evesdrop Enterprises Counterespionage\n\n\t[1] Create person\n\t[2] Show all people\n\t[3] Quit");
                Int32.TryParse(Console.ReadLine(), out int menuchoice);
                switch (menuchoice)
                {
                    case 1:
                        menu = false;
                        //Tar oss till funktionen som låter oss
                        //skapa en ny person
                        person.Addperson();
                        break;
                    case 2:
                        menu = false;
                        //Skriver ut listan av alla personer vi skapat
                        listOfPeople.ListPersons();
                        break;
                    case 3:
                        menu = false;
                        //Avslutar programmet. 
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Please enter a valid menu choice");
                        break;
                }
            }
        }
        
    }
}
