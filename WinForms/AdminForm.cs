using FoodLibrary.DAL;
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
    public partial class AdminForm : Form
    {
        OrderDAO orderDAO = new OrderDAO();
        public AdminForm()
        {
            InitializeComponent();
        }
        public void LoadListByDate(DateTime checkin,DateTime checkout)
        {
           dataGridView1.DataSource= orderDAO.GetListByDate(checkin, checkout);

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LoadListByDate(dtpFrom.Value,dtpTo.Value);
        }
    }
}
