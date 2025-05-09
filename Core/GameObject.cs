namespace _2DEngine
{
    internal class GameObject
    {
        public int X;
        public int Y;
        public char Shape;

        public virtual void Update()
        {

        }

        public virtual void Render()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Shape);
        }
    }
}
