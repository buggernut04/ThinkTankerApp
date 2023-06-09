﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkTankerGUI.TowerOfHanoi
{
    public class Pole
    {
        public PictureBox PictureBox { get; set; }
        public Stack<Disk> DiskStack { get; set; }
        public Pole(Point location)
        {
            this.DiskStack = new Stack<Disk>();
            this.PictureBox = new PictureBox();
            this.PictureBox.Size = new Size(10, 106);
            this.PictureBox.BackColor = Color.Chocolate;
            this.PictureBox.Location = location;
        }

        // Add a disk to the top of the pole
        public void AddDisk(Disk disk)
        {
            this.DiskStack.Push(disk);
            // Set the disk's location to the top of the pole
            disk.PictureBox.Location = new Point(PictureBox.Location.X - disk.PictureBox.Width / 2 + PictureBox.Width / 2, PictureBox.Location.Y - disk.PictureBox.Height + 10);
        }

        // Remove the top disk from the pole
        public void RemoveDisk(Disk disk)
        {
            this.DiskStack.Pop();
            // Set the disk's location to offscreen
            disk.PictureBox.Location = new Point(-100, -100);
        }
    }

}
