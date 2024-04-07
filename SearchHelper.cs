using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DoAnCuoiKi.ProjectForm;

namespace DoAnCuoiKi
{
    public class SearchHelper
    {
        public static void PerformSearch(ProjectManager projectManager, ListBox LBProjectList, TextBox txtSearch, ComboBox ProjectStatusComboBox, DateTimePicker ProjectStartDateTimePicker, DateTimePicker ProjectEndDateTimePicker)
        {
            // Lấy các giá trị từ các điều khiển tìm kiếm
            string keyword = txtSearch.Text.ToLower();
            string selectedStatus = ProjectStatusComboBox.SelectedItem?.ToString().ToLower();
            DateTime startDate = ProjectStartDateTimePicker.Value.Date;
            DateTime endDate = ProjectEndDateTimePicker.Value.Date;

            // Xóa danh sách hiện tại trong ListBox
            LBProjectList.Items.Clear();

            // Lấy danh sách dự án từ ProjectManager
            List<Project> projects = projectManager.GetProjects();

            // Thêm các dự án vào ListBox nếu dự án đáp ứng ít nhất một trong các điều kiện tìm kiếm
            foreach (Project project in projects)
            {
                int matchCount = 0;

                // Kiểm tra tên dự án
                if (!string.IsNullOrEmpty(keyword) && project.Name.ToLower().Contains(keyword))
                {
                    matchCount++;
                }

                // Kiểm tra trạng thái
                if (!string.IsNullOrEmpty(selectedStatus) && project.Status.ToLower().Contains(selectedStatus))
                {
                    matchCount++;
                }

                // Kiểm tra ngày bắt đầu
                if (startDate == project.StartDate.Date)
                {
                    matchCount++;
                }

                // Kiểm tra ngày kết thúc
                if (endDate == project.EndDate.Date)
                {
                    matchCount++;
                }

                // Nếu dự án đáp ứng ít nhất một trong các điều kiện, thêm vào ListBox
                if (matchCount > 0)
                {
                    // Tạo một chuỗi để hiển thị dự án trong ListBox
                    string displayText = $"{project.Name} - {project.Status}";

                    // Thêm dự án vào ListBox
                    LBProjectList.Items.Add(new ListBoxItem<Project>(displayText, project));
                }
            }
        }
    }
}
