using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityEngine.Graph
{
    public class GraphNode2DMap : GraphNode2D
    {

        public TrinityEngine.Map.Map NodeMap
        {
            get;
            set;
        }

        public GraphNode2DMap(int mapWidth,int mapHeight,int tileWidth,int tileHeight,int layers=1,string name="")
        {

            Name = name;
            NodeMap = new Map.Map(layers);
            for(int i = 0; i < layers; i++)
            {
                NodeMap.Layers.Add(new Map.Layer.MapLayer(mapWidth, mapHeight, NodeMap));
            }
            NodeMap.TileWidth = tileWidth;
            NodeMap.TileHeight = tileHeight;

        }

        public override void Update()
        {

            UpdateNodes();
        }

        float RotV = 0;
        
        public OpenTK.Vector2[] GetRenderPos(int mx,int my)
        {

            OpenTK.Vector2[] pos = new OpenTK.Vector2[4];

            pos = NodeMap.GetRenderPos(mx,my);

            return pos;

        }
        public static GraphNode2DMap NM = null;
        public override void Render()
        {
            NM = this;
            RotV = RotV + 0.2f;
            
            OpenTK.Matrix4 vm = OpenTK.Matrix4.CreateRotationZ(OpenTK.MathHelper.DegreesToRadians(RotV));
            OpenTK.Matrix4 tm = OpenTK.Matrix4.CreateTranslation(new OpenTK.Vector3(CenterX,CenterY,0));

            vm = vm * tm;

       //     vm = vm * OpenTK.Matrix4.CreateTranslation(new OpenTK.Vector3(CamX, CamY, 0));


            NodeMap.ViewMatrix = vm;


            //NodeMap.CamX = CenterX;
            //NodeMap.CamY = CenterY;

            NodeMap.Render();

            RenderNodes();

        }

        public override void CreateResources()
        {
            NodeMap.CreateResources();
            CreateResourcesNodes();
        }

    }
}
