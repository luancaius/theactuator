using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services.Actions
{
    public class Close : AbsAction
    {
        public override void Execute(List<string> parameters)
        {
            ActionManager._driver.Close();
        }
    }
}
