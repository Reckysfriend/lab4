using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class ListOfPeople
    {
        public static List<Person> listOfPeople = new List<Person>();
        Menu menu = new Menu();
        public void ListPersons()
        {
            foreach (Person person in ListOfPeople.listOfPeople)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
            Console.Clear();
            menu.GoToMenu();

        }
    }

}
