using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services.Actions
{
    public class Click : AbsAction
    {
        private List<string> _parameters;
        public override void Execute(List<string> parameters)
        {
            _parameters = parameters;
            var css = parameters[0];
            Console.WriteLine(css);
            var element = ActionManager._driver.FindElement(By.CssSelector(css));
            element.Click();
        }

        public override void DebugPrintConsole()
        {
            var param1 = _parameters[0];
            var param2 = _parameters[1];
            Console.WriteLine("Executing " + Name + " on " +param1+" "+param2);
        }
    }
}
