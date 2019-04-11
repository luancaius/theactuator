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
        public Service()
        {
            ActionManager.LoadActions();
        }
        public void AddSource(string filename)
        {
            _repository = new CSVRepository(filename);
        }

        public void Execute()
        {
            var lines = _repository.GetSourceStream();

            _commands = Util.Converter.LinesToCommands(lines);

            foreach(var command in _commands)
            {
                ActionManager.Execute(command);
            }
        }
    }
}
