using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOL
{
    class Cell
    {
        public int Neighbour { get; set; }
        public int Color { get; set; }
        private bool alive;

        public bool Alive
        {
            get { return alive; }
            set { alive = value; }
        }
        public Cell(bool _life, int _neighbour)
        {
            this.alive = _life;
            this.Neighbour = _neighbour;
        }

    }
}