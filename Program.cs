using System;
using log4net;

namespace MathApp
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();

            var math = new MyMathLibrary.MathOperations();
            Console.WriteLine("Сложение: " + math.Add(5, 3));
            Console.WriteLine("Вычитание: " + math.Subtract(5, 3));
        }
    }
}
