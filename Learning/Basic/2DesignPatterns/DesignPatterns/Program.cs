using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Design Patterns.

            Console.WriteLine("Hello World!");
            Console.ReadLine();

        }
    }

    class DesignPatternsFactoy <t> where t : IdesignPatternExample
    {
        private readonly IdesignPatternExample _IdesignPatternExample;
        public DesignPatternsFactoy(t DesignPatternExample)
        {
            _IdesignPatternExample = DesignPatternExample;
        }
    }

    interface IdesignPatternExample
    {
        public void Execute();
    }
    class Singleton : IdesignPatternExample
    {
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
