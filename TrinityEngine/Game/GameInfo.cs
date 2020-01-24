using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityEngine.Game
{

    public delegate void InitHook();
    public delegate void RenderHook();
    public delegate void UpdateHook();

    public class GameInfo
    {

        public LevelInfo LevelInfo
        {
            get;
            set;
        }

        public List<LevelInfo> Levels
        {
            get;
            set;
        }

        public string GameName
        {
            get;
            set;
        }

        public RenderHook Render = null;
        public UpdateHook Update = null;
        public InitHook Init = null;

        public void BeginGame()
        {
            Init();


        }

        public GameInfo()
        {
            
            Levels = new List<LevelInfo>();
            GameName = "Vivid3D Game";

        }


    }
}
