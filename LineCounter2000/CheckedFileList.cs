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
    public class CheckedFileList : CheckedListBox
    {
        
        public CheckedFileList()
        { 
        }

        

        public void UpdateList(string current_dir)
        {
            Items.Clear();

            Items.Add(new ElementContainer(".."), false); 

            


            foreach (string i in Directory.EnumerateDirectories(current_dir))
            {
                //Match m = Regex.Match(i, @"^\w\:\\\\.*?([^\\]+\\*)$");

                Items.Add(new ElementContainer(i+@"\"), false);
            } 
            foreach (string i in Directory.EnumerateFiles(current_dir))
            {
                //Match m = Regex.Match(i, @"\\([^\\]+)$");

                Items.Add(new ElementContainer(i), false);
            }
 
        }

        public class ElementContainer
        {
            public string path;
            public ElementType type; 

            public enum ElementType
            {
                FILE,
                FOLDER
            }

            public ElementContainer(string path)
            {
                this.path = path;

                if (Regex.IsMatch(path, @"\\$") | path.Equals(".."))//Is folder
                {
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
                        return m.Groups[1].ToString();
                }
            }
        }
    }

   
}
