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
        public event Action<Processor> EditProcessorEvent;

        public void AddProcessor (Processor processor)
        {
            processors.Add(processor);
            AddProcessorEvent?.Invoke(processor);
        }

        public void UpdateProcessor(Processor processor)
        {
            EditProcessorEvent?.Invoke(processor);

        }

        public List<Processor> GetFilteredProcessors(string value)
        {
            List<Processor> FilteredProcList =
                processors.Where(proc =>
                proc.Name.ToLower().Contains(value.ToLower()) ||
                proc.Cores.ToLower().Contains(value.ToLower()) ||
                proc.TDP.ToLower().Contains(value.ToLower())
                ).ToList();

            return FilteredProcList;
        }


    }
}
