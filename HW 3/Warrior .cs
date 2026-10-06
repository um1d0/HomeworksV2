using System;
using System.Collections.Generic;
using System.Text;

namespace HW_3
{
    internal class Warrior : GameCharacter
    {

        override public void Attack()
        {
            Console.WriteLine($"Warrior {Name} attacks with a sword!");
        }
        override public void Defend()
        {
            Console.WriteLine($"Warrior {Name} blocks the attack with shield!");
        }
        public bool Armor { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Health: {Health}, Level: {Level}, Armor: {Armor}");
        }
    }
}
