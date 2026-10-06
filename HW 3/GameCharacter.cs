using System;
using System.Collections.Generic;
using System.Text;

namespace HW_3
{
    internal abstract class GameCharacter
    {
        public string Name { get; set; }
		private int _health;

		public int Health
        {
			get { return _health; }
			set { if (value > 0) { 
					_health = value;
                } }
		}
        private int _level;

        public int Level
        {
            get { return _level; }
            set
            {
                if (value > 0)
                {
                    _level = value;
                }
            }
        }
        abstract public void Attack();
        abstract public void Defend();

        


    }
}
