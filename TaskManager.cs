using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static DoAnCuoiKi.ProjectForm;

namespace DoAnCuoiKi
{
    public class TaskManager
    {
        private ListBox LBTaskInProject;
        private TextBox txtShowInfoTaskInProject;

        public TaskManager(ListBox listBox, TextBox textBox)
        {
            LBTaskInProject = listBox;
            txtShowInfoTaskInProject = textBox;
        }

        public void LoadTasksToListBox(Project project)
        {
            // Xóa danh sách hiện tại trong ListBox
            LBTaskInProject.Items.Clear();

            // Lấy danh sách các task từ project
            List<Task> tasks = project.tasks;

            // Thêm từng task vào ListBox
            foreach (Task task in tasks)
            {
                // Tạo một chuỗi để hiển thị task trong ListBox
                string displayText = $"{task.TaskName} - Start Date: {task.StartDate.ToShortDateString()} - End Date: {task.EndDate.ToShortDateString()}";

                // Thêm task vào ListBox
                LBTaskInProject.Items.Add(new ListBoxItem<Task>(displayText, task));
            }
        }

        public void LBTaskInProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LBTaskInProject.SelectedItem != null)
            {
                // Lấy task được chọn từ ListBoxItem
                Task selectedTask = ((ListBoxItem<Task>)LBTaskInProject.SelectedItem).Value;

                // Hiển thị thông tin của task trong TextBox
                txtShowInfoTaskInProject.Text = $"Task Name: {selectedTask.TaskName}\r\nStart Date: {selectedTask.StartDate.ToShortDateString()}\r\nEnd Date: {selectedTask.EndDate.ToShortDateString()}\r\nProgress: {selectedTask.Progress}%";
            }
        }
    }
}
