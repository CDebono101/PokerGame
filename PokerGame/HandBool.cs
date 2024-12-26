using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    public class HandBool
    {
        public static bool Quads(List<int> _cards)
        {
            if (_cards[0] == _cards[1] && _cards[1] == _cards[2] && _cards[2] == _cards[3])
            {
                return true;
            }
            else if (_cards[1] == _cards[2] && _cards[2] == _cards[3] && _cards[3] == _cards[4])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Flush(List<int> _suits)
        {
            if (_suits[0] == _suits[1] && _suits[1] == _suits[2] && _suits[2] == _suits[3] && _suits[3] == _suits[4])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Stright(List<int> _cards)
        {
            if (_cards[0] == _cards[0] + 1 && _cards[1] == _cards[1] + 1 && _cards[2] == _cards[2] + 1 && _cards[3] == _cards[3] + 1 && _cards[4] == _cards[4] + 1)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        // Fix trips

        public static bool Trips(List<int> _cards)
        {
            if (_cards[0] == _cards[1] && _cards[1] == _cards[2] && _cards[2] != _cards[3])
            {
                return true;
            }
            else if (_cards[1] == _cards[2] && _cards[2] == _cards[3] && _cards[3] != _cards[4])
            {
                return true;
            }
            else if (_cards[2] == _cards[3] && _cards[3] == _cards[4] && _cards[4] != _cards[1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool TwoPair(List<int> _cards)
        {
            if (_cards[0] == _cards[1] && _cards[2] == _cards[3] && _cards[3] != _cards[4])
            {
                return true;
            }
            else if (_cards[1] == _cards[2] && _cards[3] == _cards[4] && _cards[4] != _cards[1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public static bool Pair(List<int> _cards)
        {
            if (_cards[0] == _cards[1] && _cards[1] != _cards[2])
            {
                return true;
            }
            else if (_cards[0] != _cards[1] && _cards[1] == _cards[2] && _cards[2] != _cards[3])
            {
                return true;    
            }
            else if (_cards[1] != _cards[2] && _cards[2] == _cards[3] && _cards[3] != _cards[4])
            {
                return true;
            }
            else if (_cards[2] != _cards[3] && _cards[3] == _cards[4] && _cards[4] != _cards[0])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
