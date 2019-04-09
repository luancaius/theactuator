using Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Util
{
    public static class Converter
    {
        public static List<Command> LinesToCommands(List<string> source)
        {
            var destin = new List<Command>();
            foreach (var item in source) {
                var temp = LineToCommand(item);
                destin.Add(temp);
            }
            return destin;
        }

        private static Command LineToCommand(string source)
        {
            var destin = new Command();
            var splits = source.Split(';');
            destin.Action = splits[0];
            destin.Params = new List<string>();

            destin.Params.InsertRange(1, splits);

            return destin;
        }
    }
}
