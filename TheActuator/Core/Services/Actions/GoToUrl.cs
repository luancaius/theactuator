using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services.Actions
{
    public class GoToUrl : IAction
    {
        public string Name { get; }
        public GoToUrl()
        {
            Name = "GoToUrl";
        }

        public void Execute(List<string> parameters)
        {
            Console.WriteLine("Action = " + Name);
        }
    }
}
