
using Core.Services;

namespace UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new Service();
            var filename = "Sheet.csv";
            service.AddSource(filename);
            service.Execute();
            System.Console.ReadLine();
        }
    }
}
