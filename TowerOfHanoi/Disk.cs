using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Application.Forms.MiniGames.TowerOfHanoi
{
    public class Disk
    {
        public int Priority { get; set; }
        private static Color[] colors = new Color[] { Color.Aquamarine, Color.Red, Color.Blue, Color.Indigo, Color.ForestGreen };
        private static int counter = 0;
        //public Move Move { get; set; }
        public Disk(int prio)
        {
            this.Priority = prio;
        }


        public void SetPictureBox(PictureBox pictureBox)
        {
            pictureBox.Tag = this;
            pictureBox.BackColor = colors[counter++];
            pictureBox.Size = new Size(200 + (this.Priority * 83), 63);
        }


        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Disk disk = (Disk)obj;
            if (disk == null)
                return false;

            return disk.Priority == this.Priority;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}