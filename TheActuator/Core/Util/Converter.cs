using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Util
{
    public static class Converter
    {
        public static List<Command> LinesToCommands(List<string> source)
        {
            var destin = new List<Command>();
            foreach (var item in source) {
                if (string.IsNullOrWhiteSpace(item))
                    break;
                var temp = LineToCommand(item);
                destin.Add(temp);
            }
            return destin;
        }

        private static Command LineToCommand(string source)
        {
            var destin = new Command();
            var splits = source.Split(';');
            splits = splits.Take(splits.Count() - 1).ToArray();

            destin.Action = splits[0];
            destin.Params = new List<string>();

            destin.Params.InsertRange(0, splits.Skip(1));

            return destin;
        }
    }
}
