using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimGame.Engine
{
    class Transform
    {
        public bool isStatic = false;
        public bool isFrontFacing = true;
        public Vector2 position = Vector2.zero;

        public Transform() { }
        public Transform(Vector2 pos)
        {
            position = pos;
        }

        public void Translate(Vector2 mov)
        {
            position.x += mov.x;
            position.y += mov.y;
        }

        public void Move(Vector2 pos)
        {
            position = pos;
        }
    }
}
