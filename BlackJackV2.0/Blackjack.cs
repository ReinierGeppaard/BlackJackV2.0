using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace BlackJackV2._0
{
    public partial class Blackjack : Form
    {
        Player player = new Player();
        Dealer dealer = new Dealer();
        Deck deck = new Deck();
        int playervalue = 0;
        int dealervalue = 0;
        List<PictureBox> PlayerPicturebox = new List<PictureBox>();
        List<PictureBox> DealerPictureBox = new List<PictureBox>();

        int numPlayerCard = 0;
        int numDealerCard = 0;
        int PlayerWins = 0;
        int DealerWins = 0;

        int chips = 0;
        int bet = 0;

        public Blackjack()
        {
            InitializeComponent();
            PlayerPicturebox.Add(PPicBox1);
            PlayerPicturebox.Add(PPicBox2);
            PlayerPicturebox.Add(PPicBox3);
            PlayerPicturebox.Add(PPicBox4);
            PlayerPicturebox.Add(PPicBox5);
            PlayerPicturebox.Add(PPicBox6);

            DealerPictureBox.Add(DPicBox1);
            DealerPictureBox.Add(DPicBox2);
            DealerPictureBox.Add(DPicBox3);
            DealerPictureBox.Add(DPicBox4);
            DealerPictureBox.Add(DPicBox5);
            DealerPictureBox.Add(DPicBox6);

            string text = System.IO.File.ReadAllText(Path.GetFullPath("../../Blackjack.txt"));

            chips = Convert.ToInt32(text);
            if (chips == 0)
            {
                chips = 1;
            }
            BetBar.Maximum = chips;
            BetBar.Value = 1;
            bet = 1;
            UpdateChips();
            
            LResult.Text = "";
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            chips -= bet;
            UpdateChips();
            BetBar.Enabled = false;
            numPlayerCard = 0;
            numDealerCard = 0;
            StartGame.Enabled = false;
            playervalue = 0;
            dealervalue = 0;
            deck.Shuffle();
            deck.DealerDeal(dealer);
            deck.PlayerDeal(player);

            for (int i = 0; i < player.PlayerHand.Count; i++)
            {
                Card card = player.PlayerHand[i];
                PlayerPicturebox[i].ImageLocation = Path.GetFullPath(card.image);
                playervalue += card.rank;
       
                
            }
            for (int i = 0; i < dealer.DealerHand.Count; i++)
            {
                Card card = dealer.DealerHand[i];
                DealerPictureBox[i].ImageLocation = Path.GetFullPath (card.image);
                dealervalue += card.rank;
            }
            numPlayerCard = 2;
            numDealerCard = 1;

            BHit.Enabled = true;
            BStand.Enabled = true;
            BReset.Enabled = true;

            if (playervalue == 21)
            {
                LResult.Text = "You win!";
                PlayerWins++;
                chips += bet * 2;
                UpdateChips();
                UpdateWins();
                BHit.Enabled = false;
                BStand.Enabled = false;
            }
            UpdateValues();
        }

        private void BHit_Click(object sender, EventArgs e)
        {
            if (numPlayerCard >= PlayerPicturebox.Count)
            {
                MessageBox.Show("Too many cards bro");
                return;
            }
            Card card = deck.GetAndRemoveCard();
            PlayerPicturebox[numPlayerCard].ImageLocation = Path.GetFullPath(card.image);
            numPlayerCard++;
            if (card.rank == 11 && playervalue + 11 > 21)
            {
                playervalue += 1;
            }
            else
            {
                playervalue += card.rank;
            }
            UpdateValues();

            if (playervalue > 21)
            {
                LResult.Text = "You lose!";
                DealerWins++;
                UpdateWins();

                BHit.Enabled = false;
                BStand.Enabled = false;
                if (chips == 0)
                {
                    chips = 1;
                }
            }
         
            if (playervalue == 21)
            {
                LResult.Text = "You win!";
                PlayerWins++;
                chips += bet * 2;
                UpdateWins();

                BHit.Enabled = false;
                BStand.Enabled = false;
            }
            UpdateChips();
        }

        private void BStand_Click(object sender, EventArgs e)
        {
            BHit.Enabled=false;
            BStand.Enabled=false;
            while (dealervalue < 17)
            {
                if (numDealerCard >= DealerPictureBox.Count)
                {
                    MessageBox.Show("Dealer has reached maximum cards!");
                    break;
                }
                Card card = deck.GetAndRemoveCard();
                DealerPictureBox[numDealerCard].ImageLocation = Path.GetFullPath(card.image);
                numDealerCard++;
                if (card.rank == 11 && dealervalue + 11 > 21)
                {
                    dealervalue += 1;
                }    
                else
                {
                    dealervalue += card.rank;
                }
                UpdateValues();

                if (dealervalue > 21)
                {
                    LResult.Text = "You win!";

                    break;
                }
            }
            if (dealervalue < playervalue || dealervalue > 21)
            {
                LResult.Text = "You win!";
                PlayerWins++;
                chips += bet * 2;
            }
            else
            {
                LResult.Text = "You lose!";
                DealerWins++;
                if (chips == 0)
                {
                    chips = 1;
                }
            }
            UpdateWins();
            UpdateChips();
        }

        private void BReset_Click(object sender, EventArgs e)
        {
            BetBar.Value = 1;
            bet = 1;
            LBet.Text = "Bet: 1";
            BetBar.Enabled = true;
            playervalue = 0;
            dealervalue = 0;
            UpdateValues();
            deck = new Deck();
            StartGame.Enabled = true;
            BHit.Enabled = false;
            BReset.Enabled = false;
            BStand.Enabled = false;
            for (int i = 0; i < PlayerPicturebox.Count; i++)
            {
                PlayerPicturebox[i].Image = null;
            }
            for (int i = 0; i < DealerPictureBox.Count; i++)
            {
                DealerPictureBox[i].Image = null;
            }
            player.PlayerHand.Clear();
            dealer.DealerHand.Clear();
            LResult.Text = "";
        }
        private void UpdateWins()
        {
            LPlayerWin.Text = "Player wins: " + PlayerWins;
            LDealerWin.Text = "Dealer wins: " + DealerWins;
        }
        private void UpdateValues()
        {
            LCardValuePlayer.Text = "Card value: " + playervalue;
            LCardValueDealer.Text = "Card value: " + dealervalue;
        }

        private void BetBar_Scroll(object sender, EventArgs e)
        {
            bet = BetBar.Value;
            LBet.Text = "Bet: " + bet;
            if (bet == 0)
            {
                StartGame.Enabled = false;
            }
            else
            {
                StartGame.Enabled = true;
            }
            Console.WriteLine("test");
        }
        private void UpdateChips()
        {
            LChips.Text = "Chips: " + chips;
            System.IO.File.WriteAllText(Path.GetFullPath("../../Blackjack.txt"), chips.ToString());
            BetBar.Maximum = chips;
        }

        private void LPlayerWin_Click(object sender, EventArgs e)
        {

        }
    }
}
