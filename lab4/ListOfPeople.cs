namespace lab4
{
    internal class ListOfPeople
    {
        //Den statiska listan som där alla personer lagras från funktioner.
        public static List<Person> listOfPeople = new List<Person>();
        Menu menu = new Menu();
        //Funktions som går egenom hela listan av Personern och skriver ut dem med 
        //hjälp av våra ToString overrides. 
        public void ListPersons()
        {
            foreach (Person person in ListOfPeople.listOfPeople)
            {
                Console.WriteLine(person);
            }
            //Skapar en paus så att användaren kan kolla egenom listan innan
            //dom går tillbaka till huvudmenyn. 
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
            Console.Clear();
            menu.GoToMenu();

        }
    }

}
