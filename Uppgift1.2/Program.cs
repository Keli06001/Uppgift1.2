using System;

    namespace uppgift1_2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.WriteLine("An error has occured. To continue:");
            Console.WriteLine("Press Enter to return to Windows, or");
            Console.WriteLine("Press CTRL+ALT+DEL to restart your computer. If you do this,");
            Console.WriteLine("you will lose any unsaved information in all open applications");
            Console.WriteLine("Error: 0E  :  016F  :  BFF9K3D4");
            Console.ReadKey();
        }
    }
   
}