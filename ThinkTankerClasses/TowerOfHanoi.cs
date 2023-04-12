using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkTankerApp
{
    public class TowerOfHanoi : MiniGame
    {
        private string name;
        private string description;

        public TowerOfHanoi(string name, string description) : base(name, description)
        {
            this.name = "Tower of Hanoi";
            this.description = "Introducing Tower of Hanoi! Transfer all the disks to the rightmost pole without letting a bigger pole sit on top of a smaller one. Accomplish the minigame in the least amount of moves possible!";
        }
    }
}
