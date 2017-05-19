using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineCounter2000
{
    public partial class Form1 : Form
    {

        Session session = new Session(@"c:\\");

        public Form1()
        {
            InitializeComponent();

            //
            this.currentDirTextBox.Text = session.curr_dir;
            this.checkedFileList.setSession(ref session);
            this.checkedFileList.UpdateList(session.curr_dir);

        }

        private void currentDirTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void currentDirTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                string tmp = session.curr_dir;
                session.curr_dir = this.currentDirTextBox.Text;
                try
                {
                    this.checkedFileList.UpdateList(session.curr_dir);
                }
                catch (Exception f)
                {
                    MessageBox.Show("Could not read directory " + session.curr_dir + "\n" + f.ToString());
                    session.curr_dir = tmp;
                    this.checkedFileList.UpdateList(session.curr_dir);
                }
            }
        }

        private void makeSelectedIntoProject_Click(object sender, EventArgs e)
        {
            fn_makeSelectedIntoProject();
        }

        private void fn_makeSelectedIntoProject()
        {
            CheckedFileList.ElementContainer s = (CheckedFileList.ElementContainer)this.checkedFileList.SelectedItem;
            if (s.type == CheckedFileList.ElementContainer.ElementType.FOLDER)
            {
                session.addProject(s.path);
                updateStates();
            }
            else
            {
                MessageBox.Show("Selected item is not a folder");
            }
        }

        bool no_recursion_checkedFileList_ItemCheck = false;

        private void checkedFileList_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            if (no_recursion_checkedFileList_ItemCheck)
                return;
            else
                no_recursion_checkedFileList_ItemCheck = true;

            int i = e.Index;
            CheckedFileList cfl = this.checkedFileList;
            CheckedFileList.ElementContainer s = (CheckedFileList.ElementContainer)cfl.Items[i];

            if(e.NewValue == CheckState.Unchecked && e.CurrentValue != CheckState.Unchecked)
            {
                this.session.removeFileFromProject(s.path);
                updateStates();
            }
            else if(e.NewValue == CheckState.Checked && CheckState.Checked != e.CurrentValue && s.type == CheckedFileList.ElementContainer.ElementType.FILE)
            {
                this.session.addFileToProject(s.path);
                updateStates();
            }

            no_recursion_checkedFileList_ItemCheck = false; 


        }

        private void checkedFileList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updateLabels()
        {
            int tot_lines = session.getTotLines();
            int tot_used_lines = session.getTotUsedLines();
            this.totLinesLabel.Text = tot_lines.ToString();
            this.totUsedLinesTable.Text = tot_used_lines.ToString();
            this.currentDirTextBox.Text = session.curr_dir;
            this.sessionTextBox.Text = session.getTextRepresentation();
        }

        private void updateStates()
        {
            this.checkedFileList.UpdateList(session.curr_dir);
            updateLabels();
        }

        private void checkedFileList_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckedFileList chfl = (CheckedFileList)sender;

            CheckedFileList.ElementContainer ec = (CheckedFileList.ElementContainer)chfl.SelectedItem;

            if (ec == null)
                return;


            if (e.KeyChar == (char)Keys.Enter)
            {
                

                if (ec.type == CheckedFileList.ElementContainer.ElementType.FOLDER || ec.type == CheckedFileList.ElementContainer.ElementType.PROJECT_FOLDER)
                {
                    string path = ec.path;

                    if (path == "..")
                    {
                        path = session.curr_dir;
                        Match m = Regex.Match(path, @"((\w:\\\\(.+\\)*)(.*\\))|(\w:\\\\)");
                        if (m.Groups[2].Length != 0)
                        {
                            session.curr_dir = m.Groups[2].ToString();//parent folder
                            chfl.ClearSelected();
                            chfl.SetSelected(0, true);
                        }
                        else
                            session.curr_dir = m.Groups[5].ToString();//root level (stay put)

                    }
                    else
                    {
                        session.curr_dir = path;
                        chfl.ClearSelected();
                        chfl.SetSelected(0, true);
                    }
                    updateStates();
                }
            }
            else if(e.KeyChar == 'w' || e.KeyChar == 'W')
            {
                fn_makeSelectedIntoProject();
            }
            else if(e.KeyChar == 'e' || e.KeyChar == 'E')
            {
                if (ec.type == CheckedFileList.ElementContainer.ElementType.FILE)
                {
                    string path = ec.path;

                    if (path == "..")
                    {
                        return; //dont select ".." (parent folder)
                    }
                    else
                    {
                        session.addFileToProject(path);
                    }
                    updateStates();
                }
            }
            else if (e.KeyChar == 'q' || e.KeyChar == 'Q')
            {
                if (ec.type == CheckedFileList.ElementContainer.ElementType.INCLUDED_FILE)
                {
                    string path = ec.path;

                    if (path == "..")
                    {
                        return; //dont select ".." (parent folder)
                    }
                    else
                    {
                        session.removeFileFromProject(path);
                    }
                    updateStates();
                }
            }
        }
    }
}

