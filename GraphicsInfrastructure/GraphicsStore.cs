using CardLib;

namespace GraphicsInfrastructure
{
    public class GraphicsStore
    {
        private Image faceDownImage;
        private Dictionary<Card, Image> cardImages = new Dictionary<Card, Image>();
        private Dictionary<Card, PictureBox> pictureBoxes = new Dictionary<Card, PictureBox>();
        private Dictionary<PictureBox, Card> cards = new Dictionary<PictureBox, Card>();

        public GraphicsStore(CardSet deck)
        {
            faceDownImage = Image.FromFile($"{Application.StartupPath}\\images\\shirt.jpg");

            foreach (var card in deck)
            {
                cardImages[card] =
                    Image.FromFile($"{Application.StartupPath}\\images\\{card.Suit}s {card.Rank}.png");
                var pb = new PictureBox();
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxes[card] = pb;
                cards[pb] = card;
            }
        }

        public PictureBox GetPictureBox(Card card, bool opened = true)
        {
            var pb = pictureBoxes[card];
            pb.Image = opened ? cardImages[card] : faceDownImage;
            return pb;
        }

        public Card GetCard(PictureBox pb)
        {
            return cards[pb];
        }
    }
}