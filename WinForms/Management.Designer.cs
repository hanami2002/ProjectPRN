namespace WinForms
{
    partial class Management
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userInforToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.nudDis = new System.Windows.Forms.NumericUpDown();
            this.btnDis = new System.Windows.Forms.Button();
            this.cboMove = new System.Windows.Forms.ComboBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnMomo = new System.Windows.Forms.Button();
            this.btnCashPay = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lsvOrder = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nudAmout = new System.Windows.Forms.NumericUpDown();
            this.cboMenu = new System.Windows.Forms.ComboBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDis)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmout)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managementToolStripMenuItem,
            this.userInforToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1197, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.managementToolStripMenuItem.Text = "Management";
            // 
            // userInforToolStripMenuItem
            // 
            this.userInforToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.userInforToolStripMenuItem.Name = "userInforToolStripMenuItem";
            this.userInforToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.userInforToolStripMenuItem.Text = "User Infor";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtMoney);
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.nudDis);
            this.panel2.Controls.Add(this.btnDis);
            this.panel2.Controls.Add(this.cboMove);
            this.panel2.Controls.Add(this.btnMove);
            this.panel2.Controls.Add(this.btnMomo);
            this.panel2.Controls.Add(this.btnCashPay);
            this.panel2.Location = new System.Drawing.Point(693, 607);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 100);
            this.panel2.TabIndex = 2;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotal.Location = new System.Drawing.Point(181, 65);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(166, 32);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudDis
            // 
            this.nudDis.Location = new System.Drawing.Point(97, 53);
            this.nudDis.Name = "nudDis";
            this.nudDis.Size = new System.Drawing.Size(78, 23);
            this.nudDis.TabIndex = 5;
            // 
            // btnDis
            // 
            this.btnDis.Location = new System.Drawing.Point(96, 3);
            this.btnDis.Name = "btnDis";
            this.btnDis.Size = new System.Drawing.Size(79, 43);
            this.btnDis.TabIndex = 4;
            this.btnDis.Text = "Discount";
            this.btnDis.UseVisualStyleBackColor = true;
            // 
            // cboMove
            // 
            this.cboMove.FormattingEnabled = true;
            this.cboMove.Location = new System.Drawing.Point(0, 52);
            this.cboMove.Name = "cboMove";
            this.cboMove.Size = new System.Drawing.Size(90, 23);
            this.cboMove.TabIndex = 3;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(0, 3);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(90, 43);
            this.btnMove.TabIndex = 2;
            this.btnMove.Text = "Move Table";
            this.btnMove.UseVisualStyleBackColor = true;
            // 
            // btnMomo
            // 
            this.btnMomo.Location = new System.Drawing.Point(400, 52);
            this.btnMomo.Name = "btnMomo";
            this.btnMomo.Size = new System.Drawing.Size(101, 43);
            this.btnMomo.TabIndex = 1;
            this.btnMomo.Text = "Payment Via Momo";
            this.btnMomo.UseVisualStyleBackColor = true;
            this.btnMomo.Click += new System.EventHandler(this.btnMomo_Click);
            // 
            // btnCashPay
            // 
            this.btnCashPay.Location = new System.Drawing.Point(400, 3);
            this.btnCashPay.Name = "btnCashPay";
            this.btnCashPay.Size = new System.Drawing.Size(101, 43);
            this.btnCashPay.TabIndex = 0;
            this.btnCashPay.Text = "Cash Payment";
            this.btnCashPay.UseVisualStyleBackColor = true;
            this.btnCashPay.Click += new System.EventHandler(this.btnCashPay_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lsvOrder);
            this.panel3.Location = new System.Drawing.Point(693, 154);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(504, 447);
            this.panel3.TabIndex = 3;
            // 
            // lsvOrder
            // 
            this.lsvOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lsvOrder.GridLines = true;
            this.lsvOrder.Location = new System.Drawing.Point(0, 0);
            this.lsvOrder.Name = "lsvOrder";
            this.lsvOrder.Size = new System.Drawing.Size(501, 441);
            this.lsvOrder.TabIndex = 0;
            this.lsvOrder.UseCompatibleStateImageBehavior = false;
            this.lsvOrder.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Amount";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Total";
            this.columnHeader6.Width = 150;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.nudAmout);
            this.panel4.Controls.Add(this.cboMenu);
            this.panel4.Controls.Add(this.cboCategory);
            this.panel4.Location = new System.Drawing.Point(693, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(433, 57);
            this.panel4.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(326, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 34);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nudAmout
            // 
            this.nudAmout.Location = new System.Drawing.Point(235, 34);
            this.nudAmout.Name = "nudAmout";
            this.nudAmout.Size = new System.Drawing.Size(85, 23);
            this.nudAmout.TabIndex = 2;
            // 
            // cboMenu
            // 
            this.cboMenu.FormattingEnabled = true;
            this.cboMenu.Location = new System.Drawing.Point(16, 34);
            this.cboMenu.Name = "cboMenu";
            this.cboMenu.Size = new System.Drawing.Size(198, 23);
            this.cboMenu.TabIndex = 1;
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(16, 0);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(159, 23);
            this.cboCategory.TabIndex = 0;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // flpTable
            // 
            this.flpTable.Location = new System.Drawing.Point(42, 62);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(645, 562);
            this.flpTable.TabIndex = 5;
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMoney.Location = new System.Drawing.Point(181, 6);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.PlaceholderText = "--Input Money--";
            this.txtMoney.Size = new System.Drawing.Size(166, 32);
            this.txtMoney.TabIndex = 7;
            this.txtMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 719);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDis)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem managementToolStripMenuItem;
        private ToolStripMenuItem userInforToolStripMenuItem;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private ToolStripMenuItem informationToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private Button btnCashPay;
        private Button btnMomo;
        private ComboBox cboCategory;
        private Button btnAdd;
        private NumericUpDown nudAmout;
        private ComboBox cboMenu;
        private FlowLayoutPanel flpTable;
        private ListView lsvOrder;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private NumericUpDown nudDis;
        private Button btnDis;
        private ComboBox cboMove;
        private Button btnMove;
        private TextBox txtTotal;
        private TextBox txtMoney;
    }
}