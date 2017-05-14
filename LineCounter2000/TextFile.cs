using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace LineCounter2000
{
    class TextFile
    {

        public enum FileType
        {
            PROGRAM_TEXT,
            OTHER_TEXT,
            UNKNOWN
        }

        public bool is_valid;

        public string file_name { get; set; }
        public string file_ext { get; set; }
        public string path { get; set; }
        public int nr_lines { get; set; }
        public int nr_used_lines { get; set; }
        
        public TextFile(string path)
        {
            this.path = path;
            this.file_name = Path.GetFileName(path);
            this.file_ext = Path.GetExtension(path);
            is_valid = parseFile();

        }

        bool parseFile()
        {
            FileStream fs;
            try
            {
                fs = File.OpenRead(path); //throws
            }
            catch(Exception e)
            {
                return false; 
            }

            StreamReader sr = new StreamReader(fs);

            for (;!sr.EndOfStream;)
            {
                string line = sr.ReadLine();
                nr_lines++;
                
                if (!Regex.IsMatch(line, @"^[\t\s]*\n?$"))
                {//check if empty line
                    nr_used_lines++;
                }
                if (nr_lines == 50000)
                {
                    return false; 
                }
            }

            return true;
        }

    }
}
