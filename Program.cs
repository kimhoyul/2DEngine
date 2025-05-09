namespace _2DEngine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine();

            engine.Load();

            engine.Run();

            //engine.Stop();
        }
    }
}
