using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackV2._0
{
    class Dealer
    {
        public List<Card> DealerHand;

        public Dealer()
        {
            DealerHand = new List<Card>();
        }
        public void DealerAddCard(Card card)
        {
            DealerHand.Add(card);
        }
    }
}
