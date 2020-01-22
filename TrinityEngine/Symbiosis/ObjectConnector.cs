using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityEngine.Symbiosis
{
    public class ObjectConnector
    {
        public object Left, Right;

        public ObjectConnector()
        {
            Left = Right = null;
        }

        public virtual void Update()
        {

        }

    }
}
