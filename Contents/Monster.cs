namespace _2DEngine
{
    internal class Monster : GameObject
    {
        public Monster(int x, int y, char shape)
        {
            X = x;
            Y = y;
            Shape = shape;
            orderLayer = 5;
        }
    }
}
