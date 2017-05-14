using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace LineCounter2000
{
    class Session
    {
        Dictionary<string, Project> project_dict;
        DateTime create_time;

        public Session()
        {
            project_dict = new Dictionary<string, Project>();
            create_time = DateTime.Now;
        }

        public bool addProject(string path)
        {
            if (project_dict.ContainsKey(path))
            {
                return false; 
            }

            Project p = new Project(path);
            project_dict.Add(path, p);
            return true; 
        }

        public int getTotLines()
        {
            int tot_lines = 0; 
            foreach(KeyValuePair<string, Project> p in project_dict)
            {
                tot_lines+=p.Value.getTotLines();
            }
            return tot_lines;
        }

        public int getTotUsedLines()
        {
            int tot_lines = 0;
            foreach (KeyValuePair<string, Project> p in project_dict)
            {
                tot_lines += p.Value.getTotUsedLines();
            }
            return tot_lines;
        }

    }
}
