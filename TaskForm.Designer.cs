namespace DoAnCuoiKi
{
    partial class TaskForm
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
            tabPage1 = new TabPage();
            buttonDeleteProjectAdd = new Button();
            btnSaveTask = new Button();
            groupBox1 = new GroupBox();
            dateTimePickerEndDateTask = new DateTimePicker();
            dateTimePickerStartDateTask = new DateTimePicker();
            label7 = new Label();
            txtTaskName = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            button2 = new Button();
            button1 = new Button();
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
            tabPage3 = new TabPage();
            btnRefreshProjectTaskList = new Button();
            LBTaskInProject = new ListBox();
            txtShowInfoTaskInProject = new TextBox();
            tabPage4 = new TabPage();
            listBox1 = new ListBox();
            textBox5 = new TextBox();
            tabPage5 = new TabPage();
            PBTask = new ProgressBar();
            CBProjectToAddTask = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(0, 6);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 438);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.LightSteelBlue;
            tabPage1.Controls.Add(buttonDeleteProjectAdd);
            tabPage1.Controls.Add(btnSaveTask);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 405);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Thêm dự án";
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
            // 
            // btnSaveTask
            // 
            btnSaveTask.Location = new Point(677, 40);
            btnSaveTask.Name = "btnSaveTask";
            btnSaveTask.Size = new Size(94, 29);
            btnSaveTask.TabIndex = 1;
            btnSaveTask.Text = "Lưu";
            btnSaveTask.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Azure;
            groupBox1.Controls.Add(CBProjectToAddTask);
            groupBox1.Controls.Add(PBTask);
            groupBox1.Controls.Add(dateTimePickerEndDateTask);
            groupBox1.Controls.Add(dateTimePickerStartDateTask);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtTaskName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(36, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(598, 348);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "thêm công việc";
            // 
            // dateTimePickerEndDateTask
            // 
            dateTimePickerEndDateTask.CalendarFont = new Font("Segoe UI", 2F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerEndDateTask.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerEndDateTask.Location = new Point(379, 103);
            dateTimePickerEndDateTask.Name = "dateTimePickerEndDateTask";
            dateTimePickerEndDateTask.Size = new Size(185, 23);
            dateTimePickerEndDateTask.TabIndex = 14;
            dateTimePickerEndDateTask.Value = new DateTime(2024, 4, 7, 20, 26, 23, 0);
            // 
            // dateTimePickerStartDateTask
            // 
            dateTimePickerStartDateTask.CalendarFont = new Font("Segoe UI", 2F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerStartDateTask.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerStartDateTask.Location = new Point(99, 103);
            dateTimePickerStartDateTask.Name = "dateTimePickerStartDateTask";
            dateTimePickerStartDateTask.Size = new Size(184, 23);
            dateTimePickerStartDateTask.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(33, 226);
            label7.Name = "label7";
            label7.Size = new Size(116, 20);
            label7.TabIndex = 7;
            label7.Text = "Thêm vào dự án";
            // 
            // txtTaskName
            // 
            txtTaskName.Location = new Point(132, 38);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.Size = new Size(432, 36);
            txtTaskName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(33, 163);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 4;
            label5.Text = "Tiến độ";
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
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "tên công việc";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.LightSteelBlue;
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(LBProjectList);
            tabPage2.Controls.Add(btnDeleteProject);
            tabPage2.Controls.Add(ProjectStatusComboBox);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(btnSearch);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(ProjectEndDateTimePicker);
            tabPage2.Controls.Add(ProjectStartDateTimePicker);
            tabPage2.Controls.Add(txtSearch);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 405);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Danh sách dự án";
            // 
            // button2
            // 
            button2.Location = new Point(507, 248);
            button2.Name = "button2";
            button2.Size = new Size(250, 29);
            button2.TabIndex = 17;
            button2.Text = "Làm mới";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(507, 353);
            button1.Name = "button1";
            button1.Size = new Size(250, 29);
            button1.TabIndex = 16;
            button1.Text = "Sửa dự án";
            button1.UseVisualStyleBackColor = true;
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
            label9.Location = new Point(510, 186);
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
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(510, 119);
            label8.Name = "label8";
            label8.Size = new Size(97, 20);
            label8.TabIndex = 5;
            label8.Text = "ngày kết thúc";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(510, 55);
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
            // tabPage3
            // 
            tabPage3.BackColor = Color.LightSteelBlue;
            tabPage3.Controls.Add(btnRefreshProjectTaskList);
            tabPage3.Controls.Add(LBTaskInProject);
            tabPage3.Controls.Add(txtShowInfoTaskInProject);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 405);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Các công việc thuộc dự án";
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
            // tabPage4
            // 
            tabPage4.BackColor = Color.LightSteelBlue;
            tabPage4.Controls.Add(listBox1);
            tabPage4.Controls.Add(textBox5);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(792, 405);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Thông tin dự án";
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Left;
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(3, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(220, 399);
            listBox1.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.Dock = DockStyle.Right;
            textBox5.Location = new Point(223, 3);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ScrollBars = ScrollBars.Vertical;
            textBox5.Size = new Size(566, 399);
            textBox5.TabIndex = 1;
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
            // PBTask
            // 
            PBTask.Location = new Point(98, 163);
            PBTask.Name = "PBTask";
            PBTask.Size = new Size(466, 29);
            PBTask.TabIndex = 15;
            // 
            // CBProjectToAddTask
            // 
            CBProjectToAddTask.FormattingEnabled = true;
            CBProjectToAddTask.Location = new Point(155, 215);
            CBProjectToAddTask.Name = "CBProjectToAddTask";
            CBProjectToAddTask.Size = new Size(409, 38);
            CBProjectToAddTask.TabIndex = 16;
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "TaskForm";
            Text = "TaskForm";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        public TabPage tabPage1;
        private Button buttonDeleteProjectAdd;
        private Button btnSaveTask;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePickerEndDateTask;
        private DateTimePicker dateTimePickerStartDateTask;
        private Label label7;
        private TextBox txtTaskName;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private Button button2;
        private Button button1;
        private ListBox LBProjectList;
        private Button btnDeleteProject;
        private ComboBox ProjectStatusComboBox;
        private Label label9;
        private Button btnSearch;
        private Label label8;
        private Label label6;
        private DateTimePicker ProjectEndDateTimePicker;
        private DateTimePicker ProjectStartDateTimePicker;
        private TextBox txtSearch;
        private TabPage tabPage3;
        private Button btnRefreshProjectTaskList;
        private ListBox LBTaskInProject;
        private TextBox txtShowInfoTaskInProject;
        private TabPage tabPage4;
        private ListBox listBox1;
        private TextBox textBox5;
        private TabPage tabPage5;
        private ProgressBar PBTask;
        private ComboBox CBProjectToAddTask;
    }
}