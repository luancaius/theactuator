using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Model
{
    public class Command
    {
        public string Action { get; set; }
        public List<string> Params { get; set; }
    }
}
