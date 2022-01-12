using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossFight
{
    internal class GameCharacter
    {
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Stamina { get; set; }
        public int MaxHealth { get; set; }
        public int MaxStamina { get; set; }

        public GameCharacter(int health, int strength,int stamina)
        {
            Health = health;
            Strength = strength;
            MaxHealth = health;
            MaxStamina = stamina;
            Stamina = stamina;
        }















    }

}


