using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            CheckedFileList.ElementContainer s =(CheckedFileList.ElementContainer)this.checkedFileList.SelectedItem;
            session.addProject(s.path);

        }

        private void checkedFileList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int i = e.Index;
            CheckedFileList cfl = this.checkedFileList;
            CheckedFileList.ElementContainer s = (CheckedFileList.ElementContainer)cfl.Items[i];
            if(e.NewValue == CheckState.Unchecked)
            {

            }
            else
            {
                this.session.addFileToProject(s.path);
            }
        }
    }
}

