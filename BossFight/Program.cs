using System;
using System.Threading.Tasks;

namespace BossFight
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            
            var boss = new Boss();
            Console.WriteLine("The Boss starts with: " + boss.Health + " Health.");

            var hero = new Hero();
            Console.WriteLine("The Hero starts with " + hero.Health + " Health.");
            Console.WriteLine("FIGHT!");

            while (hero.Health > 0 && boss.Health > 0)
            {

                hero.Fight(boss);
                boss.Fight(hero);
                await Task.Delay(1000);
            }
            if (boss.Health <= 0)
            {
                Console.WriteLine("Boss died");
            }
            if (hero.Health <= 0)
            {
                Console.WriteLine("Hero died");
            }
            
        }
    }
}
