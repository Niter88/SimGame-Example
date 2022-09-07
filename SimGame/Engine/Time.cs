using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimGame.Engine
{
    public static class Time
    {
        //interval from last frame to this one
        public static float deltaTime;

        //total time the app is running
        public static float time;
        public static float realTime;

        public static long currentFrame;
        public static int FPS;

        //local vaeriables for the calcs
        private static long lastTimestamp = 0;
        private static long intervalL;


        public static void InicializeGame(long currentStamp)
        {
            lastTimestamp = currentStamp;
            time = 0f;
            realTime = 0f;
            deltaTime = 0f;
            currentFrame = 0;
        }

        public static void FrameDrawed(long currentStamp)
        {
            //interval from last frame to this one
            intervalL = currentStamp - lastTimestamp;
            deltaTime = (float)intervalL / 1000f;

            //total time the app is running
            time += deltaTime;
            realTime += deltaTime;

            lastTimestamp = currentStamp;

            //frames
            currentFrame++;
            FPS = 1000 / (int)intervalL;
        }
    }
}
