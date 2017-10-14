using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Game
    {
        private List<Player> players;
        private Dictionary<Values, Player> books;
        private Deck stock;
        private TextBox textBoxOnForm;

        public Game(string playerName, IEnumerable<string> opponentNames, TextBox textBoxOnForm)
        {
            Random random = new Random();
            this.textBoxOnForm = textBoxOnForm;
            players = new List<Player>();
            players.Add(new Player(playerName, random, textBoxOnForm));
            foreach (string player in opponentNames)
            {
                players.Add(new Player(player, random, textBoxOnForm));
            }
            books = new Dictionary<Values, Player>();
            stock = new Deck();
            Deal();
            players[0].SortHand();
        }

        private void Deal()
        {
            stock.Shuffle();
            for (int i = 0; i < 5; i++)
            {
                foreach (Player player in players)
                {
                    player.TakeCard(stock.Deal());
                }
            }
            foreach (Player player in players)
            {
                PullOutBooks(player);
            }
        }

        public bool PlayOneRound(int selectedPlayerCard)
        {
            Values value = players[0].Peek(selectedPlayerCard).Value;
            for (int i = 0; i < players.Count; i++)
            {
                if (i == 0)
                    players[0].AskForACard(players, 0, stock, value);
                else
                    players[i].AskForACard(players, i, stock);
                for (int j = 0; j < players.Count; j++)
                {
                    if (PullOutBooks(players[j]))
                    {
                        textBoxOnForm.Text += players[j].Name + " had ran out of his card,he had to draw a new hand."+Environment.NewLine;
                        for (int k = 0; k < 5; k++)
                        {
                            if (stock.Count > 0)
                                players[j].TakeCard(stock.Deal());
                        }
                    }
                }
            }

            players[0].SortHand();

            if (stock.Count == 0)
            {
                textBoxOnForm.Text = "The stock is out of cards.Game over!";
                return true;
            }
            else
                return false;

        }

        public bool PullOutBooks(Player player)
        {            
            IEnumerable<Values> values= player.PullOutBooks();
            foreach (Values value in values)
            {
                books[value] = player;
            }
            if (player.CardCount == 0)
                return true;
            else
                return false;
        }

        public string DescribeBooks()
        {
            string description="";
            foreach(Values value in books.Keys)
            {
                description+=books[value].Name+" has a book of "+Card.Plural(value)+Environment.NewLine;
            }
            return description;
        }

        public string GetWinnerName()
        {
            Dictionary<string, int> winners = new Dictionary<string, int>();
            string description;

            foreach (Player player in players)
            {
                winners.Add(player.Name, 0);
                foreach (Values value in books.Keys)
                {
                    if (books[value] == player)
                        winners[player.Name] += 1;
                }
            }

            int max=0;
            foreach (string player in winners.Keys)
            {
                if (winners[player] > max)
                    max = winners[player];
            }

            List<string> winnersName=new List<string>();
            foreach(string player in winners.Keys)
                if(winners[player]==max)
                    winnersName.Add(player);

            if (winnersName.Count == 1)
                description = winnersName[0] + " with " + max.ToString() + " books.";
            else
            {
                description = "A tie between ";
                for (int i = 0; i < winnersName.Count - 1; i++)
                {
                    description += winnersName[i] + " and ";
                }
                description += winnersName[winnersName.Count - 1] += " with " + max.ToString() + " books.";
            }
            return description;
        }

        public IEnumerable<string> GetPlayerCardNames()
        { return players[0].GetCardNames(); }

        public string DescribePlayerHands()
        {
            string description = "";
            for (int i = 0; i < players.Count; i++)
            {
                description += players[i].Name + " has " + players[i].CardCount;
                if (players[i].CardCount == 1)
                    description += " card." + Environment.NewLine;
                else
                    description += " cards." + Environment.NewLine;
            }
            description += "The stock has " + stock.Count + " cards left.";
            return description;
        }
    }
}
