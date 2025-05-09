namespace _2DEngine
{
    internal class Wall : GameObject
    {
        public Wall(int x, int y, char shape)
        {
            X = x;
            Y = y;
            Shape = shape;
            orderLayer = 2;
        }
    }
}
