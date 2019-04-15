using Ninject.Modules;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services.Actions
{
    public abstract class AbsAction
    {
        public string Name { get; set; }

        public abstract void Execute(List<String> parameters);
    }

    public class Binding : NinjectModule
    {
        public override void Load()
        {
            Bind<IWebDriver>().To<ChromeDriver>();
        }
    }
}
