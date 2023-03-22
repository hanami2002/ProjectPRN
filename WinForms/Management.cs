
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using FoodLibrary.DAL;
using System.Xml.Linq;
using FoodLibrary.Object;
using FoodLibrary.DataAccess;


namespace WinForms
{
    public partial class Management : Form
    {
        Account account;
        AccountDAO accountdao= new AccountDAO();
        TableDAO tableDAO = new TableDAO();
        StatusDAO sttDAO = new StatusDAO();
        OrderDAO orderDAO = new OrderDAO();
        DetailDAO detailDAO = new DetailDAO();
        CategoryDAO categoryDAO = new CategoryDAO();
        MenuDAO menuDAO = new MenuDAO();
        //public Management()
        //{
        //    InitializeComponent();
        //    LoadEmployee();
        //    LoadTables();
        //}

        public Management(Account account)
        {
            this.account = account;
            InitializeComponent();
            //LoadEmployee();
            LoadAll();

        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public void LoadAll()
        {
            LoadTables();
            LoadCategory();
            cboCategory.SelectedIndex = 0;
            

        }
        public void ShowOrder(int id)
        {
            lsvOrder.Items.Clear();
            double total = 0;
            List<Bill> list = (List<Bill>)detailDAO.GetBillByTable(orderDAO.GetIdByTableId(id));
            foreach(Bill order in list)
            {
                ListViewItem lsv = new ListViewItem(order.Name.ToString());
                lsv.SubItems.Add(order.Price.ToString());
                lsv.SubItems.Add(order.Count.ToString());
                lsv.SubItems.Add(order.Total.ToString());
                total += order.Total;
                lsvOrder.Items.Add(lsv);
            }
            txtTotal.Text = total.ToString();
        }
       
        public void LoadTables()
        {
            flpTable.Controls.Clear();
            foreach (Table item in tableDAO.GetListTables())
            {
                Button btn = new Button()
                {
                    Width = 100,
                    Height = 100
                };
                btn.Text = item.NameTablee + Environment.NewLine + sttDAO.GetNameByID(item.SttId);
                btn.Click += btn_Click;
                btn.Tag = item;
                if (item.SttId == 1)
                {
                    btn.BackColor = Color.Green;
                }
                else {
                    btn.BackColor = Color.Red;
                }
                    
                flpTable.Controls.Add(btn);
                
            }                        
        }
        public void LoadCategory()
        {
            List<Category> list = (List<Category>)categoryDAO.GetListCategory();
            cboCategory.DataSource = list;
            cboCategory.DisplayMember = "Name";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).Id;
            lsvOrder.Tag = (sender as Button).Tag;
            ShowOrder(tableID);
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            Category category = cboCategory.SelectedItem as Category;
            id = category.Id;
            cboMenu.DataSource = menuDAO.GetMenuByIdCate(id);
            cboMenu.DisplayMember = "Name";
        }
        
             
        private void btnAdd_Click(object sender, EventArgs e)
        {

            Table table = lsvOrder.Tag as Table;
            int idBill = orderDAO.GetIdByTableId(table.Id);           
            int food = (cboMenu.SelectedItem as Menu).Id;
            int count =(int) nudAmout.Value;
            MessageBox.Show(orderDAO.GetMaxID("[Order]") + " "+ orderDAO.GetMaxID("OrderDetail"));


            if (idBill == -1)
            {
                orderDAO.InsertOrder(orderDAO.GetMaxID("[Order]") + 1, table.Id);
                detailDAO.InsertOrderDetail(orderDAO.GetMaxID("OrderDetail") + 1, orderDAO.GetMaxID("[Order]"), food, count);
            }
            else
            {
                detailDAO.InsertOrderDetail(orderDAO.GetMaxID("OrderDetail") + 1, idBill, food, count);
            }
            ShowOrder(table.Id);
            LoadTables();

        }

        private void btnCashPay_Click(object sender, EventArgs e)
        {
            Table table = lsvOrder.Tag as Table;
            int idBill= orderDAO.GetIdByTableId(table.Id);
            MessageBox.Show(idBill.ToString()+" "+table.Id);
            if (idBill != -1)
            {               
                    orderDAO.CheckOut(table.Id);
                
            }
            ShowOrder(table.Id);
            LoadTables();
        }

        private void btnMomo_Click(object sender, EventArgs e)
        {

        }
    }
}
    

