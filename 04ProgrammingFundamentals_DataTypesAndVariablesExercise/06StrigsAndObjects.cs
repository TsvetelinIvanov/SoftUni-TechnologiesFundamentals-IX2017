using System;

namespace _06StrigsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            
            object objectHelloWorld = hello + " " + world;
            string stringHelloWorld = (string)objectHelloWorld;
            
            Console.WriteLine(stringHelloWorld);
        }
    }
}
