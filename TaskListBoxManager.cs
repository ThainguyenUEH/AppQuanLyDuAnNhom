using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DoAnCuoiKi.ProjectForm;

namespace DoAnCuoiKi
{
    public class TaskListBoxManager
    {
        private ListBox taskListBox;
        private TaskManager taskManager;
        private ListBox projectListBox;

        public TaskListBoxManager(ListBox taskListBox, TaskManager taskManager, ListBox projectListBox)
        {
            this.taskListBox = taskListBox;
            this.taskManager = taskManager;
            this.projectListBox = projectListBox;
        }

        public void RefreshTaskList()
        {
            // Xóa tất cả các mục hiện có trong ListBox
            taskListBox.Items.Clear();

            if (projectListBox.SelectedItem != null)
            {
                // Lấy dự án được chọn từ ListBoxItem
                ListBoxItem<Project> selectedItem = (ListBoxItem<Project>)projectListBox.SelectedItem;
                Project selectedProject = selectedItem.Value;

                // Load lại danh sách nhiệm vụ cho dự án được chọn
                taskManager.LoadTasksToListBox(selectedProject);
            }
            else
            {
                // Hiển thị thông báo nếu không có dự án nào được chọn
                MessageBox.Show("Please select a project to refresh tasks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
