using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimGame.Engine
{
    public class Vector2
    {
        public float x;
        public float y;

        public Vector2(float _x, float _y)
        {
            x = _x;
            y = _y;
        }

        public static readonly Vector2 zero = new Vector2(0f, 0f);
        public static readonly Vector2 up = new Vector2(0f, 1f);
        public static readonly Vector2 down = new Vector2(0f, -1f);
        public static readonly Vector2 left = new Vector2(-1f, 0f);
        public static readonly Vector2 right = new Vector2(1f, 0f);
    }
}
