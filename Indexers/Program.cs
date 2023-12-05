using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            MyVector myVector = new MyVector(1.0f, 2.0f);

            Console.WriteLine($"starting vector: ({myVector[0]},{myVector["1"]})");

            myVector[1] = 69.9f;
            Console.WriteLine($"new Y: {myVector["y"]}");

            myVector["x"] = 42.0f;
            Console.WriteLine($"new X: {myVector["a"]}");
        }
    }
}
