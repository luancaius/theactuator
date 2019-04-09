using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Data.Repositories
{
    public interface IRepository
    {
        List<string> GetSourceStream();        
    }
}
