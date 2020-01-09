using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessorApp
{
    public partial class processorForm : Form
    {
        private Processors ProcessorsList { get; set; }
        private Processor Processor { get; set; }

        public string ProcessorName
        {
            get { return processorName.Text; }
        }

        public string ProcessorCores
        {
            get { return processorCores.Text; }
        }

        public string ProcessorTDP
        {
            get { return processorTdp.Text; }
        }



        private void CreateProcessor()
        {
            Processor processor = new Processor(processorName.Text, processorCores.Text, processorTdp.Text);
            ProcessorsList.AddProcessor(processor);

        }


        public processorForm(Processor processor, Processors processorsList)
        {
            InitializeComponent();
            Processor = processor;
            ProcessorsList = processorsList;
            
        }




        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateProcessor();
            this.Close();
        }

        private void processorForm_Load(object sender, EventArgs e)
        {
            if (Processor != null)
            {
                processorName.Text = Processor.Name;
                processorCores.Text = Processor.Cores;
                processorTdp.Text = ProcessorTDP;
            }
        }
    }
}
