using System;

namespace TextGame
{
    class Ecounters
    {
        Random random = new Random();

        //Ecounters
        public void FirstEcounter()
        {
            Console.WriteLine("You throw open door and grab a rusty metal sword, while charging toward your captor");
            Console.WriteLine("He turns...");
            Console.ReadKey();
            Combat("Human Rouge", 1, 4);
        }

        //Ecounter Tools
        public void Combat(string name, int power, int health)
        {
            int h = health;

            while (h > 0 && Program.currentPlayer.health > 0)
            {
                Console.Clear();
                Console.WriteLine(name);
                Console.WriteLine(power + "/" + h);
                Console.WriteLine("====================== ");
                Console.WriteLine("| (A)ttack (D)efend  |");
                Console.WriteLine("|  (R)un     (H)eal  |");
                Console.WriteLine("====================== ");
                Console.WriteLine(" Potions: " + Program.currentPlayer.potion + "  Health  " + Program.currentPlayer.health);
                string input = Console.ReadLine();

                if (input.ToLower() == "a" || input.ToLower() == "attack")
                {
                    //Attack
                    Console.WriteLine("With haste you surge forth, your sword flying in your hands! As you pass, the " + name + " strikes you as pass");
                    int damage = power - Program.currentPlayer.armorValue;
                    if (damage < 0)
                        damage = 0;
                    int attack = random.Next(0, Program.currentPlayer.weaponValue) + random.Next(1, 4);
                    Console.WriteLine("You lose " + damage + " health and deal " + attack + " damage");
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    //Defend
                    Console.WriteLine("As the " + name + " prepares to strike, you ready your sword in a defensive stance!");
                    int damage = (power / 4) - Program.currentPlayer.armorValue;
                    if (damage < 0)
                        damage = 0;
                    int attack = random.Next(0, Program.currentPlayer.weaponValue) / 2;
                    Console.WriteLine("You lose " + damage + " health and deal " + attack + " damage");
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "r" || input.ToLower() == "run")
                {
                    //Run
                    if (random.Next(0, 2) == 0)
                    {
                        Console.WriteLine("As you sprint away from the " + name + ", its strike catches you in the back, sending you sprawling to the ground");
                        int damage = power - Program.currentPlayer.armorValue;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("You lose " + damage + " health and are unable to escape.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("You use your crazy ninja moves to evade the " + name + " and successfully escape!");
                        Console.ReadKey();
                        //go to store
                    }
                }
                else if (input.ToLower() == "h" || input.ToLower() == "heal")
                {
                    //Heal
                    if (Program.currentPlayer.potion == 0)
                    {
                        Console.WriteLine("As you desperately grasp for a potion in your bag, all that you feel are empty glass flasks");
                        int damage = power - Program.currentPlayer.armorValue;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("The " + name + " strikes you with a mighty blow and you lose " + damage + " health!");
                    }
                    else
                    {
                        Console.WriteLine("You reach into your bag and pull out a glowing, purple flask. You take a drink.");
                        int potionV = 5;
                        Console.WriteLine("You gain " + potionV + " health");
                        Program.currentPlayer.health += potionV;
                        Console.WriteLine("As you were occupied, t " + name + " advanced and struck.");
                        int damage = (power / 2) - Program.currentPlayer.armorValue;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("You lose " + damage + " health.");
                    }
                    Console.ReadKey();
                }
                Console.ReadKey();
            }
        }
    }
}