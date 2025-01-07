namespace lab4
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool runDebug = true;
            Debug debug = new Debug();
            if (runDebug)
            {
                debug.RunDebug();
            }
            Menu menu = new Menu();
            menu.GoToMenu();

        } 
    }
} 
    
        
    