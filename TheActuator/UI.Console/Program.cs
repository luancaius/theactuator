
using Core.Services;
using System;

namespace UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var debug = false;
#if DEBUG
            debug = true;
#endif
            var service = new Service(debug);
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
            System.Console.WriteLine("Press any key to exit");
            System.Console.ReadLine();
        }
    }
}
