using TrinityEngine.Resonance.Forms;
using TrinityEngine.Texture;

namespace TrinityEngine.Resonance
{
    public class SimpleUI
    {
        public static void Begin()
        {
            TrinityEngine.Draw.IntelliDraw.BeginDraw();
        }

        public static void Image(int x, int y, int w, int h, Texture2D img)
        {
            var tmp_img = new ImageForm().Set(x, y, w, h).SetImage(img);
            tmp_img.Draw();
        }

        public static void End()
        {
            TrinityEngine.Draw.IntelliDraw.EndDraw();
        }
    }
}