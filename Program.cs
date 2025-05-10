namespace _2DEngine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Engine.Instance.Load("D:\\CodeWorks\\C#\\2DEngine\\level02.map");
            Engine.Instance.Run();
        }
    }
}
