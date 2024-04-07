using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi
{
    public class ButtonDeleteProjectAdd
    {
        private TextBox txtProjectName;
        private DateTimePicker dateTimePickerStartDate;
        private DateTimePicker dateTimePickerEndDate;
        private TextBox txtTarget;
        private ComboBox comboBoxStatus;
        private TextBox txtDescription;

        public ButtonDeleteProjectAdd(TextBox projectNameTextBox, DateTimePicker startDatePicker, DateTimePicker endDatePicker, TextBox targetTextBox, ComboBox statusComboBox, TextBox descriptionTextBox)
        {
            txtProjectName = projectNameTextBox;
            dateTimePickerStartDate = startDatePicker;
            dateTimePickerEndDate = endDatePicker;
            txtTarget = targetTextBox;
            comboBoxStatus = statusComboBox;
            txtDescription = descriptionTextBox;
        }

        public void ResetControls()
        {
            // Đặt lại giá trị mặc định cho các điều khiển trên form
            txtProjectName.Text = "";
            dateTimePickerStartDate.Value = DateTime.Today;
            dateTimePickerEndDate.Value = DateTime.Today;
            txtTarget.Text = "";
            comboBoxStatus.SelectedIndex = -1;
            txtDescription.Text = "";
        }
    }
}
