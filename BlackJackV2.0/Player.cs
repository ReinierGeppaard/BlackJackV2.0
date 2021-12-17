using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackV2._0
{
    class Player
    {
        public List<Card> PlayerHand;
        public Player() 
        {
            PlayerHand = new List<Card>(); 

        }
        public void AddCard(Card card) 
        {
            PlayerHand.Add(card);
            
        }

    }  
}
    
