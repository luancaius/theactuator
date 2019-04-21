using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Core.Services.Actions
{
    public class Wait : AbsAction
    {
        public override void Execute(List<string> parameters)
        {
            var time = Convert.ToInt32(parameters[0]);
            Thread.Sleep(time);
        }
    }
}
