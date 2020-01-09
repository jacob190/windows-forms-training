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
        private bool ToUpdate { get; set; } = false;

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

        private void UpdateProcessor()
        {
            Processor.Name = processorName.Text;
            Processor.Cores = processorCores.Text;
            Processor.TDP = processorTdp.Text;

        }

        private void CreateProcessor()
        {
            Processor processor = new Processor(processorName.Text, processorCores.Text, processorTdp.Text);
            ProcessorsList.AddProcessor(processor);

        }

        public void SetFields()
        {
            btnAdd.Text = "Update";
            processorName.Text = Processor.Name;
            processorCores.Text = Processor.Cores;
            processorTdp.Text = Processor.TDP;
        }


        public processorForm(Processor processor, Processors processorsList, bool toUpdate)
        {
            InitializeComponent();
            ProcessorsList = processorsList;
            Processor = processor;
            ToUpdate = toUpdate;
        }


        private void addBtn_Click(object sender, EventArgs e)
        {
            if (ToUpdate)
            {
                UpdateProcessor();
                ToUpdate = false;
            }
            else
            {
                CreateProcessor();
            }

            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
