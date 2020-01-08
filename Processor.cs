using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessorApp
{
    public class Processor
    {
        private string Name
        {
            get;
            set;
        }

        private string Cores
        {
            get;
            set;
        }
        private string TDP
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
