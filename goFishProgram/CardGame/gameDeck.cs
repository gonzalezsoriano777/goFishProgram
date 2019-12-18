using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goFishProgram
{
    public class gameDeck
    {
        enum cardSuits { Sharks = 0, Dolph = 1, Levi = 2, Meg = 3 }; 

        public gameDeck()
        {
            Random cardDeck = new Random();
            var value = cardDeck.Next(0, 52);
            Console.WriteLine(value);
            cardSuits randomSuit = (cardSuits)new Random().Next(0, 3);
        }
    }
}
