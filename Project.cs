using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace DoAnCuoiKi
{
    public class Project
    {
        public List<Task> tasks { get; } = new List<Task>();
        public List<Employee> Employees { get; } = new List<Employee>();
        public string ProjectId { get; set; }

        public string Name { get; set; }
        public string Target { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public Project(string projectId, string name, string target, DateTime startDate, DateTime endDate, string description, string status)
        {
            ProjectId = projectId;
            Name = name;
            Target = target;
            StartDate = startDate;
            EndDate = endDate;
            Description = description;
            Status = status;
            Employees = new List<Employee>();

        }
        public void AddTask(Task task)
        {
            // Kiểm tra xem task có thuộc vào dự án không
            if (task.ProjectId != ProjectId)
            {
                throw new InvalidOperationException("Task does not belong to this project.");
            }

            tasks.Add(task); // Thêm task vào danh sách task của dự án
        }

        public void RemoveTask(Task task)
        {
            // Code để xóa một task khỏi project
        }

        public void UpdateStatus(string newStatus)
        {
            Status = newStatus;
        }

        public Task SearchTask(string taskId)
        {
            // Code để tìm kiếm một task trong project dựa trên taskId
            return null;
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee); // Thêm nhân viên vào danh sách nhân viên của dự án
        }

        private bool IsTaskBelongsToProject(Task task, string projectId)
        {

            if (task.ProjectId == projectId)
            {
                return true;
            }

            return false;
        }
    }
}
