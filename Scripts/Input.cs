namespace _2DEngine
{
    internal class Input
    {
        static protected ConsoleKeyInfo keyInfo;

        static public void Process()
        {
            keyInfo = Console.ReadKey();
        }

        static public bool GetKeyDown(ConsoleKey key)
        {
            return (keyInfo.Key == key);
        }
    }
}
