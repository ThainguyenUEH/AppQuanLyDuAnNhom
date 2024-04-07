namespace DoAnCuoiKi
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Kiểm tra đăng nhập và lấy vai trò của người dùng
            UserRole role = Authenticate(username, password);

            if (role == UserRole.Admin)
            {
                MainForm mainForm = new MainForm(true); // Truyền vào true cho vai trò admin
                mainForm.Show();
                this.Hide(); // Ẩn form đăng nhập sau khi đăng nhập thành công
            }
            else if (role == UserRole.Employees)
            {
                MainForm mainForm = new MainForm(false); // Truyền vào false cho vai trò nhân viên
                mainForm.Show();
                this.Hide(); // Ẩn form đăng nhập sau khi đăng nhập thành công
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!");
            }
        }
        private UserRole Authenticate(string username, string password)
        {
            if (username == "thai" && password == "12345")
            {
                return UserRole.Admin; // Trả về vai trò admin
            }
            else
            {
                return UserRole.Employees; // Trả về vai trò employee cho các trường hợp còn lại (Sửa sau)
            }
        }

    }
}

