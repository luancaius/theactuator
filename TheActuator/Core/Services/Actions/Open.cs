using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;


namespace Core.Services.Actions
{
    public class Open : IAction
    {
        public string Name { get; }
        public Open()
        {
            Name = "Open";
        }

        public void Execute(List<string> parameters)
        {            
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--incognito");
            var driver = new ChromeDriver("C:\\", options);

        }
    }
}
