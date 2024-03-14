using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lamthunecu
{
    public partial class Resgiter : Form
    {
        public Resgiter()
        {
            InitializeComponent();
        }
        private void Register_Load(object sender, EventArgs e)
        {
            // Khởi tạo form
            InitializeForm();
        }
        private void InitializeForm()
        {
            Label lblUsername = new Label();
            lblUsername.Text = "Username:";
            lblUsername.Location = new System.Drawing.Point(30, 30);
            this.Controls.Add(lblUsername);

            TextBox txtUsername = new TextBox();
            txtUsername.Location = new System.Drawing.Point(150, 30);
            this.Controls.Add(txtUsername);

            Label lblPassword = new Label();
            lblPassword.Text = "Password:";
            lblPassword.Location = new System.Drawing.Point(30, 60);
            this.Controls.Add(lblPassword);

            TextBox txtPassword = new TextBox();
            txtPassword.Location = new System.Drawing.Point(150, 60);
            txtPassword.PasswordChar = '*'; // Hiển thị ký tự sao cho mật khẩu
            this.Controls.Add(txtPassword);

            Button btnRegister = new Button();
            btnRegister.Text = "Register";
            btnRegister.Location = new System.Drawing.Point(50, 100);
            btnRegister.Click += new EventHandler(btnRegister_Click); // Thêm sự kiện click cho nút Đăng ký
            this.Controls.Add(btnRegister);

            Button btnCancel = new Button();
            btnCancel.Text = "Cancel";
            btnCancel.Location = new System.Drawing.Point(150, 100);
            btnCancel.Click += new EventHandler(btnCancel_Click); // Thêm sự kiện click cho nút Hủy bỏ
            this.Controls.Add(btnCancel);

            CheckedListBox checkedListBox1 = new CheckedListBox();
            checkedListBox1.Items.AddRange(new object[] { "Item 1", "Item 2", "Item 3" });
            checkedListBox1.Location = new System.Drawing.Point(30, 150);
            this.Controls.Add(checkedListBox1);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng ký thành công!");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
