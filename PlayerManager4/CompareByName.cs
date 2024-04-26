using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager4
{
    public class CompareByName : IComparer<Player>
    {
        public CompareByName(bool order)
        {
            this.order = order;
        }
    }
}