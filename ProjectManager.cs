using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi
{
    public class ProjectManager
    {
        public List<Project> projects; // Danh sách các project
        private string projectIdCounter = "P"; // Biến để tạo ID cho mỗi project

        public ProjectManager()
        {
            projects = new List<Project>(); // Khởi tạo danh sách projects
        }

        public void AddProject(string name, string target, DateTime startDate, DateTime endDate, string description, string status)
        {
            string projectId = GenerateProjectId(); // Tạo ID mới cho project
            Project project = new Project(projectId, name, target, startDate, endDate, description, status);
            projects.Add(project); // Thêm project vào danh sách projects
        }

        public List<Project> GetProjects()
        {
            return projects;
        }

        public string GenerateProjectId()
        {
            projectIdCounter += (projects.Count + 1).ToString();
            return projectIdCounter;
        }

        public void AddEmployeeToProject(string projectId, Employee employee)
        {
            Project project = projects.Find(p => p.ProjectId == projectId); // Tìm dự án có projectId tương ứng
            if (project != null)
            {
                project.AddEmployee(employee); // Thêm nhân viên vào dự án
            }
            else
            {
                throw new InvalidOperationException("Project not found.");
            }
        }

        public void RemoveProject(Project project)
        {
            // Kiểm tra xem dự án có tồn tại trong danh sách không
            if (projects.Contains(project))
            {
                // Xóa dự án khỏi danh sách
                projects.Remove(project);
            }
            else
            {
                throw new InvalidOperationException("Project not found.");
            }
        }
    }
}
