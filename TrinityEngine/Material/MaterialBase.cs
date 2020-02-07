using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityEngine.Texture;

namespace TrinityEngine.Material
{
    public class MaterialBase
    {

        public string Name
        {
            get;
            set;
        }

        public Texture2D ColorTex
        {
            get;
            set;
        }

        public Texture2D NormalTex
        {
            get;
            set;
        }

        public Texture2D SpecularTex
        {
            get;
            set;
        }

        public TextureCube EnvironmentCube
        {
            get;
            set;
        }

        public TextureCube ShadowCube
        {
            get;
            set;
        }

        public MaterialBase()
        {
            ColorTex = NormalTex = SpecularTex = null;
            EnvironmentCube = ShadowCube = null;
            Name = "Basic Material001";
        }

        public virtual void InitMaterial()
        {

        }

        public virtual void BindMaterial()
        {

        }

        public virtual void ReleaseMaterial()
        {

        }

    }
}
