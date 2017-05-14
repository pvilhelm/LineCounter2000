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

        public string current_dir;

        public CheckedFileList()
        {
            current_dir = Directory.GetCurrentDirectory();
            UpdateList();
        }

        

        public void UpdateList()
        {
            Items.Clear();

            Items.Add("..", false); 
            
            foreach (string i in Directory.EnumerateDirectories(current_dir))
            {
                Match m = Regex.Match(i, @"^\w\:\\.*?(.+\\)$");
                
                Items.Add(m.Groups[1], false);
            } 
            foreach (string i in Directory.EnumerateFiles(current_dir))
            {
                Match m = Regex.Match(i, @".*\\(.+$)");

                Items.Add(m.Groups[1], false);
            }
 
        }


    }
}
