using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityEngine.Graph
{
    public class GameGraph2D : GameGraph
    {
        public GameGraph2D()
        {
            RootNode = new GraphNode2D();
        }

        public override void Write(System.IO.BinaryWriter w)
        {

            w.Write(CenterX);
            w.Write(CenterY);
            w.Write(CamX);
            w.Write(CamY);
            w.Write(CamZ);

            RootNode.Write(w);

            //base.Write(w);

        }

    }

    

}
