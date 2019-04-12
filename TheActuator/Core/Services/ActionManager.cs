using Core.Model;
using Core.Services.Actions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Services
{
    public static class ActionManager
    {
        private static List<IAction> _actions = new List<IAction>();

        public static void LoadActions()
        {
            var type = typeof(IAction);
            var actionClasses = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && p.IsClass);

            foreach(var actionClass in actionClasses)
            {
                var instance = (IAction)Activator.CreateInstance(actionClass);
                _actions.Add(instance);
            }
        }

        public static void Execute(Command command)
        {
            var action = _actions.FirstOrDefault(a => a.Name == command.Action);

            if (action != null)
            {
                action.Execute(command.Params);
            }
        }
    }
}
