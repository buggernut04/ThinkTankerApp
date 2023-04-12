using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkTankerGUI.Minigame.TowerOfHanoi
{
    public class Move
    {
        public Pole FromPole { get; set; }
        public Pole ToPole { get; set; }

        public Move(Pole FromPeg, Pole ToPeg)
        {
            this.FromPole = FromPeg;
            this.ToPole = ToPeg;
        }

        public bool AffectCount()
        {
            //If the poles dont change the move should not be counted
            if (ToPole.Equals(FromPole))
                return false;

            return IsValid();
        }

        public bool IsValid()
        {
            //Allow a move where the pole dont change
            if (ToPole.Equals(FromPole))
                return true;

            return ToPole.AllowDisk(FromPole.GetTopDisk());
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Move move = (Move)obj;
            if (move == null)
                return false;

            return move.FromPole.poleNumber == move.FromPole.poleNumber &&
                move.ToPole.poleNumber == move.ToPole.poleNumber;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
