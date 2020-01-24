using TrinityEngine.Texture;
using TrinityEngine.Video;

namespace TrinityEngine.Resonance.Forms
{
    public class VideoForm : UIForm
    {
        private VideoPlayer CurVid = null;
        private Texture2D VidTex = null;
        private VideoFrame Frm = null;
        public bool Paused = false;

        public VideoForm()
        {
        }

        public void SetVideo(string path)
        {
            CurVid = new VideoPlayer(path);

            Draw = () =>
            {
                // if (Paused) return;
                // if (Frm == null) return;
                if (Frm == null) return;
                DrawForm(CurVid.GetCurrentImage(), new OpenTK.Vector4(1,1,1,1));
            };

            Update = () =>
            {
                // CurVid.DecodeNextFrame();
                if (Paused) return;
                var frame = CurVid.GetCurrentFrame();
                if (frame != null)
                {
                    Frm = frame;
                }
            };
        }
        public void StopAudio()
        {
            CurVid.StopAudio();
        }
        public void Stop()
        {
            CurVid.Stop();
            Paused = true;
        }
        public void Pause()
        {
            if (Paused) return;
            Paused = true;
            CurVid.Pause();
        }

        public void Play()
        {
            if (Paused == false) return;
            Paused = false;
            CurVid.Play();
        }
    }
}