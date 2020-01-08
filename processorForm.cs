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
       private  Processors ProcessorsList { get; set; }
       private  Processor Processor { get; set; }


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



        public processorForm(Processor processor, Processors processorsList)
        {
            InitializeComponent();
            ProcessorsList = processorsList;
            Processor = processor;
        }


        private void addBtn_Click(object sender, EventArgs e)
        {
           
            Processor processor = new Processor( processorName.Text, processorCores.Text , processorTdp.Text );
            ProcessorsList.AddProcessor(processor);
            this.Close();
             
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
