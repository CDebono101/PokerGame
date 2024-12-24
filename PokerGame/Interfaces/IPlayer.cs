using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame.Interfaces
{
    public interface IPlayer
    {
        public string Name { get; set; }
        public int ClientId {  get; set; } 
        public float Bal { get; set; }
    }
}
