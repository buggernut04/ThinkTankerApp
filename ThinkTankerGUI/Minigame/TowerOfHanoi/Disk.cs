using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Application.Forms.MiniGames.TowerOfHanoi
{
    public class Disk : PictureBox
    {
        public int Priority { get; set; }
        private static Color[] colors = new Color[] { Color.Aquamarine, Color.Red, Color.Blue, Color.Indigo, Color.ForestGreen };
        private static int counter = 0;
        public Disk(int prio)
        {
            this.Priority = prio;
            this.BackColor = colors[counter++];
            this.Size = new Size((prio * 500) + 500, 40);
        }

        public void MoveDisk(Pole targetPole)
        {
            this.Location = new Point(targetPole.Location.X, targetPole.Location.Y - targetPole.Disks.Count * this.Height);
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
