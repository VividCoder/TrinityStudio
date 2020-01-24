using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityEngine.Game
{
    public class LevelInfo
    {

        public string IntroMoviePath
        {
            get;
            set;
        }

        public bool HasIntroMovie
        {
            get;
            set;
        }

        public bool MoviePlayed
        {
            get;
            set;
        }

        public LevelInfo()
        {
            HasIntroMovie = false;
            IntroMoviePath = "";
            MoviePlayed = false;
        }

    }
}
