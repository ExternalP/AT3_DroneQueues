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
            this.radioExpress = new System.Windows.Forms.RadioButton();
            this.radioRegular = new System.Windows.Forms.RadioButton();
            this.btnAddNewItem = new System.Windows.Forms.Button();
            this.btnDequeueReg = new System.Windows.Forms.Button();
            this.btnDequeueExp = new System.Windows.Forms.Button();
            this.listViewRegular = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProblem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewExpress = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listFinished = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statStripLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbProblem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grpPriority.SuspendLayout();
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
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(83, 12);
            this.tbName.MaxLength = 500;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 20);
            this.tbName.TabIndex = 0;
            this.toolTip1.SetToolTip(this.tbName, "Input client\'s name here");
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(83, 41);
            this.tbModel.MaxLength = 500;
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(121, 20);
            this.tbModel.TabIndex = 1;
            this.toolTip1.SetToolTip(this.tbModel, "Input drone\'s model here");
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(83, 70);
            this.tbCost.MaxLength = 500;
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(121, 20);
            this.tbCost.TabIndex = 2;
            this.toolTip1.SetToolTip(this.tbCost, "Only allows positive numbers to be input");
            // 
            // grpPriority
            // 
            this.grpPriority.Controls.Add(this.radioExpress);
            this.grpPriority.Controls.Add(this.radioRegular);
            this.grpPriority.Location = new System.Drawing.Point(530, 15);
            this.grpPriority.Name = "grpPriority";
            this.grpPriority.Size = new System.Drawing.Size(90, 68);
            this.grpPriority.TabIndex = 4;
            this.grpPriority.TabStop = false;
            this.grpPriority.Text = "Queue Priority";
            this.toolTip1.SetToolTip(this.grpPriority, "Select rating of game");
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
            this.toolTip1.SetToolTip(this.radioExpress, "Select rating PG");
            this.radioExpress.UseVisualStyleBackColor = true;
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
            this.toolTip1.SetToolTip(this.radioRegular, "Select rating G");
            this.radioRegular.UseVisualStyleBackColor = true;
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.Location = new System.Drawing.Point(138, 96);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(85, 23);
            this.btnAddNewItem.TabIndex = 23;
            this.btnAddNewItem.Text = "Add to Queue";
            this.toolTip1.SetToolTip(this.btnAddNewItem, "Save records to definitions.dat");
            this.btnAddNewItem.UseVisualStyleBackColor = true;
            // 
            // btnDequeueReg
            // 
            this.btnDequeueReg.Location = new System.Drawing.Point(229, 96);
            this.btnDequeueReg.Name = "btnDequeueReg";
            this.btnDequeueReg.Size = new System.Drawing.Size(100, 23);
            this.btnDequeueReg.TabIndex = 24;
            this.btnDequeueReg.Text = "Dequeue Regular";
            this.toolTip1.SetToolTip(this.btnDequeueReg, "Save records to definitions.dat");
            this.btnDequeueReg.UseVisualStyleBackColor = true;
            // 
            // btnDequeueExp
            // 
            this.btnDequeueExp.Location = new System.Drawing.Point(335, 96);
            this.btnDequeueExp.Name = "btnDequeueExp";
            this.btnDequeueExp.Size = new System.Drawing.Size(100, 23);
            this.btnDequeueExp.TabIndex = 25;
            this.btnDequeueExp.Text = "Dequeue Express";
            this.toolTip1.SetToolTip(this.btnDequeueExp, "Save records to definitions.dat");
            this.btnDequeueExp.UseVisualStyleBackColor = true;
            // 
            // listViewRegular
            // 
            this.listViewRegular.AllowColumnReorder = true;
            this.listViewRegular.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnModel,
            this.columnCost,
            this.columnTag,
            this.columnProblem});
            this.listViewRegular.GridLines = true;
            this.listViewRegular.HideSelection = false;
            this.listViewRegular.Location = new System.Drawing.Point(15, 125);
            this.listViewRegular.MultiSelect = false;
            this.listViewRegular.Name = "listViewRegular";
            this.listViewRegular.ShowItemToolTips = true;
            this.listViewRegular.Size = new System.Drawing.Size(445, 173);
            this.listViewRegular.TabIndex = 26;
            this.toolTip1.SetToolTip(this.listViewRegular, "Click a record to display its name & \r\nproblem in the textboxes");
            this.listViewRegular.UseCompatibleStateImageBehavior = false;
            this.listViewRegular.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            // 
            // columnModel
            // 
            this.columnModel.Text = "Model";
            this.columnModel.Width = 45;
            // 
            // columnCost
            // 
            this.columnCost.Text = "Cost";
            this.columnCost.Width = 45;
            // 
            // columnTag
            // 
            this.columnTag.Text = "Tag";
            this.columnTag.Width = 40;
            // 
            // columnProblem
            // 
            this.columnProblem.Text = "Problem";
            this.columnProblem.Width = 250;
            // 
            // listViewExpress
            // 
            this.listViewExpress.AllowColumnReorder = true;
            this.listViewExpress.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewExpress.GridLines = true;
            this.listViewExpress.HideSelection = false;
            this.listViewExpress.Location = new System.Drawing.Point(15, 323);
            this.listViewExpress.MultiSelect = false;
            this.listViewExpress.Name = "listViewExpress";
            this.listViewExpress.ShowItemToolTips = true;
            this.listViewExpress.Size = new System.Drawing.Size(445, 170);
            this.listViewExpress.TabIndex = 27;
            this.toolTip1.SetToolTip(this.listViewExpress, "Click a record to display its name & \r\nproblem in the textboxes");
            this.listViewExpress.UseCompatibleStateImageBehavior = false;
            this.listViewExpress.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Model";
            this.columnHeader2.Width = 45;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cost";
            this.columnHeader3.Width = 45;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tag";
            this.columnHeader4.Width = 40;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Problem";
            this.columnHeader5.Width = 250;
            // 
            // listFinished
            // 
            this.listFinished.FormattingEnabled = true;
            this.listFinished.Location = new System.Drawing.Point(466, 125);
            this.listFinished.Name = "listFinished";
            this.listFinished.Size = new System.Drawing.Size(154, 368);
            this.listFinished.TabIndex = 28;
            this.toolTip1.SetToolTip(this.listFinished, "Double click to delete item from list");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statStripLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 527);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(632, 22);
            this.statusStrip1.TabIndex = 16;
            // 
            // statStripLabel1
            // 
            this.statStripLabel1.AutoToolTip = true;
            this.statStripLabel1.Name = "statStripLabel1";
            this.statStripLabel1.Size = new System.Drawing.Size(617, 17);
            this.statStripLabel1.Spring = true;
            this.statStripLabel1.Text = "Status: New form opened";
            this.statStripLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Service Problem";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbProblem
            // 
            this.tbProblem.Location = new System.Drawing.Point(228, 25);
            this.tbProblem.Multiline = true;
            this.tbProblem.Name = "tbProblem";
            this.tbProblem.Size = new System.Drawing.Size(277, 65);
            this.tbProblem.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Regular Queue";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Express Queue";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(500, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Finished List";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTip1.SetToolTip(this.label7, "Waiting for pickup");
            // 
            // FormDrone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 549);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listFinished);
            this.Controls.Add(this.listViewExpress);
            this.Controls.Add(this.listViewRegular);
            this.Controls.Add(this.btnDequeueExp);
            this.Controls.Add(this.btnDequeueReg);
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
        private System.Windows.Forms.ToolStripStatusLabel statStripLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbProblem;
        private System.Windows.Forms.GroupBox grpPriority;
        private System.Windows.Forms.RadioButton radioExpress;
        private System.Windows.Forms.RadioButton radioRegular;
        private System.Windows.Forms.Button btnAddNewItem;
        private System.Windows.Forms.Button btnDequeueReg;
        private System.Windows.Forms.Button btnDequeueExp;
        private System.Windows.Forms.ListView listViewRegular;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnModel;
        private System.Windows.Forms.ColumnHeader columnCost;
        private System.Windows.Forms.ColumnHeader columnTag;
        private System.Windows.Forms.ColumnHeader columnProblem;
        private System.Windows.Forms.ListView listViewExpress;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListBox listFinished;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

