using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace SimGame.Engine
{
    class Canvas : Form
    {
        public Canvas()
        {
            this.DoubleBuffered = true;
        }
    }

    public abstract class NiterEngine
    {
        int[] screenSize;
        string gameTitle;

        Canvas window;

        static Thread gameLoopThread;

        public Color backgroundColor;

        private static Hashtable allShapes = new Hashtable();
        public static void RegisterShape(Shape2D shape)
        {
            if (allShapes.ContainsKey(shape.GetTag()))
            {
                allShapes[shape.GetTag()] = shape;
            }
            else
            {
                allShapes.Add(shape.GetTag(), shape);
            }
        }

        public NiterEngine(int screenX, int screenY, string title)
        {
            screenSize = new int[] { screenX, screenY };
            gameTitle = title;

            window = new Canvas();
            window.Size = new Size(screenX, screenY);
            window.Text = gameTitle;

            window.Paint += OnRender;

            Time.InicializeGame(DateTimeOffset.Now.ToUnixTimeMilliseconds());

            gameLoopThread = new Thread(GameLoop);
            gameLoopThread.Start();
            
            Application.Run(window);
        }

        void GameLoop()
        {
            OnLoad();
            long timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            long delayMs = 16;
            
            while (gameLoopThread.IsAlive)
            {
                if (DateTimeOffset.Now.ToUnixTimeMilliseconds()
                    > (timestamp + delayMs))
                {
                    timestamp = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                    Time.FrameDrawed(timestamp);
                    //Log.Normal($"FPS {Time.FPS}");
                    try
                    {
                        OnUpdate();
                        OnLateUpdate();
                        OnDraw();
                        window.BeginInvoke((MethodInvoker)delegate { window.Refresh(); });
                    }
                    catch
                    {
                        Log.Error("Window has not been found.");
                    }
                }
                Thread.Sleep(1);
            }
        }

        private void OnRender(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(backgroundColor);
            //throw new NotImplementedException();
        }

        public abstract void OnLoad();
        public abstract void OnUpdate();
        public abstract void OnDraw();
        public abstract void OnLateUpdate();

    }
}
