using Core.Model;
using Core.Services.Actions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Core.Services
{
    public static class ActionManager
    {
        private static List<AbsAction> _actions = new List<AbsAction>();

        public static IWebDriver _driver { get; set; }

        public static void LoadActions()
        {
            var type = typeof(AbsAction);
            var actionClasses = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && !p.IsAbstract);

            foreach(var actionClass in actionClasses)
            {
                var instance = (AbsAction)Activator.CreateInstance(actionClass);
                _actions.Add(instance);
            }
        }

        public static void Execute(Command command)
        {
            var action = _actions.FirstOrDefault(a => String.Compare(a.Name, command.Action, true)==0);

            if (action != null)
            {
                action.Execute(command.Params);
                Thread.Sleep(1000);
            }
        }
    }
}
