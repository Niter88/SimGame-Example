using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimGame.Engine
{
    class GameObject
    {
        public Transform transform;
        public Shape2D shape2D;


        public GameObject()
        {
            transform = new Transform();
        }

        public void SetShape(Shape2D _shape)
        {
            shape2D = _shape;
        }
    }
}
