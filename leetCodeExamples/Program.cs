using leetCodeExamples.Solutions;
using System;

namespace leetCodeExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");

            Stack myStack = new Stack();

            myStack.List();

            myStack.Push(11);
            myStack.Push(5);
            myStack.Push(7);
            myStack.Push(66);
            myStack.List();

            myStack.Pop();
            // myStack.Pop();

            myStack.List();
            Console.ReadKey();

            // test update
            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 



        }
    }
}
