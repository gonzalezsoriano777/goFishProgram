using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goFishProgram
{ 
    public enum cardFaceValues {Ace = 1, Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10, Jack = 11, King = 12, Queen = 13};
    public enum cardSuits { Dolp, Sharks, Orcas, Meg };

    public class gameDeck
    {
        public cardFaceValues faceValue { get; set; }
        public cardSuits cardSuit { get; set; }

        public override string ToString()
        {
            return faceValue + "of a" + cardSuit;
        }

        public gameDeck()
        {

        }
        
        public gameDeck(cardFaceValues value, cardSuits suit)
        {
            this.faceValue = value;
            this.cardSuit = suit;
        }
    }
}
