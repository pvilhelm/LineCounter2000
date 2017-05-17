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
                    Items.Add(new ElementContainer(i));
                }
                else
                {
                    Items.Add(new ElementContainer(i));
                }
            }
 
        }

        public class ElementContainer
        {
            public string path;
            public ElementType type; 

            public enum ElementType
            {
                FILE,
                FOLDER,
                PROJECT_FOLDER
            }

            public ElementContainer(string path) : this(path, false)
            {
                
            }

            public ElementContainer(string path, bool isProject)
            {
                this.path = path;

                if (Regex.IsMatch(path, @"\\$") | path.Equals(".."))//Is folder
                {
                    if(isProject)
                        this.type = ElementType.PROJECT_FOLDER;
                    else
                        this.type = ElementType.FOLDER;
                }
                else
                    this.type = ElementType.FILE;

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
                        if(this.type == ElementType.PROJECT_FOLDER)
                        {
                            return "Project: "+m.Groups[1].ToString();
                        }
                        else
                            return m.Groups[1].ToString();
                }
            }
        }
    }
}
