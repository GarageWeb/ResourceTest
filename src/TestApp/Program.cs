
using System;

namespace TestApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var mike = Resources.Resource.ResourceManager.GetString("test");
            Console.WriteLine(mike);
        }
    }
}
