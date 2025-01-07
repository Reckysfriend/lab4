namespace lab4
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> listOfPeople = new List<Person>();
            Hair hair = new Hair("long", "blue", "stright");
            Person person = new Person(Genders.Nonbinary,hair,DateTime.Today,"red");
            Console.WriteLine(person);
        }
    }
   

}
