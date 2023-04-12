using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkTankerGUI.TowerOfHanoi
{
    public class Disk
    {
        public int Priority { get; set; }
        public PictureBox PictureBox { get; set; }
        private static Color[] colors = new Color[] { Color.Aquamarine, Color.Red, Color.Blue, Color.Indigo, Color.ForestGreen };
        private static int counter = 0;

        public Disk(int priority)
        {
            this.Priority = priority;
            this.PictureBox = new PictureBox();
            this.PictureBox.BackColor = colors[counter++];
            this.PictureBox.Size = new Size(70 + (this.Priority * 25), 20);
            this.PictureBox.Tag = this;
        }


    }
}
