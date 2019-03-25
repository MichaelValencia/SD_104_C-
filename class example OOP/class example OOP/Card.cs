using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_example_OOP
{
    class Card
    {// these are private even if its not specific
        string suit;
        string rank;
        /// <summary>
        /// Creates a card object with the given card rank and suit.
        /// </summary>
        /// <param name="suit"></param> 1,2,3,4,5,6,7,8,9,10,J,Q,K,A
        /// <param name="rank"></param>Use ASCII char for club,spade, heart, or diamond

        public Card(string suit, string rank)
        {
            this.suit = suit;
            this.rank = rank;
            
        }
        public override string ToString()
        {
            return this.rank + this.suit;

        }
        public string Suit
        {get => suit; set => suit = value;
            

        }
        public string Rank
        { get => rank; set => rank = value; }
    }
}
