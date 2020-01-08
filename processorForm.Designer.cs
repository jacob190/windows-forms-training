namespace ProcessorApp
{
    partial class processorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.processorName = new System.Windows.Forms.TextBox();
            this.processorCores = new System.Windows.Forms.TextBox();
            this.processorTdp = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.CoresLabel = new System.Windows.Forms.Label();
            this.tdpLabel = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // processorName
            // 
            this.processorName.Location = new System.Drawing.Point(9, 25);
            this.processorName.Name = "processorName";
            this.processorName.Size = new System.Drawing.Size(204, 20);
            this.processorName.TabIndex = 0;
            this.processorName.UseWaitCursor = true;
            this.processorName.TextChanged += new System.EventHandler(this.processorName_TextChanged);
            // 
            // processorCores
            // 
            this.processorCores.Location = new System.Drawing.Point(9, 64);
            this.processorCores.Name = "processorCores";
            this.processorCores.Size = new System.Drawing.Size(204, 20);
            this.processorCores.TabIndex = 1;
            this.processorCores.UseWaitCursor = true;
            // 
            // processorTdp
            // 
            this.processorTdp.Location = new System.Drawing.Point(9, 103);
            this.processorTdp.Name = "processorTdp";
            this.processorTdp.Size = new System.Drawing.Size(204, 20);
            this.processorTdp.TabIndex = 2;
            this.processorTdp.UseWaitCursor = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(6, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name";
            this.nameLabel.UseWaitCursor = true;
            // 
            // CoresLabel
            // 
            this.CoresLabel.AutoSize = true;
            this.CoresLabel.Location = new System.Drawing.Point(6, 48);
            this.CoresLabel.Name = "CoresLabel";
            this.CoresLabel.Size = new System.Drawing.Size(34, 13);
            this.CoresLabel.TabIndex = 4;
            this.CoresLabel.Text = "Cores";
            this.CoresLabel.UseWaitCursor = true;
            // 
            // tdpLabel
            // 
            this.tdpLabel.AutoSize = true;
            this.tdpLabel.Location = new System.Drawing.Point(6, 87);
            this.tdpLabel.Name = "tdpLabel";
            this.tdpLabel.Size = new System.Drawing.Size(29, 13);
            this.tdpLabel.TabIndex = 5;
            this.tdpLabel.Text = "TDP";
            this.tdpLabel.UseWaitCursor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 139);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 45);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.UseWaitCursor = true;
            this.btnAdd.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(118, 139);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 45);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.UseWaitCursor = true;
            // 
            // processorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 196);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tdpLabel);
            this.Controls.Add(this.CoresLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.processorTdp);
            this.Controls.Add(this.processorCores);
            this.Controls.Add(this.processorName);
            this.MaximumSize = new System.Drawing.Size(244, 235);
            this.MinimumSize = new System.Drawing.Size(244, 235);
            this.Name = "processorForm";
            this.Text = "Processor";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox processorName;
        private System.Windows.Forms.TextBox processorCores;
        private System.Windows.Forms.TextBox processorTdp;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label CoresLabel;
        private System.Windows.Forms.Label tdpLabel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}