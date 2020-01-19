namespace TrinityEngine.Effect
{
    public class FXDepth3D : Effect3D
    {
        public FXDepth3D() : base("", "data/Shader/vsDepth.txt", "data/Shader/fsDepth.txt")
        {
        }

        public override void SetPars()
        {
            //SetMat("MVP", Effect.FXG.Local * FXG.Proj);
            SetMat("model", Effect.FXG.Local);
      
        }
    }

    public class FXSSRExtrasMap : Effect3D
    {
        public FXSSRExtrasMap() : base("", "data/Shader/vsSSRExtrasMap.glsl", "data/Shader/fsSSRExtrasMap.glsl")
        {
        }

        public override void SetPars()
        {
            SetMat("model", Effect.FXG.Local);
 
            SetTex("tExtra", 0);
        }
    }

    public class FXPositionMap : Effect3D
    {
        public FXPositionMap() : base("", "data/Shader/vsPositionMap.glsl", "data/Shader/fsPositionMap.glsl")
        {
        }

        public override void SetPars()
        {
            SetMat("model", Effect.FXG.Local);
   
        }
    }

    public class FXNormalMap : Effect3D
    {
        public FXNormalMap() : base("", "data/Shader/vsNormalMap.glsl", "data/Shader/fsNormalMap.glsl")
        {
        }

        public override void SetPars()
        {
            SetMat("model", Effect.FXG.Local);
      
        }
    }
}