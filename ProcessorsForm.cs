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



        private void updateItems()
        {

        }

        private void updateItem()
        {


        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
           processorForm processorForm = new processorForm(processorsList);

           processorForm.ShowDialog();
         
        }

        private void ProcessorsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
