using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services.Actions
{
    public class GoToUrl : AbsAction
    {
        public GoToUrl()
        {
            Name = "GoToUrl";
        }

        public override void Execute(List<string> parameters)
        {
            var url = parameters[0];
            ActionManager._driver.Navigate().GoToUrl(url);
        }
    }
}
