using System.Windows.Forms;

namespace DoAnCuoiKi
{
    partial class ProjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabAddProject = new TabPage();
            buttonDeleteProjectAdd = new Button();
            btnSaveProject = new Button();
            groupBox1 = new GroupBox();
            dateTimePickerEndDate = new DateTimePicker();
            dateTimePickerStartDate = new DateTimePicker();
            comboBoxStatus = new ComboBox();
            txtTarget = new TextBox();
            txtDescription = new TextBox();
            label7 = new Label();
            txtProjectName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabProjectList = new TabPage();
            button2 = new Button();
            btnProjectChange = new Button();
            LBProjectList = new ListBox();
            btnDeleteProject = new Button();
            ProjectStatusComboBox = new ComboBox();
            label9 = new Label();
            btnSearch = new Button();
            label8 = new Label();
            label6 = new Label();
            ProjectEndDateTimePicker = new DateTimePicker();
            ProjectStartDateTimePicker = new DateTimePicker();
            txtSearch = new TextBox();
            tabTaskInProject = new TabPage();
            btnRefreshProjectTaskList = new Button();
            LBTaskInProject = new ListBox();
            txtShowInfoTaskInProject = new TextBox();
            tabTaskInProjectInfo = new TabPage();
            LBProjectList2 = new ListBox();
            TBProjectInfor = new TextBox();
            tabPage5 = new TabPage();
            tabControl1.SuspendLayout();
            tabAddProject.SuspendLayout();
            groupBox1.SuspendLayout();
            tabProjectList.SuspendLayout();
            tabTaskInProject.SuspendLayout();
            tabTaskInProjectInfo.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabAddProject);
            tabControl1.Controls.Add(tabProjectList);
            tabControl1.Controls.Add(tabTaskInProject);
            tabControl1.Controls.Add(tabTaskInProjectInfo);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 438);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
            // 
            // tabAddProject
            // 
            tabAddProject.BackColor = Color.LightSteelBlue;
            tabAddProject.Controls.Add(buttonDeleteProjectAdd);
            tabAddProject.Controls.Add(btnSaveProject);
            tabAddProject.Controls.Add(groupBox1);
            tabAddProject.Location = new Point(4, 29);
            tabAddProject.Name = "tabAddProject";
            tabAddProject.Padding = new Padding(3);
            tabAddProject.Size = new Size(792, 405);
            tabAddProject.TabIndex = 0;
            tabAddProject.Text = "Thêm dự án";
            // 
            // buttonDeleteProjectAdd
            // 
            buttonDeleteProjectAdd.Location = new Point(677, 80);
            buttonDeleteProjectAdd.Name = "buttonDeleteProjectAdd";
            buttonDeleteProjectAdd.Size = new Size(94, 29);
            buttonDeleteProjectAdd.TabIndex = 2;
            buttonDeleteProjectAdd.Text = "Xóa tất cả";
            buttonDeleteProjectAdd.TextImageRelation = TextImageRelation.TextAboveImage;
            buttonDeleteProjectAdd.UseVisualStyleBackColor = true;
            buttonDeleteProjectAdd.Click += buttonDeleteProjectAdd_Click;
            // 
            // btnSaveProject
            // 
            btnSaveProject.Location = new Point(677, 40);
            btnSaveProject.Name = "btnSaveProject";
            btnSaveProject.Size = new Size(94, 29);
            btnSaveProject.TabIndex = 1;
            btnSaveProject.Text = "Lưu";
            btnSaveProject.UseVisualStyleBackColor = true;
            btnSaveProject.Click += btnSaveProject_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Azure;
            groupBox1.Controls.Add(dateTimePickerEndDate);
            groupBox1.Controls.Add(dateTimePickerStartDate);
            groupBox1.Controls.Add(comboBoxStatus);
            groupBox1.Controls.Add(txtTarget);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtProjectName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(36, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(598, 348);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin dự án";
            // 
            // dateTimePickerEndDate
            // 
            dateTimePickerEndDate.CalendarFont = new Font("Segoe UI", 2F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerEndDate.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerEndDate.Location = new Point(379, 103);
            dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            dateTimePickerEndDate.Size = new Size(185, 23);
            dateTimePickerEndDate.TabIndex = 14;
            dateTimePickerEndDate.Value = new DateTime(2024, 4, 7, 20, 26, 23, 0);
            // 
            // dateTimePickerStartDate
            // 
            dateTimePickerStartDate.CalendarFont = new Font("Segoe UI", 2F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerStartDate.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerStartDate.Location = new Point(99, 103);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.Size = new Size(184, 23);
            dateTimePickerStartDate.TabIndex = 13;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "", "Chưa bắt đầu", "Đang trong tiến độ", "Hoàn thành", "Đã hủy" });
            comboBoxStatus.Location = new Point(132, 196);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(151, 28);
            comboBoxStatus.TabIndex = 12;
            // 
            // txtTarget
            // 
            txtTarget.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTarget.Location = new Point(132, 155);
            txtTarget.Name = "txtTarget";
            txtTarget.Size = new Size(432, 27);
            txtTarget.TabIndex = 9;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(33, 256);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(531, 86);
            txtDescription.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(33, 233);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 7;
            label7.Text = "Mô tả";
            // 
            // txtProjectName
            // 
            txtProjectName.Location = new Point(132, 38);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.Size = new Size(432, 36);
            txtProjectName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(33, 199);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 4;
            label5.Text = "Trạng thái";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(33, 158);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 3;
            label4.Text = "Mục tiêu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(310, 105);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 2;
            label3.Text = "Kết thúc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 103);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Bắt đầu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(33, 49);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên dự án";
            // 
            // tabProjectList
            // 
            tabProjectList.BackColor = Color.LightSteelBlue;
            tabProjectList.Controls.Add(button2);
            tabProjectList.Controls.Add(btnProjectChange);
            tabProjectList.Controls.Add(LBProjectList);
            tabProjectList.Controls.Add(btnDeleteProject);
            tabProjectList.Controls.Add(ProjectStatusComboBox);
            tabProjectList.Controls.Add(label9);
            tabProjectList.Controls.Add(btnSearch);
            tabProjectList.Controls.Add(label8);
            tabProjectList.Controls.Add(label6);
            tabProjectList.Controls.Add(ProjectEndDateTimePicker);
            tabProjectList.Controls.Add(ProjectStartDateTimePicker);
            tabProjectList.Controls.Add(txtSearch);
            tabProjectList.Location = new Point(4, 29);
            tabProjectList.Name = "tabProjectList";
            tabProjectList.Padding = new Padding(3);
            tabProjectList.Size = new Size(792, 405);
            tabProjectList.TabIndex = 1;
            tabProjectList.Text = "Danh sách dự án";
            // 
            // button2
            // 
            button2.Location = new Point(507, 248);
            button2.Name = "button2";
            button2.Size = new Size(250, 29);
            button2.TabIndex = 17;
            button2.Text = "Làm mới";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnProjectChange
            // 
            btnProjectChange.Location = new Point(507, 353);
            btnProjectChange.Name = "btnProjectChange";
            btnProjectChange.Size = new Size(250, 29);
            btnProjectChange.TabIndex = 16;
            btnProjectChange.Text = "Sửa dự án";
            btnProjectChange.UseVisualStyleBackColor = true;
            btnProjectChange.Click += btnProjectChange_Click;
            // 
            // LBProjectList
            // 
            LBProjectList.Dock = DockStyle.Left;
            LBProjectList.FormattingEnabled = true;
            LBProjectList.ImeMode = ImeMode.NoControl;
            LBProjectList.ItemHeight = 20;
            LBProjectList.Location = new Point(3, 3);
            LBProjectList.Name = "LBProjectList";
            LBProjectList.Size = new Size(475, 399);
            LBProjectList.TabIndex = 15;
            // 
            // btnDeleteProject
            // 
            btnDeleteProject.Location = new Point(507, 318);
            btnDeleteProject.Name = "btnDeleteProject";
            btnDeleteProject.Size = new Size(250, 29);
            btnDeleteProject.TabIndex = 14;
            btnDeleteProject.Text = "Xóa dự án";
            btnDeleteProject.UseVisualStyleBackColor = true;
            btnDeleteProject.Click += btnDeleteProject_Click;
            // 
            // ProjectStatusComboBox
            // 
            ProjectStatusComboBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ProjectStatusComboBox.FormattingEnabled = true;
            ProjectStatusComboBox.Items.AddRange(new object[] { "", "Chưa bắt đầu", "Đang trong tiến độ", "Hoàn thành", "Đã hủy" });
            ProjectStatusComboBox.Location = new Point(507, 206);
            ProjectStatusComboBox.Name = "ProjectStatusComboBox";
            ProjectStatusComboBox.Size = new Size(151, 28);
            ProjectStatusComboBox.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(507, 183);
            label9.Name = "label9";
            label9.Size = new Size(71, 20);
            label9.TabIndex = 8;
            label9.Text = "Tiến trình";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(507, 283);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(250, 29);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(507, 116);
            label8.Name = "label8";
            label8.Size = new Size(97, 20);
            label8.TabIndex = 5;
            label8.Text = "ngày kết thúc";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(507, 52);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 4;
            label6.Text = "Ngày bắt đầu";
            // 
            // ProjectEndDateTimePicker
            // 
            ProjectEndDateTimePicker.Location = new Point(507, 139);
            ProjectEndDateTimePicker.Name = "ProjectEndDateTimePicker";
            ProjectEndDateTimePicker.Size = new Size(250, 27);
            ProjectEndDateTimePicker.TabIndex = 3;
            // 
            // ProjectStartDateTimePicker
            // 
            ProjectStartDateTimePicker.Location = new Point(507, 75);
            ProjectStartDateTimePicker.Name = "ProjectStartDateTimePicker";
            ProjectStartDateTimePicker.Size = new Size(250, 27);
            ProjectStartDateTimePicker.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(507, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(277, 27);
            txtSearch.TabIndex = 1;
            txtSearch.Text = "Nhập tên dự án muốn tìm kiếm...";
            // 
            // tabTaskInProject
            // 
            tabTaskInProject.BackColor = Color.LightSteelBlue;
            tabTaskInProject.Controls.Add(btnRefreshProjectTaskList);
            tabTaskInProject.Controls.Add(LBTaskInProject);
            tabTaskInProject.Controls.Add(txtShowInfoTaskInProject);
            tabTaskInProject.Location = new Point(4, 29);
            tabTaskInProject.Name = "tabTaskInProject";
            tabTaskInProject.Padding = new Padding(3);
            tabTaskInProject.Size = new Size(792, 405);
            tabTaskInProject.TabIndex = 2;
            tabTaskInProject.Text = "Các công việc thuộc dự án";
            // 
            // btnRefreshProjectTaskList
            // 
            btnRefreshProjectTaskList.Dock = DockStyle.Right;
            btnRefreshProjectTaskList.Location = new Point(733, 3);
            btnRefreshProjectTaskList.Name = "btnRefreshProjectTaskList";
            btnRefreshProjectTaskList.Size = new Size(56, 399);
            btnRefreshProjectTaskList.TabIndex = 18;
            btnRefreshProjectTaskList.Text = "Làm mới";
            btnRefreshProjectTaskList.UseVisualStyleBackColor = true;
            btnRefreshProjectTaskList.Click += btnRefreshProjectTaskList_Click;
            // 
            // LBTaskInProject
            // 
            LBTaskInProject.Dock = DockStyle.Left;
            LBTaskInProject.FormattingEnabled = true;
            LBTaskInProject.ItemHeight = 20;
            LBTaskInProject.Location = new Point(3, 3);
            LBTaskInProject.Name = "LBTaskInProject";
            LBTaskInProject.Size = new Size(168, 399);
            LBTaskInProject.TabIndex = 2;
            LBTaskInProject.SelectedIndexChanged += LBTaskInProject_SelectedIndexChanged;
            // 
            // txtShowInfoTaskInProject
            // 
            txtShowInfoTaskInProject.Dock = DockStyle.Fill;
            txtShowInfoTaskInProject.Location = new Point(3, 3);
            txtShowInfoTaskInProject.Multiline = true;
            txtShowInfoTaskInProject.Name = "txtShowInfoTaskInProject";
            txtShowInfoTaskInProject.ScrollBars = ScrollBars.Vertical;
            txtShowInfoTaskInProject.Size = new Size(786, 399);
            txtShowInfoTaskInProject.TabIndex = 1;
            // 
            // tabTaskInProjectInfo
            // 
            tabTaskInProjectInfo.BackColor = Color.LightSteelBlue;
            tabTaskInProjectInfo.Controls.Add(LBProjectList2);
            tabTaskInProjectInfo.Controls.Add(TBProjectInfor);
            tabTaskInProjectInfo.Location = new Point(4, 29);
            tabTaskInProjectInfo.Name = "tabTaskInProjectInfo";
            tabTaskInProjectInfo.Padding = new Padding(3);
            tabTaskInProjectInfo.Size = new Size(792, 405);
            tabTaskInProjectInfo.TabIndex = 3;
            tabTaskInProjectInfo.Text = "Thông tin dự án";
            // 
            // LBProjectList2
            // 
            LBProjectList2.Dock = DockStyle.Left;
            LBProjectList2.FormattingEnabled = true;
            LBProjectList2.HorizontalScrollbar = true;
            LBProjectList2.ItemHeight = 20;
            LBProjectList2.Location = new Point(3, 3);
            LBProjectList2.Name = "LBProjectList2";
            LBProjectList2.Size = new Size(220, 399);
            LBProjectList2.TabIndex = 2;
            LBProjectList2.SelectedIndexChanged += LBProjectList2_SelectedIndexChanged;
            // 
            // TBProjectInfor
            // 
            TBProjectInfor.Dock = DockStyle.Right;
            TBProjectInfor.Location = new Point(223, 3);
            TBProjectInfor.Multiline = true;
            TBProjectInfor.Name = "TBProjectInfor";
            TBProjectInfor.ScrollBars = ScrollBars.Vertical;
            TBProjectInfor.Size = new Size(566, 399);
            TBProjectInfor.TabIndex = 1;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(792, 405);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // ProjectForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "ProjectForm";
            Text = "ProjectForm";
            tabControl1.ResumeLayout(false);
            tabAddProject.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabProjectList.ResumeLayout(false);
            tabProjectList.PerformLayout();
            tabTaskInProject.ResumeLayout(false);
            tabTaskInProject.PerformLayout();
            tabTaskInProjectInfo.ResumeLayout(false);
            tabTaskInProjectInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        public TabPage tabAddProject;
        private TabPage tabProjectList;
        private TabPage tabTaskInProject;
        private TabPage tabTaskInProjectInfo;
        private TabPage tabPage5;
        private GroupBox groupBox1;
        private TextBox txtProjectName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxStatus;
        private TextBox txtTarget;
        private TextBox txtDescription;
        private Label label7;
        private DateTimePicker dateTimePickerEndDate;
        private DateTimePicker dateTimePickerStartDate;
        private Button btnSaveProject;
        private Button buttonDeleteProjectAdd;
        private Label label8;
        private Label label6;
        private DateTimePicker ProjectEndDateTimePicker;
        private DateTimePicker ProjectStartDateTimePicker;
        private TextBox txtSearch;
        private ComboBox ProjectStatusComboBox;
        private Label label9;
        private Button btnSearch;
        private TextBox TBProjectInfor;
        private ListBox LBProjectList2;
        private Button btnDeleteProject;
        private ListBox LBTaskInProject;
        private TextBox txtShowInfoTaskInProject;
        private ListBox LBProjectList;
        private Button button2;
        private Button btnProjectChange;
        private Button btnRefreshProjectTaskList;
    }
}