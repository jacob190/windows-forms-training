using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessorApp
{
    public class Processors
    {
        public List<Processor> processors = new List<Processor>();

        public event Action<Processor> AddProcessorEvent;

        public void AddProcessor (Processor processor)
        {
            processors.Add(processor);
            AddProcessorEvent?.Invoke(processor);
        }

        public void UpdateProcessor(Processor processor)
        {


        }

        private void filterList()
        {

        }
    }
}
