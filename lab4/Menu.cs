namespace lab4
{
    public class Menu
    {
        public void GoToMenu()
        {
            Person person = new Person();
            bool menu = true;
            while (menu)
            {
                Console.WriteLine("\t\n Evil Evesdrop Enterprises Counterespionage\n\n\t[1] Create person\n\t[2] Show all people\n\t[3] Quit");
                Int32.TryParse(Console.ReadLine(), out int menuchoice);
                switch (menuchoice)
                {
                    case 1:
                        menu = false;
                        person.Addperson();
                        break;
                    case 2:
                        menu = false;
                        person.ListPersons();
                        break;
                    case 3:
                        menu = false;
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
