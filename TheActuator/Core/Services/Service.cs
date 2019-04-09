using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services
{
    public class Service
    {
        private IRepository _repository;
        public void AddSource(string filename)
        {
            _repository = new CSVRepository(filename);
        }

        public void Execute()
        {
            var lines = _repository.GetSourceStream();

        }
    }
}
