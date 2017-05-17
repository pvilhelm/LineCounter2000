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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.currentDirTextBox = new System.Windows.Forms.TextBox();
            this.openFolderButton = new System.Windows.Forms.Button();
            this.makeSelectedIntoProject = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totUsedLinesTable = new System.Windows.Forms.Label();
            this.totLinesLabel = new System.Windows.Forms.Label();
            this.checkedFileList = new LineCounter2000.CheckedFileList();
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
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(690, 684);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 640);
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
            this.flowLayoutPanel2.Size = new System.Drawing.Size(320, 640);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // currentDirTextBox
            // 
            this.currentDirTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.currentDirTextBox.Location = new System.Drawing.Point(2, 2);
            this.currentDirTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.currentDirTextBox.Name = "currentDirTextBox";
            this.currentDirTextBox.Size = new System.Drawing.Size(208, 20);
            this.currentDirTextBox.TabIndex = 1;
            this.currentDirTextBox.Text = "c://";
            this.currentDirTextBox.TextChanged += new System.EventHandler(this.currentDirTextBox_TextChanged);
            this.currentDirTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.currentDirTextBox_KeyPress);
            // 
            // openFolderButton
            // 
            this.openFolderButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.openFolderButton.Location = new System.Drawing.Point(214, 2);
            this.openFolderButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.openFolderButton.Name = "openFolderButton";
            this.openFolderButton.Size = new System.Drawing.Size(56, 20);
            this.openFolderButton.TabIndex = 2;
            this.openFolderButton.Text = "Browse";
            this.openFolderButton.UseVisualStyleBackColor = true;
            // 
            // makeSelectedIntoProject
            // 
            this.makeSelectedIntoProject.Location = new System.Drawing.Point(3, 271);
            this.makeSelectedIntoProject.Name = "makeSelectedIntoProject";
            this.makeSelectedIntoProject.Size = new System.Drawing.Size(314, 23);
            this.makeSelectedIntoProject.TabIndex = 3;
            this.makeSelectedIntoProject.Text = "Make selected into project";
            this.makeSelectedIntoProject.UseVisualStyleBackColor = true;
            this.makeSelectedIntoProject.Click += new System.EventHandler(this.makeSelectedIntoProject_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(327, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(351, 638);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(348, 67);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total lines:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total used lines:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totUsedLinesTable
            // 
            this.totUsedLinesTable.AutoSize = true;
            this.totUsedLinesTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totUsedLinesTable.Location = new System.Drawing.Point(177, 33);
            this.totUsedLinesTable.Name = "totUsedLinesTable";
            this.totUsedLinesTable.Size = new System.Drawing.Size(168, 34);
            this.totUsedLinesTable.TabIndex = 1;
            this.totUsedLinesTable.Text = "-";
            this.totUsedLinesTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totLinesLabel
            // 
            this.totLinesLabel.AutoSize = true;
            this.totLinesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totLinesLabel.Location = new System.Drawing.Point(177, 0);
            this.totLinesLabel.Name = "totLinesLabel";
            this.totLinesLabel.Size = new System.Drawing.Size(168, 33);
            this.totLinesLabel.TabIndex = 2;
            this.totLinesLabel.Text = "-";
            this.totLinesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkedFileList
            // 
            this.checkedFileList.FormattingEnabled = true;
            this.checkedFileList.Items.AddRange(new object[] {
            ".."});
            this.checkedFileList.Location = new System.Drawing.Point(3, 27);
            this.checkedFileList.Name = "checkedFileList";
            this.checkedFileList.Size = new System.Drawing.Size(314, 238);
            this.checkedFileList.TabIndex = 4;
            this.checkedFileList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkedFileList_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 684);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
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
    }
}

