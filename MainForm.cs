using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi
{
    public partial class MainForm : Form
    {
        private bool isAdmin;
        public MainForm(bool isAdmin)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
            AdjustUI();
        }

        private Form? currentFormchild;
        private void OpenChildForm(Form childform)
        {
            if (currentFormchild != null)
            {
                currentFormchild.Close();
            }
            currentFormchild = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childform);
            panel_body.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void AdjustUI()
        {
            if (isAdmin)
            {
                // Hiển thị các chức năng chỉ dành cho admin
            }
            else
            {
                // Hiển thị các chức năng dành cho nhân viên
            }
        }

        private void pictureHome_Click(object sender, EventArgs e)
        {
            if (currentFormchild != null)
            {
                currentFormchild.Close();
            }
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProjectForm());
            labeltop.Text = btnProject.Text;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EmployeeForm());
            labeltop.Text = btnEmployee.Text;
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TaskForm());
            labeltop.Text = btnTask.Text;
        }
    }
}
