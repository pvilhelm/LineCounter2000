using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineCounter2000
{
    class Session
    {
        Dictionary<string, Project> path_project_dict;
        Dictionary<string, Project> file_project_dict;

        DateTime create_time;
        public string curr_dir; 

        public Session(string curr_dir)
        {
            path_project_dict = new Dictionary<string, Project>();
            file_project_dict = new Dictionary<string, Project>();

            create_time = DateTime.Now;
            this.curr_dir = curr_dir; 
        }

        public bool addProject(string path)
        {
            if (path_project_dict.ContainsKey(path))
            {
                return false; 
            }

            Project p = new Project(path);
            path_project_dict.Add(path, p);
            return true; 
        }

        public bool addFileToProject(string file_path)
        {
            if (file_project_dict.ContainsKey(file_path))
            {
                MessageBox.Show("File allready in a project.");
                return false; 
            }
            else
            {
                foreach(KeyValuePair<string,Project> kv in path_project_dict)
                {
                    if (file_path.Contains(kv.Key)){
                        kv.Value.addTextFile(file_path);
                        file_project_dict.Add(file_path, kv.Value);
                        return true; 
                    }
                }
            }

            return false; 
        }

        public int getTotLines()
        {
            int tot_lines = 0; 
            foreach(KeyValuePair<string, Project> p in path_project_dict)
            {
                tot_lines+=p.Value.getTotLines();
            }
            return tot_lines;
        }

        public int getTotUsedLines()
        {
            int tot_lines = 0;
            foreach (KeyValuePair<string, Project> p in path_project_dict)
            {
                tot_lines += p.Value.getTotUsedLines();
            }
            return tot_lines;
        }

    }
}
