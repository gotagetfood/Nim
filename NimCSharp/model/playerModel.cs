using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimCSharp.model
{
    internal class playerModel
    {

        public int id;
        public string name;
        public bool haswon;

        public playerModel() { }
        public playerModel(int id, string name, bool haswon)
        {
            this.id = id;
            this.name = name;
            this.haswon = haswon;
        }
    }
}
