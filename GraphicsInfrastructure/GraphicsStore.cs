using CardLib;

namespace GraphicsInfrastructure
{
    public class GraphicsStore
    {

        private static Dictionary<string, Image> cardImages = new Dictionary<string, Image>();
        private Dictionary<Card, PictureBox> pictureBoxes = new Dictionary<Card, PictureBox>();
        private Dictionary<PictureBox, Card> cards = new Dictionary<PictureBox, Card>();

        public Control Parent { get; set; }
        public static Image FaceDownImage { get; private set; }
        static GraphicsStore()
        {
            FaceDownImage = Image.FromFile($"{Application.StartupPath}\\images\\pattern.png");

            foreach (CardRank rank in Enum.GetValues(typeof(CardRank)))
            {
                foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
                {
                    string rankString = (int)rank <= 10 ? $"{(int)rank}" : $"{rank}";
                    cardImages[new Card(rank, suit).ToString()] =
                    Image.FromFile($"{Application.StartupPath}\\images\\{rankString}_of_{suit}s.png");
                }
            }

        }

        public GraphicsStore(CardSet deck, Control parent)
        {
            parent.SuspendLayout();
            foreach (var card in deck)
            {
                var pb = new PictureBox();
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxes[card] = pb;
                cards[pb] = card;
                parent.Controls.Add(pb);
            }
            Parent = parent;
            parent.ResumeLayout();
        }

        public PictureBox GetPictureBox(Card card, bool opened = true)
        {
            var pb = pictureBoxes[card];
            pb.Image = opened ? cardImages[$"{card}"] : FaceDownImage;
            return pb;
        }

        public Card GetCard(PictureBox pb)
        {
            return cards[pb];
        }
    }
}