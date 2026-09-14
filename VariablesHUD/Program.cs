using System;

namespace VariablesHUD
{
    //int -whole numbers
    //float -
    //string -"words you use" array of characters
    //char -A,B,1,2,$,%
    //bool -true/false
    //var ???

    public class Program
    {
        //Declaration
        static string gameName = "Game Name !";
        static int health = 100;
        static int lives = 3;
        

        static void Main()
        {
            //Console.WriteLine(health);
            HUD();
            Console.ReadKey();
            //Console.Clear();

            lives = 2;
            health = 60;
            HUD();
            Console.ReadKey();
            //Console.Clear();

            lives = 1;
            health = 40;
            HUD();
            Console.ReadKey();
            //Console.Clear();

            lives = 0;
            health = 0;
            HUD();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You Died :(");
            Console.ReadKey();
            //Console.Clear();
        }

        static void HUD()
        {
            Console.WriteLine("-----------");
            //game title
            Console.WriteLine(gameName);
            Console.WriteLine("");
            //Health
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Health:" + health);
            Console.WriteLine("");
            //Lives
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Lives:" + lives);
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}