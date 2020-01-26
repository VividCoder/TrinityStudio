using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace TrinityEngine.Game
{
    public class LevelInfo
    {

        public string LevelName
        {
            get;
            set;
        }

        public string IntroMoviePath
        {
            get
            {
                return _IntroMoviePath;
            }
            set
            {
                _IntroMoviePath = value;
                HasIntroMovie = true;
            }
        }
        public string _IntroMoviePath = "";

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

        public LevelInfo(string path)
        {

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryReader r = new BinaryReader(fs);

            IntroMoviePath = r.ReadString();
            HasIntroMovie = r.ReadBoolean();
            LevelName = r.ReadString();

            r.Close();
            fs.Close();

        }

        public void Save(string path)
        {

            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            BinaryWriter w = new BinaryWriter(fs);

            w.Write(IntroMoviePath);
            w.Write(HasIntroMovie);
            w.Write(LevelName);

            w.Flush();
            fs.Flush();
            w.Close();
            fs.Close();


        }

    }

}