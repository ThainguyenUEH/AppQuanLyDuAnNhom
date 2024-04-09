using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi
{
    public class ProjectInfoDisplayManager
    {
        private TextBox TBProjectInfor;
        private ListBox LBProjectList2;
        private ProjectManager projectManager;

        public ProjectInfoDisplayManager(TextBox textBox, ListBox listBox, ProjectManager manager)
        {
            TBProjectInfor = textBox;
            LBProjectList2 = listBox;
            projectManager = manager;
        }

        public void DisplayProjectName()
        {
            LBProjectList2.Items.Clear();

            // Hiển thị danh sách tên dự án từ ProjectManager vào LBProjectList2
            List<Project> projects = projectManager.GetProjects();
            foreach (Project project in projects)
            {
                // Tạo một chuỗi để hiển thị tên dự án
                string displayText = project.Name;

                // Thêm tên dự án vào LBProjectList2
                LBProjectList2.Items.Add(displayText);
            }
        }

        public void DisplayProjectInfo()
        {
            // Hiển thị thông tin của dự án đang được chọn trong LBProjectList2
            if (LBProjectList2.SelectedIndex != -1)
            {
                // Lấy chỉ mục của dự án được chọn
                int selectedIndex = LBProjectList2.SelectedIndex;

                // Lấy danh sách dự án từ ProjectManager
                List<Project> projects = projectManager.GetProjects();

                // Kiểm tra xem chỉ mục có hợp lệ không
                if (selectedIndex >= 0 && selectedIndex < projects.Count)
                {
                    // Lấy dự án tương ứng với chỉ mục được chọn
                    Project selectedProject = projects[selectedIndex];

                    // Hiển thị thông tin của dự án đó vào TextBox TBProjectInfor
                    TBProjectInfor.Text = $"Name: {selectedProject.Name}\r\n" +
                                          $"Target: {selectedProject.Target}\r\n" +
                                          $"Start Date: {selectedProject.StartDate.ToShortDateString()}\r\n" +
                                          $"End Date: {selectedProject.EndDate.ToShortDateString()}\r\n" +
                                          $"Status: {selectedProject.Status}\r\n" +
                                          $"Description: {selectedProject.Description}";
                }
            }
            else
            {
                // Nếu không có dự án nào được chọn, xóa thông tin trong TextBox TBProjectInfor
                TBProjectInfor.Text = "";
            }
        }
    }
}
