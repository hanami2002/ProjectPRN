using FoodLibrary.DAL;
using FoodLibrary.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class UserInfor : Form
    {
        Account accounts;
        AccountDAO accountDAO=new AccountDAO();

        public Account Accounts { get => accounts; set => accounts = value; }

        public UserInfor()
        {
            InitializeComponent();
        }
        public UserInfor(Account account)
        {
            this.Accounts = account;
            InitializeComponent();
            txtUsername.Text = account.UserName;
            txtDisplay.Text = account.DisplayName;
            txtUsername.Enabled=false;
          //  txtPass.Text = account.Password;
        }
        public void Load()
        {
            txtUsername.Text = Accounts.UserName;
            txtDisplay.Text = Accounts.DisplayName;
            txtUsername.Enabled = false;
            txtPass.Text = ""; 
            txtRepass.Text = "";
            txtNewPass.Text = "";

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string user=txtUsername.Text;
            Account accountnew= accountDAO.GetAccountByUserName(user);
            if (!txtPass.Text.Equals(accountnew.Password))
            {
                MessageBox.Show("Your password is not correct");
            }
            else if (!txtNewPass.Text.Equals(txtRepass.Text)) {
                MessageBox.Show("New password is not equal to Re pass");
            }
            else
            {
                if (txtNewPass.Text.Equals(string.Empty)){
                    accountDAO.UpdateInfoAccount(user, txtDisplay.Text, txtPass.Text, txtPass.Text);
                }
                else
                {
                    accountDAO.UpdateInfoAccount(user, txtDisplay.Text, txtPass.Text, txtNewPass.Text);
                }
            }
            Accounts= accountDAO.GetAccountByUserName(accountnew.UserName);
            MessageBox.Show("Update succes");
            Load();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
