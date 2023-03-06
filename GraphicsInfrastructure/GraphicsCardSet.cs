using CardLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace GraphicsInfrastructure
{
    public class GraphicsCardSet
    {
        public CardSet CardSet { get; }
        public Rectangle Frame { get; set; }

        private GraphicsStore cardStore;
        public GraphicsCardSet(CardSet cardSet, GraphicsStore store, Rectangle frame)
        {
            CardSet = cardSet;
            this.cardStore = store;
            Frame = frame;
        }
        public void Draw(bool opened = true)
        {
            
            int h = Frame.Height;
            var firstPb = cardStore.GetPictureBox(CardSet[0]);
            int w = h * firstPb.Image.Width / firstPb.Image.Height;
            int d = (Frame.Width - firstPb.Width) / CardSet.Count;
            int x0 = Frame.X;
            int y0 = Frame.Y;

            for (int i = 0; i < CardSet.Count; i++)
            {
                var card = CardSet[i];
                var pb = cardStore.GetPictureBox(card, opened);
                pb.Size = new Size(w, h);
                pb.Location = new Point(x0 + i * d, y0);
                pb.BringToFront();
            }
        }
    }
}
