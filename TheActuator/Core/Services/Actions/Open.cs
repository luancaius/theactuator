using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Core.Services.Actions
{
    public class Open : AbsAction
    {
        public Open()
        {
            Name = "Open";
        }

        public override void Execute(List<string> parameters)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--incognito");
            string path = Environment.CurrentDirectory;
            var driver = new ChromeDriver(path, options);
            ActionManager._driver = driver;
        }
    }
}
