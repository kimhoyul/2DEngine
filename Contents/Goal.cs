namespace _2DEngine
{
    internal class Goal : GameObject
    {
        public Goal(int x, int y, char shape)
        {
            X = x;
            Y = y;
            Shape = shape;
            orderLayer = 3;
        }
    }
}
