using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAnCuoiKi
{
    public partial class ProjectForm : Form
    {
        private ProjectManager projectManager;
        private TaskManager taskManager;
        private ProjectSaveButton saveButton;
        private ProjectListBoxManager ProjectListBoxManager;
        private TaskListBoxManager taskListBoxManager;
        private ButtonDeleteProjectAdd deleteProjectAddButton;
        public ProjectForm()
        {
            InitializeComponent();
            projectManager = new ProjectManager();
            taskManager = new TaskManager(LBTaskInProject, txtShowInfoTaskInProject);
            saveButton = new ProjectSaveButton(projectManager);
            ProjectListBoxManager = new ProjectListBoxManager(LBProjectList, projectManager);
            ProjectListBoxManager.LoadProjectsToListBox();
            taskListBoxManager = new TaskListBoxManager(LBTaskInProject, taskManager, LBProjectList);
            deleteProjectAddButton = new ButtonDeleteProjectAdd(txtProjectName, dateTimePickerStartDate, dateTimePickerEndDate, txtTarget, comboBoxStatus, txtDescription);
        }

        public void btnSaveProject_Click(object sender, EventArgs e)
        {
            string name = txtProjectName.Text;
            string target = txtTarget.Text;
            DateTime startDate = dateTimePickerStartDate.Value;
            DateTime endDate = dateTimePickerEndDate.Value;
            string status = comboBoxStatus.SelectedItem?.ToString();
            string description = txtDescription.Text;
            string projectId = projectManager.GenerateProjectId();

            saveButton.SaveProject(name, target, startDate, endDate, description, status);

        }

        private void buttonDeleteProjectAdd_Click(object sender, EventArgs e)
        {
            deleteProjectAddButton.ResetControls();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProjectListBoxManager.RefreshProjectList();
        }

        private void btnDeleteProject_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dự án nào được chọn không
            if (LBProjectList.SelectedItem != null)
            {
                // Lấy dự án được chọn từ ListBox
                ListBoxItem<Project> selectedItem = (ListBoxItem<Project>)LBProjectList.SelectedItem;
                Project selectedProject = selectedItem.Value;

                // Xóa dự án khỏi ProjectManager
                projectManager.RemoveProject(selectedProject);

                // Làm mới ListBox để cập nhật danh sách dự án
                ProjectListBoxManager.RefreshProjectList();
            }
            else
            {
                MessageBox.Show("Please select a project to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchHelper.PerformSearch(projectManager, LBProjectList, txtSearch, ProjectStatusComboBox, ProjectStartDateTimePicker, ProjectEndDateTimePicker);
        }

        private void btnProjectChange_Click(object sender, EventArgs e)
        {

        }

        private void btnRefreshProjectTaskList_Click(object sender, EventArgs e)
        {
            taskListBoxManager.RefreshTaskList();
        }

        private void LBTaskInProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            taskManager.LBTaskInProject_SelectedIndexChanged(sender, e);
        }


        public class ListBoxItem<T>
        {
            public string DisplayText { get; set; }
            public T Value { get; set; }

            public ListBoxItem(string displayText, T value)
            {
                DisplayText = displayText;
                Value = value;
            }

            public override string ToString()
            {
                return DisplayText;
            }
        }
    }
}
