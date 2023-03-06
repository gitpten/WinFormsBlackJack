using ConsoleBlackJack;
using GraphicsInfrastructure;

namespace WinFormsBlackJack
{
    public partial class Form1 : Form
    {
        BlackJackGame game;
        List<GraphicsCardSet> sets = new List<GraphicsCardSet>();
        public Form1()
        {
            InitializeComponent();
            game = new BlackJackGame(new Player("Bob"), new Player("Dealer"), ShowInfo, ShowState);
            GraphicsStore store = new GraphicsStore(game.Deck, this);
            sets.Add(new GraphicsCardSet(game.Deck,
                new Rectangle(pDeck.Location, pDeck.Size),
                store));
            sets.Add(new GraphicsCardSet(game.Player.Hand,
                new Rectangle(pPlayer.Location, pPlayer.Size),
                store));
            sets.Add(new GraphicsCardSet(game.Dealer.Hand,
                new Rectangle(pDealer.Location, pDealer.Size),
                store));
            game.Start();
            Update();
        }

        private void ShowState()
        {
            SuspendLayout();
            foreach (var set in sets)
            {
                if (game.Current == game.Player && set.CardSet == game.Dealer.Hand)
                    set.Draw(c => c == game.Dealer.Hand[0]);
                else
                    set.Draw((set.CardSet != game.Deck) &&
                        (set.CardSet == game.Player.Hand || game.Current == game.Current));
            }
            ResumeLayout();
        }

        private void ShowInfo(string message)
        {
            lInfo.Text = message;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            game.Hit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game.Pass();
        }
    }
}