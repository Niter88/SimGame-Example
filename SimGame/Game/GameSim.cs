using SimGame.Engine;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimGame.Game
{
    class GameSim : NiterEngine
    {
        public GameSim(int screenX, int screenY, string title) : base(screenX, screenY, title)
        {
        }

        public override void OnDraw()
        {
            //throw new NotImplementedException();
        }

        public override void OnLateUpdate()
        {
            //throw new NotImplementedException();
        }

        public override void OnLoad()
        {
            //throw new NotImplementedException();
            backgroundColor = Color.Black;
        }

            int frame = 0;
        public override void OnUpdate()
        {
            //frame++;
            //Console.Clear();
            //Console.WriteLine("Frame: " + frame);
            //throw new NotImplementedException();
        }
    }
}
