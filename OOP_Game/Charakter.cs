using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Game
{
    class Charakter
    {
        private int shield;
        private int health;
        private int damage;

        public string Name { get; }
        public int Health { get => health; }
        public int Shield { get => shield; }
        public int Damage { get => damage; }

        public Charakter (string name)
        {
            Name = name;
            health = 100;
            shield = 50;
            damage = 20;
        }

        public void GetHit(int damage)
        {           
            {
                shield -= damage;
                if(shield < 0)
                {
                    health += shield;
                    shield = 0;
                }
            }                    
        }
        public void Heal()
        {
            health += 15;
        }
        public override string ToString()
        {
            string text = "Name: " + Name + "\n";
            text += "Health: " + Health + "\n";
            text += "Shield: " + shield + "\n";
            text += "Damage: " + Damage + "\n";
            return text;
        }
    }
}
