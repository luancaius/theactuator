using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services.Actions
{
    public class Click : AbsAction
    {
        public Click()
        {
            Name = "Click";
        }

        public override void Execute(List<string> parameters)
        {
            var css = parameters[0];
            Console.WriteLine(css);
            var element = ActionManager._driver.FindElement(By.CssSelector(css));
            element.Click();
        }
    }
}
