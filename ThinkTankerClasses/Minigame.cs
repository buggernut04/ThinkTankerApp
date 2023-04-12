using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkTankerClasses
{
    public abstract class MiniGame
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public MiniGame(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
