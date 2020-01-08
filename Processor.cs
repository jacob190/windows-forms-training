using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessorApp
{
    public class Processor
    {
        public string Name
        {
            get;
            set;
        }

        public string Cores
        {
            get;
            set;
        }
        public string TDP
        {
            get;
            set;
        }

        public Processor()
        {
            Name = "-";
            Cores = "-";
            TDP = "-";
        }

        public Processor(string name, string cores, string tdp)
        {
            Name = name;
            Cores = cores;
            TDP = tdp;
        }

    
    }
}
