using System;

class Program
{
public static Random rng = new();

    static void Main()
    {
    int playerHP = 30;
    int enemyHP = 20;
    int potions = 2;
    int maxHP = 30;
   
   

    Console.WriteLine("You meet a wild Bear!🐻");

    while (playerHP > 0 && enemyHP > 0) 
        {
           Console.WriteLine($"\nYou HP: {playerHP} | Bear HP: {enemyHP}");
           Console.WriteLine("Choose: (a)ttack or (h)eal:");
           string choice = (Console.ReadLine() ?? "").Trim().ToLower();

           if (choice == "a")
            {
               int dmg = rng.Next(3, 9); 
               enemyHP -= dmg;
               Console.WriteLine($"You hit the racked Bear for {dmg}");
            }
            else if (choice == "h")
            {
                if (potions > 0)
           
            {
                int heal = rng.Next(4, 10);
                playerHP += heal;
                potions--;

                if (playerHP > maxHP)
                {
                playerHP = maxHP;
                }
                bool reachedMax = playerHP == maxHP;

                Console.WriteLine($"You are bandaging ur wounds +{heal} HP (potions left: {potions})");

                if (reachedMax)
                    {
                        Console.WriteLine($"MaxHP reached");
                    }
            }
            else
            {
                Console.WriteLine("Zero potions left");
                continue;
              }
            }
            if ( enemyHP <= 0) break;

            int enemyDamage = rng.Next(7, 10);
            playerHP -= enemyDamage;

            Console.WriteLine($"Bear slashes you for {enemyDamage}");

        }

        Console.WriteLine(playerHP > 0 ? "\n 🥇You win!" : "\n 🐻You got murdered");
    }

}



    

