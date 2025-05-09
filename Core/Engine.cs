using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DEngine
{
    internal class Engine
    {
        protected bool isRunning = true;

        public World world;

        public void Input()
        {

        }

        public void Load()
        {
            world = new World();
        }

        protected void Update()
        {
            world.Update();
        }

        protected void Render()
        {
            world.Render();
        }


        public void Run()
        {
            while (isRunning)
            {
                Input();
                Update();
                Render();
            }
        }
    }
}
