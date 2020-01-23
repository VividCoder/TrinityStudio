using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityEngine.Graph
{
    public class GraphMapHit : GraphHit
    {
        public int TileX
        {
            get;
            set;
        }

        public int TileY
        {
            get;
            set;
        }

        public Map.Map Map
        {
            get;
            set;
        }

        public int XOffSet
        {
            get;
            set;
        }

        public int YOffSet
        {
            set;
            get;
        }

    }
}
