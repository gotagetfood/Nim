using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimCSharp.model
{
    internal class boardModel
    {
        public int Id { get; set; }

        List<List<stickModel>> stickList;

        public boardModel() { }
        public boardModel(int id, List<List<stickModel>> stickList)
        {
            this.stickList = stickList;
        }

        


        public List<List<stickModel>> getStickList()
        {
            return stickList;
        }

        public int getActiveSticks()
        {
            int activeSticks = 0;
            foreach (List<stickModel> list in stickList)
            {
                foreach (stickModel stick in list)
                {
                    if (stick.isActive())
                    {
                        activeSticks++;
                    }
                }
            }
            return activeSticks;
        }
    }
}
