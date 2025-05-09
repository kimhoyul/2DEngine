namespace _2DEngine
{
    internal class Player : GameObject
    {
        public Player(int x, int y, char shape)
        {
            X = x; 
            Y = y; 
            Shape = shape;
            orderLayer = 4;
        }

        public override void Update()
        {
            if (Input.GetKeyDown(ConsoleKey.W) || Input.GetKeyDown(ConsoleKey.UpArrow))
            {
                Y--;
            }
            if (Input.GetKeyDown(ConsoleKey.S) || Input.GetKeyDown(ConsoleKey.DownArrow))
            {
                Y++;
            }
            if (Input.GetKeyDown(ConsoleKey.A) || Input.GetKeyDown(ConsoleKey.LeftArrow))
            {
                X--;
            }
            if (Input.GetKeyDown(ConsoleKey.D) || Input.GetKeyDown(ConsoleKey.RightArrow))
            {
                X++;
            }
        }
    }
}
