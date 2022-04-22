using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mms_ernet_мы_так_усталиии
{
    class Program
    {
        static void Main(string[] args)
        {

            Character hero = new Character("Player", 50, 20);
            Character npc = new Character("Enemy", 20, 30);


            Console.WriteLine($"Hero's health: {hero.Health} | Hero is alive: {hero.IsAlive}");
             hero.Health = 0;
             Console.WriteLine($"Hero's health: {hero.Health} | Hero is alive: {hero.IsAlive}");


             string command = string.Empty;

             while (command != "exit")
             {
                 Console.WriteLine($"You are at [{hero.x}, { hero.y}]. Where to go?");
                 command = Console.ReadLine();

                 hero.Move(command);
             }


             bool collide = hero.Collide(npc);

             if (collide)
             {
                 Console.WriteLine("Objects are on the same position.");
             }
             else
             {
                 Console.WriteLine("Objects are not on the same position.");
             }
             
             Console.ReadKey();
        }
    }
}
