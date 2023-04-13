using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkTankerClasses
{
    public class MatchingGame : MiniGame
    {
        private string name;
        private string description;

        public MatchingGame(string name, string description) : base(name, description)
        {
            this.name = "Matching Game";
            this.description = "The visual memory and discrimination involved and the identification of patterns and relationships and similarity and difference help children to learn about early representation and problem solving. Matching and sorting activities can also be good for developing fine motor skills.";
        }
    }
}
