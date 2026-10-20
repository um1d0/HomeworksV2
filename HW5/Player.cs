using System;
using System.Collections.Generic;
using System.Text;

namespace HW5
{
    internal class Player : IComparable<Player>
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public int CompareTo(Player? Score)
        {
            throw new NotImplementedException();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
