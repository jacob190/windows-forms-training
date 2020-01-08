﻿using System;
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
        Processors ProcessorsList { get; set; }

        public processorForm(Processors processorsList)
        {
            InitializeComponent();
            ProcessorsList = processorsList;
        }

        private void processorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
           
            Processor processor = new Processor( processorName.Text, processorCores.Text , processorTdp.Text );

            ProcessorsList.AddProcessor(processor);

            this.Close();
             
        }
    }
}