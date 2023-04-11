using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Application.Forms.MiniGames.TowerOfHanoi
{
    public class Pole : PictureBox
    {
        public List<Disk> Disks;
        private static Color[] colors = new Color[] { Color.Aquamarine, Color.Red, Color.Blue, Color.Indigo, Color.ForestGreen };
        public int poleNumber;
        private static int counter = 0;
        public Pole(int poleNumber)
        {
            this.Disks = new List<Disk>();
            this.poleNumber = poleNumber;

            int XPosition = GameConstants.PegBaseX + ((poleNumber + 1) * GameConstants.SpaceBetweenPoles);
            int YPosition = GameConstants.PegBaseY + this.Size.Height - this.Size.Height;
            this.Location = new Point(XPosition, YPosition);
            this.Size = new Size(15, 250);

            this.BackColor = colors[counter++];
        }

        public bool IsEmpty()
        {
            return Disks.Count == 0;
        }

        public bool AllowDisk(Disk disk)
        {
            Disk diskToCheck = GetTopDisk();

            if (disk == null)
                return false;

            if (Disks.Count == 0)
                return true;

            return diskToCheck.Priority > disk.Priority;
        }

        public Disk GetTopDisk()
        {
            if (Disks.Count > 0)
                return Disks.First();
            return null;
        }

        public void RemoveDisk()
        {
            Disks.Remove(Disks.First());
        }

        public void AddDisk(Disk disk)
        {
            if (disk == null)
                return;

            if (AllowDisk(disk))
            {
                disk.MoveDisk(this);
                Disks.Add(disk);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Pole pole = (Pole)obj;
            if (pole == null)
                return false;

            return pole.poleNumber == poleNumber;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
