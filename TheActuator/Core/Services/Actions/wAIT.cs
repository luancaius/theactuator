using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Core.Services.Actions
{
    public class Wait : AbsAction
    {
        public Wait()
        {
            Name = "Wait";
        }

        public override void Execute(List<string> parameters)
        {
            var time = parameters[0];
            Thread.sleep(time);
        }
    }
}
