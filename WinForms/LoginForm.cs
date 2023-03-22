
using FoodLibrary.DAL;
using FoodLibrary.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinForms
{
    public partial class LoginForm : Form
    {
        AccountDAO accountDAO = new AccountDAO();
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            Account acc = accountDAO.Login(username, password);
            if (acc != null)
            {
                Management m = new Management(acc);
                this.Hide();
                m.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
        }
    }
}
