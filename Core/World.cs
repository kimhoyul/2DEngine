namespace _2DEngine
{
    internal class World
    {
        public GameObject[] gameObjects;
        public void Update()
        {
            if (gameObjects == null)
                return;

            for (int i = 0; i < gameObjects.Length; i++)
            {
                gameObjects[i].Update();
            }
        }

        public void Render()
        {
            if (gameObjects == null)
                return;

            for (int i = 0; i < gameObjects.Length; i++)
            {
                gameObjects[i].Render();
            }
        }
    }
}
