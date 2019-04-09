
using Core.Services;

namespace UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new Service();
            var filename = "sheet1";
            service.AddSource(filename);
            service.Execute();
        }
    }
}
