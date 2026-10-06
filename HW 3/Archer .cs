using System;
using System.Collections.Generic;
using System.Text;

namespace HW_3
{
    internal class Archer : GameCharacter
    {
        override public void Attack()
        {
            Console.WriteLine($"Archer {Name} attacks with bow!");
        }
        override public void Defend()
        {
            Console.WriteLine($"Archer {Name} dodges the attack!");
        }
        public bool Arrows { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Health: {Health}, Level: {Level}, Arrows: {Arrows}");
        }
    }
}
