using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Application.Forms.MiniGames.TowerOfHanoi
{
    public class Pole
    {
        public List<Disk> Disks;
        public int poleNumber;
        private static int counter = 0;
        public Pole(int poleNumber)
        {
            this.Disks = new List<Disk>();
            this.poleNumber = poleNumber;
        }

        public void SetPictureBox(PictureBox pictureBox)
        {
            pictureBox.Tag = this;
            pictureBox.Location = new Point(486 + (this.poleNumber * 435), 448);
            pictureBox.Size = new Size(34, 483);
            pictureBox.BackColor = Color.Chocolate;
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

        /*public void AddDisk(Disk disk)
        {
            if (disk == null)
                return;
            if (AllowDisk(disk))
            {
                disk.MoveDisk(this);
                Disks.Add(disk);
            }
        }*/

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