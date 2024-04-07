using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi
{
    public class Task
    {
        public string TaskName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Progress { get; set; }
        public string ProjectId { get; set; }

        public Task(string taskName, Employee assignedEmployee, DateTime startDate, DateTime endDate, int progress, string projectId)
        {
            TaskName = taskName;
            StartDate = startDate;
            EndDate = endDate;
            Progress = progress;
            ProjectId = projectId;
            ProjectId = projectId;
        }

        public void UpdateProgress(int newProgress)
        {
            Progress = newProgress;
        }

        public DateTime GetDeadline()
        {
            return EndDate; // Trả về ngày hết hạn của task
        }
    }
}

