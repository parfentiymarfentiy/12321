using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EntityFrameworkHM1
{
    internal class Categoryes
    {
        public Guid Id { get; set; } = Guid .NewGuid();
        public string Name { get; set;  }     

        public List<int> Example { get; set; }
    }
}