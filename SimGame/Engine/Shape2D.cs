using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimGame.Engine
{
    public class Shape2D
    {
        byte[] scale;
        byte[,] shape;
        string tag;
        byte itemId;


        public Shape2D(byte[] _scale, byte[,] _shape, string _tag, byte _itemId)
        {
            scale = _scale;
            shape = _shape;
            tag = _tag;
            itemId = _itemId;

            NiterEngine.RegisterShape(this);
        }


        public byte[] GetScale()
        {
            return scale;
        }

        public byte[,] GetShape()
        {
            return shape;
        }

        public string GetTag()
        {
            return tag;
        }
    }
}
