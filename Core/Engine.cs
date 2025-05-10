namespace _2DEngine
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

        public World world;

        public void Load(string filename)
        {
            List<string> scene = new List<string>();

            StreamReader sr = new StreamReader(filename);
            while (!sr.EndOfStream)
            {
                scene.Add(sr.ReadLine());
            }
            sr.Close();

            world = new World();

            for (int y = 0; y < scene.Count; y++)
            {
                for (int x = 0; x < scene[y].Length; x++)
                {
                    if (scene[y][x] == '*')
                    {
                        Wall wall = new Wall(x, y, scene[y][x]);
                        world.Instanciate(wall);
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

                    Floor floor = new Floor(x, y, ' ');
                    world.Instanciate(floor);
                }
            }

            world.Sort();
        }

        public void ProcessInput()
        {
            Input.Process();
        }

        protected void Update()
        {
            world.Update();
        }

        protected void Render()
        {
            Console.Clear();
            world.Render();
        }


        public void Run()
        {
            while (isRunning)
            {
                ProcessInput();
                Update();
                Render(); 
            }
        }
    }
}
