using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LineCounter2000
{
    class Project
    {
        string root_path;
        Dictionary<string, TextFile> file_dict;

        public Project(string path)
        {
            root_path = path;
            file_dict = new Dictionary<string, TextFile>();
        }

        public bool addTextFile(string path)
        {
            if (file_dict.ContainsKey(path))
                return false;  

            TextFile f = new TextFile(path);
            if (f.is_valid)
            {
                file_dict.Add(path, f);
                return true;
            }
            return false; 
        }

        public int getTotLines()
        {
            int tot_lines = 0;
            foreach (KeyValuePair<string, TextFile> p in file_dict)
            {
                tot_lines += p.Value.nr_lines;
            }
            return tot_lines;
        }

        public int getTotUsedLines()
        {
            int tot_used_lines = 0;
            foreach (KeyValuePair<string, TextFile> p in file_dict)
            {
                tot_used_lines += p.Value.nr_used_lines;
            }
            return tot_used_lines;
        }

    }
}
