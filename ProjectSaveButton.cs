using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi
{
    public class ProjectSaveButton
    {
        private ProjectManager projectManager;

        public ProjectSaveButton(ProjectManager manager)
        {
            projectManager = manager;
        }

        public void SaveProject(string name, string target, DateTime startDate, DateTime endDate, string description, string status)
        {
            try
            {
                string projectId = projectManager.GenerateProjectId();
                projectManager.AddProject(name, target, startDate, endDate, description, status);
                MessageBox.Show("Project saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
