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
    public partial class ProcessorsForm : Form
    {
        public Processors processorsList = new Processors();
        
        public ProcessorsForm()
        {
            InitializeComponent();
        }

        #region methods 
        private void updateListItem(ListViewItem item)
        {
            Processor processor = (Processor)item.Tag;
          
            while (item.SubItems.Count < 3)
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
            item.SubItems[0].Text = processor.Name;
            item.SubItems[1].Text = processor.Cores;
            item.SubItems[2].Text = processor.TDP;
        }

        private void updateList(List<Processor> list)
        {
            processorsListView.Items.Clear();



            if (list == null)
            {
                foreach (Processor processor in processorsList.processors)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = processor;
                    updateListItem(item);
                    processorsListView.Items.Add(item);
                }
            }else
            {
                foreach (Processor processor in list)
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = processor;
                    updateListItem(item);
                    processorsListView.Items.Add(item);
                }
            }
        }

        private void updateItem()
        {
            if (processorsListView.SelectedItems.Count == 1)
            {
                Processor processor = (Processor)processorsListView.SelectedItems[0].Tag;
                processorForm processorForm = new processorForm(processor, processorsList);
               
                if (processorForm.ShowDialog() == DialogResult.OK)
                {
                    processor.Name = processorForm.ProcessorName;
                    processor.Cores = processorForm.ProcessorCores;
                    processor.TDP = processorForm.ProcessorTDP;

                    processorsList.UpdateProcessor(processor);
                }
            }
        }

     




        #endregion



        #region events


        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
           processorForm processorForm = new processorForm(null, processorsList);

           processorForm.ShowDialog();
         
        }

        private void ProcessorsForm_Load(object sender, EventArgs e)
        {
            updateList(null);
            processorsList.AddProcessorEvent += ProcessorsList_AddProcessorEvent;
        }

        private void ProcessorsList_AddProcessorEvent(Processor obj)
        {
            updateList(null);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            updateItem();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
           List<Processor> fillteredList = processorsList.GetFilteredProcessors(searchBox.Text);
           updateList(fillteredList);
        
        
        }
    }
}
#endregion