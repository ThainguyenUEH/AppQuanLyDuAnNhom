using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DoAnCuoiKi.ProjectForm;

namespace DoAnCuoiKi
{
    public class ProjectListBoxManager
    {
        private ListBox LBProjectList;
        private ProjectManager projectManager;

        public ProjectListBoxManager(ListBox listBox, ProjectManager manager)
        {
            LBProjectList = listBox;
            projectManager = manager;
        }

        public void LoadProjectsToListBox()
        {
            LBProjectList.Items.Clear();

            // Lấy danh sách dự án từ ProjectManager
            List<Project> projects = projectManager.GetProjects();

            // Thêm các dự án vào ListBox
            foreach (Project project in projects)
            {
                // Tạo một chuỗi để hiển thị dự án trong ListBox
                string displayText = $"{project.Name} - {project.Status}";

                // Thêm dự án vào ListBox
                LBProjectList.Items.Add(new ListBoxItem<Project>(displayText, project));
            }
        }

        public void RefreshProjectList()
        {
            // Load lại danh sách dự án từ ProjectManager
            LoadProjectsToListBox();
        }
    }
}
