
using System;

namespace TestApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var txt = Resources.Resource.ResourceManager.GetString("test");
            Console.WriteLine(txt);
        }
    }
}
