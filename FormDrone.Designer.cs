namespace AT3_DroneQueues
{
    partial class FormDrone
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.grpPriority = new System.Windows.Forms.GroupBox();
            this.radioRegular = new System.Windows.Forms.RadioButton();
            this.radioExpress = new System.Windows.Forms.RadioButton();
            this.btnAddNewItem = new System.Windows.Forms.Button();
            this.btnRemoveReg = new System.Windows.Forms.Button();
            this.btnRemoveExp = new System.Windows.Forms.Button();
            this.listViewRegular = new System.Windows.Forms.ListView();
            this.colRegName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRegModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRegCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRegTag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRegProblem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewExpress = new System.Windows.Forms.ListView();
            this.colExpName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colExpModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colExpCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colExpTag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colExpProblem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listFinished = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbProblem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numUpDownTag = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpPriority.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTag)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Client Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip1.SetToolTip(this.label1, "Name of client");
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(83, 12);
            this.tbName.MaxLength = 500;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 20);
            this.tbName.TabIndex = 0;
            this.toolTip1.SetToolTip(this.tbName, "Input name of client");
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(83, 41);
            this.tbModel.MaxLength = 500;
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(121, 20);
            this.tbModel.TabIndex = 1;
            this.toolTip1.SetToolTip(this.tbModel, "Input model of the drone");
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(83, 70);
            this.tbCost.MaxLength = 500;
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(80, 20);
            this.tbCost.TabIndex = 2;
            this.tbCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.tbCost, "Input cost of service: If \"Express\" queue is \r\nchosen +15% will be added to input" +
        ".\r\n(only accepts positive value with 1 decimal point)");
            this.tbCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCost_KeyPress);
            // 
            // grpPriority
            // 
            this.grpPriority.Controls.Add(this.radioRegular);
            this.grpPriority.Controls.Add(this.radioExpress);
            this.grpPriority.Location = new System.Drawing.Point(530, 15);
            this.grpPriority.Name = "grpPriority";
            this.grpPriority.Size = new System.Drawing.Size(90, 68);
            this.grpPriority.TabIndex = 4;
            this.grpPriority.TabStop = false;
            this.grpPriority.Text = "Queue Priority";
            this.toolTip1.SetToolTip(this.grpPriority, "Select which queue to enter\r\n(A queue must be selected to add an item)");
            // 
            // radioRegular
            // 
            this.radioRegular.AutoSize = true;
            this.radioRegular.Location = new System.Drawing.Point(6, 19);
            this.radioRegular.Name = "radioRegular";
            this.radioRegular.Size = new System.Drawing.Size(62, 17);
            this.radioRegular.TabIndex = 0;
            this.radioRegular.TabStop = true;
            this.radioRegular.Tag = "";
            this.radioRegular.Text = "Regular";
            this.toolTip1.SetToolTip(this.radioRegular, "Regular Queue: Default cost");
            this.radioRegular.UseVisualStyleBackColor = true;
            // 
            // radioExpress
            // 
            this.radioExpress.AutoSize = true;
            this.radioExpress.Location = new System.Drawing.Point(6, 42);
            this.radioExpress.Name = "radioExpress";
            this.radioExpress.Size = new System.Drawing.Size(62, 17);
            this.radioExpress.TabIndex = 1;
            this.radioExpress.TabStop = true;
            this.radioExpress.Text = "Express";
            this.toolTip1.SetToolTip(this.radioExpress, "Express Queue: Costs +15% extra");
            this.radioExpress.UseVisualStyleBackColor = true;
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.Location = new System.Drawing.Point(190, 90);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(85, 23);
            this.btnAddNewItem.TabIndex = 23;
            this.btnAddNewItem.Text = "Add to Queue";
            this.toolTip1.SetToolTip(this.btnAddNewItem, "Adds new item to the chosen queue");
            this.btnAddNewItem.UseVisualStyleBackColor = true;
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // btnRemoveReg
            // 
            this.btnRemoveReg.Location = new System.Drawing.Point(281, 90);
            this.btnRemoveReg.Name = "btnRemoveReg";
            this.btnRemoveReg.Size = new System.Drawing.Size(126, 23);
            this.btnRemoveReg.TabIndex = 24;
            this.btnRemoveReg.Text = "Remove Regular Item";
            this.toolTip1.SetToolTip(this.btnRemoveReg, "Remove/dequeue oldest item from \"Regular Queue\"");
            this.btnRemoveReg.UseVisualStyleBackColor = true;
            this.btnRemoveReg.Click += new System.EventHandler(this.btnRemoveReg_Click);
            // 
            // btnRemoveExp
            // 
            this.btnRemoveExp.Location = new System.Drawing.Point(413, 90);
            this.btnRemoveExp.Name = "btnRemoveExp";
            this.btnRemoveExp.Size = new System.Drawing.Size(119, 23);
            this.btnRemoveExp.TabIndex = 25;
            this.btnRemoveExp.Text = "Remove Express Item";
            this.toolTip1.SetToolTip(this.btnRemoveExp, "Remove/dequeue oldest item from \"Express Queue\"");
            this.btnRemoveExp.UseVisualStyleBackColor = true;
            this.btnRemoveExp.Click += new System.EventHandler(this.btnRemoveExp_Click);
            // 
            // listViewRegular
            // 
            this.listViewRegular.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRegName,
            this.colRegModel,
            this.colRegCost,
            this.colRegTag,
            this.colRegProblem});
            this.listViewRegular.FullRowSelect = true;
            this.listViewRegular.GridLines = true;
            this.listViewRegular.HideSelection = false;
            this.listViewRegular.Location = new System.Drawing.Point(15, 147);
            this.listViewRegular.MultiSelect = false;
            this.listViewRegular.Name = "listViewRegular";
            this.listViewRegular.Size = new System.Drawing.Size(445, 171);
            this.listViewRegular.TabIndex = 26;
            this.toolTip1.SetToolTip(this.listViewRegular, "Click a record to display its name & \r\nproblem in the textboxes");
            this.listViewRegular.UseCompatibleStateImageBehavior = false;
            this.listViewRegular.View = System.Windows.Forms.View.Details;
            this.listViewRegular.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewRegular_MouseClick);
            // 
            // colRegName
            // 
            this.colRegName.Text = "Name";
            // 
            // colRegModel
            // 
            this.colRegModel.Text = "Model";
            this.colRegModel.Width = 45;
            // 
            // colRegCost
            // 
            this.colRegCost.Text = "Cost";
            this.colRegCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colRegCost.Width = 45;
            // 
            // colRegTag
            // 
            this.colRegTag.Text = "Tag";
            this.colRegTag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colRegTag.Width = 40;
            // 
            // colRegProblem
            // 
            this.colRegProblem.Text = "Problem";
            this.colRegProblem.Width = 250;
            // 
            // listViewExpress
            // 
            this.listViewExpress.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colExpName,
            this.colExpModel,
            this.colExpCost,
            this.colExpTag,
            this.colExpProblem});
            this.listViewExpress.FullRowSelect = true;
            this.listViewExpress.GridLines = true;
            this.listViewExpress.HideSelection = false;
            this.listViewExpress.Location = new System.Drawing.Point(15, 345);
            this.listViewExpress.MultiSelect = false;
            this.listViewExpress.Name = "listViewExpress";
            this.listViewExpress.Size = new System.Drawing.Size(445, 170);
            this.listViewExpress.TabIndex = 27;
            this.toolTip1.SetToolTip(this.listViewExpress, "Click a record to display its name & \r\nproblem in the textboxes");
            this.listViewExpress.UseCompatibleStateImageBehavior = false;
            this.listViewExpress.View = System.Windows.Forms.View.Details;
            this.listViewExpress.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewExpress_MouseClick);
            // 
            // colExpName
            // 
            this.colExpName.Text = "Name";
            // 
            // colExpModel
            // 
            this.colExpModel.Text = "Model";
            this.colExpModel.Width = 45;
            // 
            // colExpCost
            // 
            this.colExpCost.Text = "Cost";
            this.colExpCost.Width = 45;
            // 
            // colExpTag
            // 
            this.colExpTag.Text = "Tag";
            this.colExpTag.Width = 40;
            // 
            // colExpProblem
            // 
            this.colExpProblem.Text = "Problem";
            this.colExpProblem.Width = 250;
            // 
            // listFinished
            // 
            this.listFinished.FormattingEnabled = true;
            this.listFinished.Location = new System.Drawing.Point(466, 147);
            this.listFinished.Name = "listFinished";
            this.listFinished.Size = new System.Drawing.Size(154, 368);
            this.listFinished.TabIndex = 28;
            this.toolTip1.SetToolTip(this.listFinished, "Double click an item to delete it from the list");
            this.listFinished.DoubleClick += new System.EventHandler(this.listFinished_DoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(466, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 26);
            this.label7.TabIndex = 31;
            this.label7.Text = "Finished List: \r\n (Double click to delete item)";
            this.toolTip1.SetToolTip(this.label7, "Finished List: Repaired items waiting for pickup. \r\nDouble click an item to delet" +
        "e it from the list");
            this.label7.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Drone Model";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip1.SetToolTip(this.label2, "Model of the client\'s drone");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Service Cost";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip1.SetToolTip(this.label3, "Cost to service the drone: If \"Express\" queue \r\nis chosen +15% will be added to i" +
        "nput.\r\n(only accepts positive value with 1 decimal point)");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Problem to Service";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip1.SetToolTip(this.label5, "What needs to be repaired");
            // 
            // tbProblem
            // 
            this.tbProblem.Location = new System.Drawing.Point(228, 20);
            this.tbProblem.Multiline = true;
            this.tbProblem.Name = "tbProblem";
            this.tbProblem.Size = new System.Drawing.Size(285, 65);
            this.tbProblem.TabIndex = 3;
            this.toolTip1.SetToolTip(this.tbProblem, "Input the problem with the drone");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(371, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Regular Queue: (Click a record to display its name & problem in the textboxes)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip1.SetToolTip(this.label4, "Regular Queue: Default cost");
            this.label4.UseMnemonic = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(371, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Express Queue: (Click a record to display its name & problem in the textboxes)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip1.SetToolTip(this.label6, "Express Queue: Costs +15% extra");
            this.label6.UseMnemonic = false;
            // 
            // numUpDownTag
            // 
            this.numUpDownTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDownTag.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDownTag.Location = new System.Drawing.Point(83, 96);
            this.numUpDownTag.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.numUpDownTag.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numUpDownTag.Name = "numUpDownTag";
            this.numUpDownTag.Size = new System.Drawing.Size(80, 20);
            this.numUpDownTag.TabIndex = 5;
            this.numUpDownTag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.numUpDownTag, "Input service tag: Tag incremented \r\nbefore a new item added to queue.\r\n(max: 900" +
        ", min:100)");
            this.numUpDownTag.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Service Tag";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip1.SetToolTip(this.label8, "Service Tag: Tag incremented \r\nbefore a new item added to queue.\r\n(max: 900, min:" +
        "100)");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statStripLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 522);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(632, 22);
            this.statusStrip1.TabIndex = 16;
            // 
            // statStripLabel
            // 
            this.statStripLabel.AutoToolTip = true;
            this.statStripLabel.Name = "statStripLabel";
            this.statStripLabel.Size = new System.Drawing.Size(617, 17);
            this.statStripLabel.Spring = true;
            this.statStripLabel.Text = "Status: New form opened";
            this.statStripLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormDrone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 544);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numUpDownTag);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listFinished);
            this.Controls.Add(this.listViewExpress);
            this.Controls.Add(this.listViewRegular);
            this.Controls.Add(this.btnRemoveExp);
            this.Controls.Add(this.btnRemoveReg);
            this.Controls.Add(this.btnAddNewItem);
            this.Controls.Add(this.grpPriority);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbProblem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Name = "FormDrone";
            this.Text = "Drone Service App";
            this.grpPriority.ResumeLayout(false);
            this.grpPriority.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTag)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statStripLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbProblem;
        private System.Windows.Forms.GroupBox grpPriority;
        private System.Windows.Forms.RadioButton radioRegular;
        private System.Windows.Forms.RadioButton radioExpress;
        private System.Windows.Forms.Button btnAddNewItem;
        private System.Windows.Forms.Button btnRemoveReg;
        private System.Windows.Forms.Button btnRemoveExp;
        private System.Windows.Forms.ListView listViewRegular;
        private System.Windows.Forms.ColumnHeader colRegName;
        private System.Windows.Forms.ColumnHeader colRegModel;
        private System.Windows.Forms.ColumnHeader colRegCost;
        private System.Windows.Forms.ColumnHeader colRegTag;
        private System.Windows.Forms.ColumnHeader colRegProblem;
        private System.Windows.Forms.ListView listViewExpress;
        private System.Windows.Forms.ColumnHeader colExpName;
        private System.Windows.Forms.ColumnHeader colExpModel;
        private System.Windows.Forms.ColumnHeader colExpCost;
        private System.Windows.Forms.ColumnHeader colExpTag;
        private System.Windows.Forms.ColumnHeader colExpProblem;
        private System.Windows.Forms.ListBox listFinished;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numUpDownTag;
        private System.Windows.Forms.Label label8;
    }
}

