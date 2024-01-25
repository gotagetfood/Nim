using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimCSharp.model
{
    internal class stickModel
    {
        private int Id { get; set; }
        private bool active { get; set; }

        //in case we need the posision in the lists
        private int x { get; set; }
        private int y { get; set; }


        public stickModel() { }

        public stickModel(int id, int x, int y, bool active)
        {
            Id = id;
            this.x = x;
            this.y = y;
            this.active = active;
        }


        public bool isActive()
        {
            return active;
        }
    }
}
