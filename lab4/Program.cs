namespace lab4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hair hair = new Hair("long", "blue", "stright");
            Person person = new Person(Genders.Nonbinary,hair,DateTime.Today,"red");
            Console.WriteLine(person);
        }
    }
   

}
