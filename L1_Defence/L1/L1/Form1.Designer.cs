namespace L1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortContainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblExperience = new System.Windows.Forms.Label();
            this.tbExperience = new System.Windows.Forms.TextBox();
            this.lblSalary1 = new System.Windows.Forms.Label();
            this.tbSalary1 = new System.Windows.Forms.TextBox();
            this.lbData = new System.Windows.Forms.ListBox();
            this.tbSalary2 = new System.Windows.Forms.TextBox();
            this.lblSalary2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.calculationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.CloseToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(71, 38);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(206, 44);
            this.OpenToolStripMenuItem.Text = "Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(206, 44);
            this.CloseToolStripMenuItem.Text = "Close";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(206, 44);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // calculationsToolStripMenuItem
            // 
            this.calculationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CalculateToolStripMenuItem,
            this.dsToolStripMenuItem,
            this.sortContainerToolStripMenuItem,
            this.RemoveToolStripMenuItem,
            this.InsertToolStripMenuItem});
            this.calculationsToolStripMenuItem.Name = "calculationsToolStripMenuItem";
            this.calculationsToolStripMenuItem.Size = new System.Drawing.Size(162, 38);
            this.calculationsToolStripMenuItem.Text = "Calculations";
            // 
            // dsToolStripMenuItem
            // 
            this.dsToolStripMenuItem.Name = "dsToolStripMenuItem";
            this.dsToolStripMenuItem.Size = new System.Drawing.Size(811, 44);
            this.dsToolStripMenuItem.Text = "Create container";
            this.dsToolStripMenuItem.Click += new System.EventHandler(this.CreateContainerToolStripMenuItem_Click);
            // 
            // CalculateToolStripMenuItem
            // 
            this.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem";
            this.CalculateToolStripMenuItem.Size = new System.Drawing.Size(811, 44);
            this.CalculateToolStripMenuItem.Text = "Calculate according selected criteria";
            this.CalculateToolStripMenuItem.Click += new System.EventHandler(this.CalculateAccordingSelectedCriteriaToolStripMenuItem_Click);
            // 
            // sortContainerToolStripMenuItem
            // 
            this.sortContainerToolStripMenuItem.Name = "sortContainerToolStripMenuItem";
            this.sortContainerToolStripMenuItem.Size = new System.Drawing.Size(811, 44);
            this.sortContainerToolStripMenuItem.Text = "Sort container";
            this.sortContainerToolStripMenuItem.Click += new System.EventHandler(this.SortContainerToolStripMenuItem_Click);
            // 
            // RemoveToolStripMenuItem
            // 
            this.RemoveToolStripMenuItem.Name = "RemoveToolStripMenuItem";
            this.RemoveToolStripMenuItem.Size = new System.Drawing.Size(811, 44);
            this.RemoveToolStripMenuItem.Text = "Remove unemployed people";
            this.RemoveToolStripMenuItem.Click += new System.EventHandler(this.RemoveUnemployedPeopleToolStripMenuItem_Click);
            // 
            // InsertToolStripMenuItem
            // 
            this.InsertToolStripMenuItem.Name = "InsertToolStripMenuItem";
            this.InsertToolStripMenuItem.Size = new System.Drawing.Size(811, 44);
            this.InsertToolStripMenuItem.Text = "Insert unemployed people who satisfy employer requirements";
            this.InsertToolStripMenuItem.Click += new System.EventHandler(this.InsertUnemployedPeopleToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExperience.Location = new System.Drawing.Point(56, 98);
            this.lblExperience.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(247, 33);
            this.lblExperience.TabIndex = 1;
            this.lblExperience.Text = "Select experience";
            // 
            // tbExperience
            // 
            this.tbExperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExperience.Location = new System.Drawing.Point(356, 96);
            this.tbExperience.Margin = new System.Windows.Forms.Padding(4);
            this.tbExperience.Name = "tbExperience";
            this.tbExperience.Size = new System.Drawing.Size(262, 40);
            this.tbExperience.TabIndex = 2;
            this.tbExperience.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBExperience_KeyPress);
            // 
            // lblSalary1
            // 
            this.lblSalary1.AutoSize = true;
            this.lblSalary1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary1.Location = new System.Drawing.Point(56, 198);
            this.lblSalary1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalary1.Name = "lblSalary1";
            this.lblSalary1.Size = new System.Drawing.Size(559, 33);
            this.lblSalary1.TabIndex = 3;
            this.lblSalary1.Text = "Select salary employee agrees to work for";
            // 
            // tbSalary1
            // 
            this.tbSalary1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSalary1.Location = new System.Drawing.Point(662, 194);
            this.tbSalary1.Margin = new System.Windows.Forms.Padding(4);
            this.tbSalary1.Name = "tbSalary1";
            this.tbSalary1.Size = new System.Drawing.Size(262, 40);
            this.tbSalary1.TabIndex = 4;
            this.tbSalary1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBSalary_KeyPress);
            // 
            // lbData
            // 
            this.lbData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbData.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lbData.FormattingEnabled = true;
            this.lbData.ItemHeight = 36;
            this.lbData.Location = new System.Drawing.Point(62, 363);
            this.lbData.Margin = new System.Windows.Forms.Padding(4);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(1364, 400);
            this.lbData.TabIndex = 5;
            // 
            // tbSalary2
            // 
            this.tbSalary2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSalary2.Location = new System.Drawing.Point(628, 281);
            this.tbSalary2.Margin = new System.Windows.Forms.Padding(4);
            this.tbSalary2.Name = "tbSalary2";
            this.tbSalary2.Size = new System.Drawing.Size(262, 40);
            this.tbSalary2.TabIndex = 6;
            this.tbSalary2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbSalary2_KeyPress);
            // 
            // lblSalary2
            // 
            this.lblSalary2.AutoSize = true;
            this.lblSalary2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary2.Location = new System.Drawing.Point(56, 285);
            this.lblSalary2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalary2.Name = "lblSalary2";
            this.lblSalary2.Size = new System.Drawing.Size(496, 33);
            this.lblSalary2.TabIndex = 7;
            this.lblSalary2.Text = "Select salary employer agrees to pay";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1062);
            this.Controls.Add(this.lblSalary2);
            this.Controls.Add(this.tbSalary2);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.tbSalary1);
            this.Controls.Add(this.lblSalary1);
            this.Controls.Add(this.tbExperience);
            this.Controls.Add(this.lblExperience);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Lab 1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculationsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.TextBox tbExperience;
        private System.Windows.Forms.Label lblSalary1;
        private System.Windows.Forms.TextBox tbSalary1;
        private System.Windows.Forms.ListBox lbData;
        private System.Windows.Forms.ToolStripMenuItem CalculateToolStripMenuItem;
        private System.Windows.Forms.TextBox tbSalary2;
        private System.Windows.Forms.Label lblSalary2;
        private System.Windows.Forms.ToolStripMenuItem RemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InsertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortContainerToolStripMenuItem;
    }
}

