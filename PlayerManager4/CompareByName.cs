using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager4
{
    public class CompareByName : IComparer<Player>
    {
        private bool order;
        public CompareByName(bool order)
        {
            this.order = order;
        }
        public int Compare(Player player, Player other)
        {
            if (order == false)
            {
                return -string.Compare(player.Name,other.Name);
            }
            else
            {
                return string.Compare(player.Name,other.Name);
            }
            
        }
    }
}