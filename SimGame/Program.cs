using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimGame.Game;

namespace SimGame
{
    class Program
    {
        static GameSim gameSim;
        static void Main(string[] args)
        {
            gameSim = new GameSim(512, 256, "SimGame");
        }
    }
}
