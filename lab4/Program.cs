namespace lab4
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Debug finns för att snabbt kunna generera personer för att kolla listan.
            bool runDebug = true;
            Debug debug = new Debug();
            if (runDebug)
            {
                debug.RunDebug();
            }
            //Skapar en refernce till vår Menu klass och kör funktionen som tar oss
            //Till vår huvudmeny. 
            Menu menu = new Menu();
            menu.GoToMenu();

        } 
    }
} 
    
        
    