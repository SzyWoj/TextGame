using System;
namespace TextGame
{
    class Program
    {
        public static Player currentPlayer = new Player();
        public static Ecounters ecounters = new Ecounters();

        static void Main(string[] args)
        {
            Start();
            ecounters.FirstEcounter();
        }

        static void Start()
        {
            Console.WriteLine("RPG Game!");
            Console.Write("Name:");
            currentPlayer.name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You awake in a cold, stone dark room. You feel dazed and are having trouble remembering");
            if (string.IsNullOrEmpty(currentPlayer.name))
                Console.WriteLine("You can't even remember your own name...");
            else
                Console.WriteLine("anything about your past. You know your name is " + currentPlayer.name);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You grope around in the darkness until you find a door handle. You feel some resistance as");
            Console.WriteLine("you turn the handle, but rusty lock breaks with little effort. You see your captor");
            Console.WriteLine("standing with his back to outside the door");

        }
    }
}
