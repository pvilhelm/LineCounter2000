namespace LineCounter2000
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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.currentDirTextBox = new System.Windows.Forms.TextBox();
            this.openFolderButton = new System.Windows.Forms.Button();
            this.checkedFileList = new LineCounter2000.CheckedFileList();
            this.makeSelectedIntoProject = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totUsedLinesTable = new System.Windows.Forms.Label();
            this.totLinesLabel = new System.Windows.Forms.Label();
            this.sessionTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1035, 1052);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 985);
            this.panel1.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.currentDirTextBox);
            this.flowLayoutPanel2.Controls.Add(this.openFolderButton);
            this.flowLayoutPanel2.Controls.Add(this.checkedFileList);
            this.flowLayoutPanel2.Controls.Add(this.makeSelectedIntoProject);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(480, 985);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // currentDirTextBox
            // 
            this.currentDirTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.currentDirTextBox.Location = new System.Drawing.Point(3, 3);
            this.currentDirTextBox.Name = "currentDirTextBox";
            this.currentDirTextBox.Size = new System.Drawing.Size(310, 26);
            this.currentDirTextBox.TabIndex = 1;
            this.currentDirTextBox.Text = "c://";
            this.currentDirTextBox.TextChanged += new System.EventHandler(this.currentDirTextBox_TextChanged);
            this.currentDirTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.currentDirTextBox_KeyPress);
            // 
            // openFolderButton
            // 
            this.openFolderButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.openFolderButton.Location = new System.Drawing.Point(319, 3);
            this.openFolderButton.Name = "openFolderButton";
            this.openFolderButton.Size = new System.Drawing.Size(84, 31);
            this.openFolderButton.TabIndex = 2;
            this.openFolderButton.Text = "Browse";
            this.openFolderButton.UseVisualStyleBackColor = true;
            // 
            // checkedFileList
            // 
            this.checkedFileList.FormattingEnabled = true;
            this.checkedFileList.ItemHeight = 20;
            this.checkedFileList.Items.AddRange(new object[] {
            ".."});
            this.checkedFileList.Location = new System.Drawing.Point(4, 42);
            this.checkedFileList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkedFileList.Name = "checkedFileList";
            this.checkedFileList.Size = new System.Drawing.Size(469, 364);
            this.checkedFileList.TabIndex = 4;
            this.checkedFileList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkedFileList_KeyPress);
            // 
            // makeSelectedIntoProject
            // 
            this.makeSelectedIntoProject.Location = new System.Drawing.Point(4, 416);
            this.makeSelectedIntoProject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.makeSelectedIntoProject.Name = "makeSelectedIntoProject";
            this.makeSelectedIntoProject.Size = new System.Drawing.Size(471, 35);
            this.makeSelectedIntoProject.TabIndex = 3;
            this.makeSelectedIntoProject.Text = "Make selected into project";
            this.makeSelectedIntoProject.UseVisualStyleBackColor = true;
            this.makeSelectedIntoProject.Click += new System.EventHandler(this.makeSelectedIntoProject_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel3.Controls.Add(this.sessionTextBox);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(490, 5);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(526, 981);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.totUsedLinesTable, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.totLinesLabel, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(522, 103);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total lines:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(4, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 52);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total used lines:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totUsedLinesTable
            // 
            this.totUsedLinesTable.AutoSize = true;
            this.totUsedLinesTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totUsedLinesTable.Location = new System.Drawing.Point(265, 51);
            this.totUsedLinesTable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totUsedLinesTable.Name = "totUsedLinesTable";
            this.totUsedLinesTable.Size = new System.Drawing.Size(253, 52);
            this.totUsedLinesTable.TabIndex = 1;
            this.totUsedLinesTable.Text = "-";
            this.totUsedLinesTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totLinesLabel
            // 
            this.totLinesLabel.AutoSize = true;
            this.totLinesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totLinesLabel.Location = new System.Drawing.Point(265, 0);
            this.totLinesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totLinesLabel.Name = "totLinesLabel";
            this.totLinesLabel.Size = new System.Drawing.Size(253, 51);
            this.totLinesLabel.TabIndex = 2;
            this.totLinesLabel.Text = "-";
            this.totLinesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sessionTextBox
            // 
            this.sessionTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sessionTextBox.Location = new System.Drawing.Point(3, 116);
            this.sessionTextBox.MaxLength = 65536;
            this.sessionTextBox.Multiline = true;
            this.sessionTextBox.Name = "sessionTextBox";
            this.sessionTextBox.ReadOnly = true;
            this.sessionTextBox.Size = new System.Drawing.Size(519, 865);
            this.sessionTextBox.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(74, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 1052);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox currentDirTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button openFolderButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totUsedLinesTable;
        private System.Windows.Forms.Label totLinesLabel;
        private System.Windows.Forms.Button makeSelectedIntoProject;
        private CheckedFileList checkedFileList;
        private System.Windows.Forms.TextBox sessionTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

