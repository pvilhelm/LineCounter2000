using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace LineCounter2000
{
    public class CheckedFileList : ListBox
    {

        public Session session = null;

        public CheckedFileList()
        { 
        }

        public void setSession(ref Session session) {
            this.session = session;
        }

        public void UpdateList(string current_dir)
        {

            try
            {
                IEnumerable<string> t = Directory.EnumerateDirectories(current_dir);

            }
            catch(Exception e)
            {
                MessageBox.Show("You don't have the rights to access this folder.");
                return;
            }

            int index_old = this.SelectedIndex;

            Items.Clear();

            Items.Add(new ElementContainer("..")); 

            


            foreach (string i in Directory.EnumerateDirectories(current_dir))
            {
                //Match m = Regex.Match(i, @"^\w\:\\\\.*?([^\\]+\\*)$");

                if (session.path_project_dict.ContainsKey(i+@"\"))
                {
                    Items.Add(new ElementContainer(i + @"\",true));
                }
                else
                {
                    Items.Add(new ElementContainer(i + @"\"));
                }

                
            } 
            foreach (string i in Directory.EnumerateFiles(current_dir))
            {
                //Match m = Regex.Match(i, @"\\([^\\]+)$");

                if (session.file_project_dict.ContainsKey(i))
                {
                    Items.Add(new ElementContainer(i,false,true));
                }
                else
                {
                    Items.Add(new ElementContainer(i));
                }
            }

            try
            {
                this.SetSelected(index_old, true);
            }
            catch(Exception e)
            {
                this.SetSelected(0,true);
            }
        }

        public class ElementContainer
        {
            public string path;
            public ElementType type; 

            public enum ElementType
            {
                FILE = 2,
                INCLUDED_FILE = 3,
                FOLDER = 4,
                PROJECT_FOLDER = 5
            }

            public ElementContainer(string path) : this(path, false)
            {
                
            }

            public ElementContainer(string path, bool isProject) : this(path, isProject, false)
            {
                
            }

            public ElementContainer(string path, bool isProject, bool isSelected)
            {
                this.path = path;

                if (Regex.IsMatch(path, @"\\$") | path.Equals(".."))//Is folder
                {
                    if (isProject)
                        this.type = ElementType.PROJECT_FOLDER;
                    else
                        this.type = ElementType.FOLDER;
                }
                else
                {
                    if (isSelected)
                        this.type = ElementType.INCLUDED_FILE;
                    else
                        this.type = ElementType.FILE;
                }

            }

            public override string ToString()
            {
                switch(path){
                    case "..":
                        return "..";
                    case ".":
                        return ".";
                    default:
                        Match m = Regex.Match(path, @"^\w\:\\\\.*?([^\\]+\\*)$");
                        if (this.type == ElementType.PROJECT_FOLDER)
                        {
                            return "Project: " + m.Groups[1].ToString();
                        }
                        else if(this.type == ElementType.INCLUDED_FILE)
                        {
                            return "* "+m.Groups[1].ToString();
                        }
                        else if(this.type == ElementType.FILE)
                        {
                            return m.Groups[1].ToString();
                        }
                        else if(this.type == ElementType.FOLDER)
                        {
                            return m.Groups[1].ToString();
                        }
                        else
                        {
                            throw new Exception("Invalid ElementType");

                        }
                }
            }
        }
    }
}
