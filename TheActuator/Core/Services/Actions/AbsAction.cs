using Ninject.Modules;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;

namespace Core.Services.Actions
{
    public abstract class AbsAction
    {
        public string Name { get; set; }

        public bool IsDebug { get; set; }

        public AbsAction()
        {
            Name = GetType().Name;
        }

        public virtual void SetConfiguration(bool isDebugMode)
        {
            IsDebug = isDebugMode;
        }

        public virtual void DebugPrintConsole()
        {
            string info = "Executing " + Name + " action";
            Console.WriteLine(info);
        }

        public abstract void Execute(List<string> parameters);
    }

    public class Binding : NinjectModule
    {
        public override void Load()
        {
            Bind<IWebDriver>().To<ChromeDriver>();
        }
    }
}
