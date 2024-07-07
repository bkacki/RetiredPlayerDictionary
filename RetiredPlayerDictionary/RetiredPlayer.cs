using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetiredPlayerDictionary
{
    internal class RetiredPlayer
    {
        public string Name { get; private set; }
        public int YearRetired { get; private set; }

        public RetiredPlayer(string player, int yearRetired)
        {
            Name = player;
            YearRetired = yearRetired;
        }
    }
}
