using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services.Actions
{
    interface IAction
    {
        string Name { get; }
        void Execute(List<String> parameters);
    }
}
