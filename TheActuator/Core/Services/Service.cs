using Core.Model;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services
{
    public class Service
    {
        private IRepository _repository;
        private List<Command> _commands;
        private int _loop;        
        public Service(bool isDebugMode)
        {            
            ActionManager.LoadActions(isDebugMode);
        }
        public void AddSource(string filename)
        {
            _repository = new CSVRepository(filename);
        }

        public void Execute()
        {
            var lines = _repository.GetSourceStream();
            _loop = Convert.ToInt32(lines[0]);
            lines.RemoveAt(0);
            _commands = Util.Converter.LinesToCommands(lines);
            for(int i=0; i < _loop; i++)
            {
                foreach(var command in _commands)
                {
                    ActionManager.Execute(command);
                }
            }            
        }
    }
}
