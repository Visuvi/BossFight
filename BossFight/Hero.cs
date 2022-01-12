using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace BossFight
{
    internal class Hero : GameCharacter
    {
        public Hero() : base(100,20,40)
        {
        }
        public void Fight(Boss boss)
        {
            if (Stamina == 0)
            {
                Recharge();
            }
            else
            {
                boss.Health -= Strength;
                Stamina -= 10;
                Console.WriteLine("Hero does {0}" + " dmg to Boss -  Stamina left: {1} -  Health left: {2}\n", Strength, Stamina, Health);            }
        }
        public void Recharge()
        {
            Stamina = MaxStamina;
            Console.WriteLine("Hero Recharges his Stamina");
        }
    }
}
