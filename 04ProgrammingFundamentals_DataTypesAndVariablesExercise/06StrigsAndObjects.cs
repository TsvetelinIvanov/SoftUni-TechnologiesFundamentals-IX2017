using System;

namespace _06StrigsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            object objHelloWorld = hello + " " + world;
            string strHelloWorld = (string)objHelloWorld;
            Console.WriteLine(strHelloWorld);
        }
    }
}
