namespace _2DEngine
{
    internal class GameObject
    {
        public int X;
        public int Y;
        public char Shape;
        public int orderLayer;
        public bool isTrigger = false;
        public bool isCollide = false;

        public virtual void Update()
        {

        }

        public virtual void Render()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Shape);
        }

        public bool PredictCollision(int newX, int newY)
        {
            for (int i = 0; i < Engine.Instance.world.GetAllGameObjects.Count; ++i)
            {
                if (Engine.Instance.world.GetAllGameObjects[i].isCollide == true &&
                        Engine.Instance.world.GetAllGameObjects[i].X == newX &&
                        Engine.Instance.world.GetAllGameObjects[i].Y == newY)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
