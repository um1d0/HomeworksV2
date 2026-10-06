using System;
using System.Collections.Generic;
using System.Text;

namespace HW_3
{
    internal class Mage : GameCharacter
    {
        override public void Attack()
        {
            Console.WriteLine($"Mage {Name} attacks with fireball!");
        }
        override public void Defend()
        {
            Console.WriteLine($"Mage {Name} creates a magic shield!");
        }
        public bool Mana { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Health: {Health}, Level: {Level}, Mana: {Mana}");
        }
    }
}
