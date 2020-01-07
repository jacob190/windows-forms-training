using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessorApp
{
    class Processor
    {
        private string Name
        {
            get;
            set;
        }

        private int Cores
        {
            get;
            set;
        }
        private int TDP
        {
            get;
            set;
        }

        public Processor()
        {
            Name = "-";
            Cores = 0;
            TDP = 0;
        }

        public Processor(string name, int cores, int tdp)
        {
            Name = name;
            Cores = cores;
            TDP = tdp;
        }

    
    }
}
