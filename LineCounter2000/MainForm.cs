namespace LineCounter2000
{
    partial class MainForm
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
 
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.flowLayoutPanel_left = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_left_top = new System.Windows.Forms.Panel();

            this.currentDirTextBox = new System.Windows.Forms.TextBox();
            this.openFolderButton = new System.Windows.Forms.Button();
            this.checkedFileList = new LineCounter2000.CheckedFileList();
            this.makeSelectedIntoProject = new System.Windows.Forms.Button();
            
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totUsedLinesTable = new System.Windows.Forms.Label();
            this.totLinesLabel = new System.Windows.Forms.Label();
            this.sessionTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);

            //this.flowLayoutPanel_left.SuspendLayout();
            //this.flowLayoutPanel_left_top.SuspendLayout();
             
            //this.SuspendLayout();

            //Setup parent window first
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 1024);
            
            this.Name = "MainForm";
            this.Text = "Line Counter 2000";

            this.Controls.Add(this.flowLayoutPanel_left);

            //Setup left flow layout
            this.flowLayoutPanel_left.BackColor = System.Drawing.Color.DarkGreen;

            this.flowLayoutPanel_left.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel_left.Anchor |= System.Windows.Forms.AnchorStyles.Right;
            this.flowLayoutPanel_left.Anchor |= System.Windows.Forms.AnchorStyles.Bottom;
            this.flowLayoutPanel_left.Anchor |= System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel_left.Dock |= System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel_left.Width = this.Width / 2;

            this.flowLayoutPanel_left.ResumeLayout(false);
            this.flowLayoutPanel_left.PerformLayout();

            this.flowLayoutPanel_left.Controls.Add(this.flowLayoutPanel_left_top);
            {
                this.flowLayoutPanel_left_top.BackColor = System.Drawing.Color.Wheat;

                this.flowLayoutPanel_left_top.Controls.Add(this.currentDirTextBox);
                this.flowLayoutPanel_left_top.Controls.Add(this.openFolderButton);

                this.flowLayoutPanel_left_top.Anchor = System.Windows.Forms.AnchorStyles.Left;
                this.flowLayoutPanel_left_top.Anchor |= System.Windows.Forms.AnchorStyles.Top;
                this.flowLayoutPanel_left_top.Anchor |= System.Windows.Forms.AnchorStyles.Right;
                this.flowLayoutPanel_left_top.Height = 40;
                this.flowLayoutPanel_left_top.Dock = System.Windows.Forms.DockStyle.Top;
                
                

                //this.currentDirTextBox
                {
                    var ctrl = this.currentDirTextBox;
                    ctrl.AutoSize = false;
                    ctrl.Anchor = System.Windows.Forms.AnchorStyles.Top;
                    ctrl.Anchor |= System.Windows.Forms.AnchorStyles.Left;
                    ctrl.Dock = System.Windows.Forms.DockStyle.Left;
                    ctrl.Width = (ctrl.Parent.Width - 200);
                    ctrl.Height = ctrl.Parent.Height;
                    ctrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                    
                    
                }
                {
                    var ctrl = this.openFolderButton;
                    ctrl.Anchor = System.Windows.Forms.AnchorStyles.Top;
                    ctrl.Anchor |= System.Windows.Forms.AnchorStyles.Right;
                    ctrl.Dock = System.Windows.Forms.DockStyle.Right;
                    ctrl.Width = 200; 
                }
                //this.flowLayoutPanel_left_top.Anchor = System.Windows.Forms.AnchorStyles.Left;
                //this.flowLayoutPanel_left_top.Anchor |= System.Windows.Forms.AnchorStyles.Top;
                
                //this.flowLayoutPanel_left_top.Dock = System.Windows.Forms.DockStyle.Top;
                
            }
            /*this.flowLayoutPanel_left.Controls.Add(this.checkedFileList);

            //checkedFileList
            this.checkedFileList.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkedFileList.Anchor |= System.Windows.Forms.AnchorStyles.Right;
            this.checkedFileList.Anchor |= System.Windows.Forms.AnchorStyles.Bottom;
            */


            


            this.flowLayoutPanel_left_top.ResumeLayout(false);
            this.flowLayoutPanel_left.ResumeLayout(false);

            this.flowLayoutPanel_left_top.PerformLayout();
            this.flowLayoutPanel_left.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
        private System.Windows.Forms.Panel flowLayoutPanel_left;
        private System.Windows.Forms.Panel flowLayoutPanel_left_top;

        private System.Windows.Forms.TextBox currentDirTextBox;
        
        private System.Windows.Forms.Button openFolderButton;
        
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