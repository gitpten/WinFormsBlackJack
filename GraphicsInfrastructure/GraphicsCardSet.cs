using CardLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsInfrastructure
{
    public class GraphicsCardSet
    {
        public Panel Panel { get; }
        public CardSet CardSet { get; }

        private GraphicsStore cardStore;

        public GraphicsCardSet(Panel panel, CardSet cardSet, GraphicsStore cardStore)
        {
            Panel = panel;
            CardSet = cardSet;
            this.cardStore = cardStore;
        }

        public void Draw(bool opened = true)
        {
            Dictionary<Control, bool> added = new Dictionary<Control, bool>();
            for (int i = 0; i < CardSet.Count; i++)
            {
                var card = CardSet[i];
                var pb = cardStore.GetPictureBox(card);
                pb.Size = new Size(Panel.Height * pb.Image.Height / pb.Image.Width, Panel.Height);
                pb.Location = new Point(i * (Panel.Width - pb.Width) / CardSet.Count, 0);
                if (!Panel.Controls.Contains(pb)) Panel.Controls.Add(pb);
                added[pb] = true;
                pb.BringToFront();
            }
            foreach (Control pb in Panel.Controls)
            {
                if (!added.ContainsKey(pb)) Panel.Controls.Remove(pb);
            }
        }
    }
}
