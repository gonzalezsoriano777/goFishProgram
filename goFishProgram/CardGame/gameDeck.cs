using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace goFishProgram
{ 
    public enum cardFaceValues { Ace = 1, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, King, Queen };
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
