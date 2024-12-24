using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame.Interfaces
{
    public interface ICard
    {
        public int Card { 
            get; 
            set; 
        }

        public int Suit
        {
            get;
            set;
        }
    }
}
