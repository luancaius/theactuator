
using Core.Services;
using System;

namespace UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new Service();
            var filename = "Sheet.csv";
            service.AddSource(filename);
            try
            {
                service.Execute();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            System.Console.ReadLine();
        }
    }
}
