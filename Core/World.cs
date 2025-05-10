namespace _2DEngine
{
    internal class World
    {
        List<GameObject> gameObjects = new List<GameObject>();

        public void Instanciate(GameObject gameObject)
        {
            gameObjects.Add(gameObject);
        }

        public List<GameObject> GetAllGameObjects
        {
            get
            {
                return gameObjects;
            }
        }

        public void Update()
        {
            for (int i = 0; i < gameObjects.Count; i++)
            {
                gameObjects[i].Update();
            }
        }

        public void Render()
        {
            for (int i = 0; i < gameObjects.Count; i++)
            {
                gameObjects[i].Render();
            }
        }

        public void Sort()
        {
            for (int i = 0; i < gameObjects.Count; i++)
            {
                for (int j = i + 1; j < gameObjects.Count; j++)
                {
                    if (gameObjects[i].orderLayer - gameObjects[j].orderLayer > 0)
                    {
                        GameObject temp = gameObjects[i];
                        gameObjects[i] = gameObjects[j];
                        gameObjects[j] = temp;
                    }
                }
            }
        }
    }
}
