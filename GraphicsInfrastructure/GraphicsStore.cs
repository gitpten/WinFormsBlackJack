using CardLib;

namespace GraphicsInfrastructure
{
    public class GraphicsStore
    {
        private static Image faceDownImage;
        private static Dictionary<string, Image> cardImages = new Dictionary<string, Image>();
        private Dictionary<Card, PictureBox> pictureBoxes = new Dictionary<Card, PictureBox>();
        private Dictionary<PictureBox, Card> cards = new Dictionary<PictureBox, Card>();

        public int Count { get => cardImages.Count; }
        public Control Parent { get; set; }


        static GraphicsStore()
        {
            faceDownImage = Image.FromFile($"{Application.StartupPath}\\images\\shirt.jpg");

            foreach (CardRank rank in Enum.GetValues(typeof(CardRank)))
            {
                foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
                {
                    string r = (int)rank <= 10 ? ((int)rank).ToString() : rank.ToString();
                    cardImages[new Card(rank, suit).ToString()] =
                        Image.FromFile($"{Application.StartupPath}\\images\\{r}_of_{suit}s.png");
                }
            }

        }

        public GraphicsStore(CardSet deck, Control parent)
        {
            parent.SuspendLayout();
            foreach (var card in deck)
            {
                var pb = new PictureBox();
                pb.Image = cardImages[card.ToString()];
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
            pb.Image = opened ? cardImages[card.ToString()] : faceDownImage;
            return pb;
        }

        public Card GetCard(PictureBox pb)
        {
            return cards[pb];
        }
    }
}