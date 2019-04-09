using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Data.Repositories
{
    public class CSVRepository : IRepository
    {
        private string _filename;
        public CSVRepository(string filename)
        {
            _filename = filename;
        }
        public List<String> GetSourceStream()
        {
            var lines = new List<string>();
            var reader = new StreamReader(File.OpenRead(_filename));            
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                lines.Add(line);
            }
            return lines;
        }
    }
}
