using ConsoleBlackJack;
using GraphicsInfrastructure;

namespace WinFormsBlackJack
{
    public partial class Form1 : Form
    {
        BlackJackGame game;
        List<GraphicsCardSet> sets = new();
        public Form1()
        {
            InitializeComponent();
            game = new BlackJackGame(new Player("Player"), new Player("Dealer"), ShowInfo, ShowState);

            GraphicsStore store = new GraphicsStore(game.Deck, this);
            GraphicsCardSet deck = new GraphicsCardSet(game.Deck, store, new Rectangle(pDeck.Location, pDeck.Size));
            GraphicsCardSet player = new GraphicsCardSet(game.Player.Hand, store, new Rectangle(pPlayer.Location, pPlayer.Size));
            GraphicsCardSet dealer = new GraphicsCardSet(game.Dealer.Hand, store, new Rectangle(pDealer.Location, pDealer.Size));
            sets.Add(deck);
            sets.Add(player);
            sets.Add(dealer);
            game.Start();
            Update();
        }

        private void ShowInfo(string message)
        {
            lInfo.Text = message;
        }

        private void ShowState()
        {
            SuspendLayout();
            foreach (var set in sets)
            {
                set.Draw(game.Current.Hand == set.CardSet);
            }
            ResumeLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game.Hit();
        }

        private void bPass_Click(object sender, EventArgs e)
        {
            game.Pass();
        }
    }
}