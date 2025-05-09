﻿namespace _2DEngine
{
    internal class Engine
    {
        static protected Engine instance;

        static public Engine Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Engine();
                }

                return instance;
            }
        }

        protected bool isRunning = true;
        protected ConsoleKeyInfo keyInfo;

        public World world;

        public void Input()
        {
            keyInfo = Console.ReadKey();
        }

        public void Load()
        {
            string[] scene = {
                "**********",
                "*P       *",
                "*        *",
                "*        *",
                "*        *",
                "*   M    *",
                "*        *",
                "*        *",
                "*       G*",
                "**********"
            };

            world = new World();

            for (int y = 0; y < scene.Length; y++)
            {
                for (int x = 0; x < scene[y].Length; x++)
                {
                    if (scene[y][x] == '*')
                    {
                        Wall wall = new Wall(x, y, scene[y][x]);
                        world.Instanciate(wall);
                    }
                    else if (scene[y][x] == ' ')
                    {
                        Floor floor = new Floor(x, y, scene[y][x]);
                        world.Instanciate(floor);
                    }
                    else if (scene[y][x] == 'P')
                    {
                        Player player = new Player(x, y, scene[y][x]);
                        world.Instanciate(player);
                    }
                    else if (scene[y][x] == 'M')
                    {
                        Monster monster = new Monster(x, y, scene[y][x]);
                        world.Instanciate(monster);
                    }
                    else if (scene[y][x] == 'G')
                    {
                        Goal goal = new Goal(x, y, scene[y][x]);
                        world.Instanciate(goal);
                    }
                }
            }
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
