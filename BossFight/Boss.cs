using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossFight
{
    internal class Boss : GameCharacter
    {

        public static Random random = new();
        
        public Boss() : base(400, random.Next(0, 31),10)
        {
        }
        public void Fight(Hero hero)
        {
            
            if (Stamina == 0)
            {
                Recharge();
            }
            else
            {
                hero.Health -= Strength;
                Stamina -= 10;
                
                Console.WriteLine("Boss does {0} dmg to Hero - Stamina left: {1} - Health left: {2}\n", Strength,Stamina,Health);
            }

            
        }
        public void Recharge()
        {
            Stamina = MaxStamina;
            Console.WriteLine("Boss Restores his Stamina");
        }
    }
}
