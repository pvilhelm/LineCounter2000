using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineCounter2000
{
    public class Session
    {
        public Dictionary<string, Project> path_project_dict;
        public Dictionary<string, Project> file_project_dict;

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
                MessageBox.Show("Folder is allready a project.");
                return false; 
            }

            foreach(KeyValuePair<string,Project> kv in path_project_dict)
            {
                if (path.Contains(kv.Key))
                {
                    MessageBox.Show("Selected folder allready part of project: " + kv.Key);
                    return false; 
                }
            }

            Project p = new Project(path);
            path_project_dict.Add(path, p);
            return true; 
        }

        public bool removeFileFromProject(string file_path)
        {
            if (!file_project_dict.ContainsKey(file_path))
            {
                MessageBox.Show("File not in a project.");
                return false;
            }
            else
            {
                Project project = this.file_project_dict[file_path];
                project.file_dict.Remove(file_path);
                this.file_project_dict.Remove(file_path);

                return true; 
            }
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
                MessageBox.Show("No project in this file's path.");
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

        public string getTextRepresentation()
        {
            StringBuilder strbld = new StringBuilder();

            strbld.AppendLine("Session has:");
            strbld.AppendLine("\tTotal lines:           " + getTotLines());
            strbld.AppendLine("\tTotal non-blank lines: " + getTotUsedLines());
            strbld.AppendLine("Added projects are:");
            foreach(KeyValuePair<string,Project> kv in path_project_dict)
            {
                strbld.AppendLine("\t"+kv.Value.getTotUsedLines()+"/"+kv.Value.getTotLines()+ " " + kv.Key);
            }
            return strbld.ToString();
        }

    }
}
