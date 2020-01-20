using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityEngine.Graph
{
    interface IGraphRenderable
    {
        void PreRender();
        void Render();
        void PostRender();

    }
}
