namespace ExpenseManagerApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label5 = new Label();
            label4 = new Label();
            txtAmount = new TextBox();
            dgvTransactions = new DataGridView();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            cmbSearchCategory = new ComboBox();
            label8 = new Label();
            dtpSearchEnd = new DateTimePicker();
            label7 = new Label();
            dtpSearchStart = new DateTimePicker();
            label6 = new Label();
            btnAddTrans = new Button();
            txtNotes = new TextBox();
            cmbPaymentMethods = new ComboBox();
            cmbCategories = new ComboBox();
            label3 = new Label();
            dtpDate = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            dgvCategories = new DataGridView();
            panel2 = new Panel();
            btnAddCat = new Button();
            cmbCatType = new ComboBox();
            label10 = new Label();
            txtCatName = new TextBox();
            label9 = new Label();
            tabPage3 = new TabPage();
            dgvWallets = new DataGridView();
            panel3 = new Panel();
            btnDelWallet = new Button();
            btnEditWallet = new Button();
            btnAddWallet = new Button();
            txtWalletBalance = new TextBox();
            label12 = new Label();
            txtWalletName = new TextBox();
            label11 = new Label();
            tabPage4 = new TabPage();
            dgvStats = new DataGridView();
            panel5 = new Panel();
            groupBox3 = new GroupBox();
            lblLifeBalance = new Label();
            lblLifeExpense = new Label();
            lblLifeIncome = new Label();
            groupBox2 = new GroupBox();
            lblBalance = new Label();
            lblTotalExpense = new Label();
            lblTotalIncome = new Label();
            panel4 = new Panel();
            btnViewStats = new Button();
            numYear = new NumericUpDown();
            label14 = new Label();
            numMonth = new NumericUpDown();
            label13 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            panel2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWallets).BeginInit();
            panel3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStats).BeginInit();
            panel5.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMonth).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1052, 728);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtAmount);
            tabPage1.Controls.Add(dgvTransactions);
            tabPage1.Controls.Add(panel1);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1044, 692);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Quản lý giao dịch";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(300, 50);
            label5.Name = "label5";
            label5.Size = new Size(109, 23);
            label5.TabIndex = 5;
            label5.Text = "Tài khoản/Ví:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(300, 15);
            label4.Name = "label4";
            label4.Size = new Size(93, 23);
            label4.TabIndex = 4;
            label4.Text = "Danh mục:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(130, 12);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(150, 30);
            txtAmount.TabIndex = 2;
            // 
            // dgvTransactions
            // 
            dgvTransactions.BackgroundColor = Color.White;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Dock = DockStyle.Fill;
            dgvTransactions.Location = new Point(3, 183);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.RowHeadersWidth = 51;
            dgvTransactions.Size = new Size(1038, 506);
            dgvTransactions.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(btnAddTrans);
            panel1.Controls.Add(txtNotes);
            panel1.Controls.Add(cmbPaymentMethods);
            panel1.Controls.Add(cmbCategories);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dtpDate);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1038, 180);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(cmbSearchCategory);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dtpSearchEnd);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dtpSearchStart);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(590, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(440, 160);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm nâng cao";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.GreenYellow;
            btnSearch.Location = new Point(220, 21);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(200, 102);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Tìm Kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += BtnSearch_Click;
            // 
            // cmbSearchCategory
            // 
            cmbSearchCategory.FormattingEnabled = true;
            cmbSearchCategory.Location = new Point(98, 92);
            cmbSearchCategory.Name = "cmbSearchCategory";
            cmbSearchCategory.Size = new Size(110, 31);
            cmbSearchCategory.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 95);
            label8.Name = "label8";
            label8.Size = new Size(93, 23);
            label8.TabIndex = 4;
            label8.Text = "Danh mục:";
            // 
            // dtpSearchEnd
            // 
            dtpSearchEnd.Format = DateTimePickerFormat.Short;
            dtpSearchEnd.Location = new Point(98, 57);
            dtpSearchEnd.Name = "dtpSearchEnd";
            dtpSearchEnd.Size = new Size(110, 30);
            dtpSearchEnd.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 60);
            label7.Name = "label7";
            label7.Size = new Size(88, 23);
            label7.TabIndex = 2;
            label7.Text = "Đến ngày:";
            // 
            // dtpSearchStart
            // 
            dtpSearchStart.Format = DateTimePickerFormat.Short;
            dtpSearchStart.Location = new Point(98, 21);
            dtpSearchStart.Name = "dtpSearchStart";
            dtpSearchStart.Size = new Size(110, 30);
            dtpSearchStart.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 25);
            label6.Name = "label6";
            label6.Size = new Size(77, 23);
            label6.TabIndex = 0;
            label6.Text = "Từ ngày:";
            // 
            // btnAddTrans
            // 
            btnAddTrans.BackColor = Color.GreenYellow;
            btnAddTrans.Location = new Point(127, 120);
            btnAddTrans.Name = "btnAddTrans";
            btnAddTrans.Size = new Size(433, 45);
            btnAddTrans.TabIndex = 6;
            btnAddTrans.Text = "Thêm Giao Dịch Mới";
            btnAddTrans.UseVisualStyleBackColor = false;
            btnAddTrans.Click += BtnAddTransaction_Click;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(127, 82);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(433, 30);
            txtNotes.TabIndex = 3;
            // 
            // cmbPaymentMethods
            // 
            cmbPaymentMethods.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentMethods.FormattingEnabled = true;
            cmbPaymentMethods.Location = new Point(410, 47);
            cmbPaymentMethods.Name = "cmbPaymentMethods";
            cmbPaymentMethods.Size = new Size(150, 31);
            cmbPaymentMethods.TabIndex = 5;
            // 
            // cmbCategories
            // 
            cmbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(410, 12);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(150, 31);
            cmbCategories.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 85);
            label3.Name = "label3";
            label3.Size = new Size(73, 23);
            label3.TabIndex = 3;
            label3.Text = "Ghi chú:";
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(127, 47);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(150, 30);
            dtpDate.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 50);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 1;
            label2.Text = "Ngày GD:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(111, 23);
            label1.TabIndex = 0;
            label1.Text = "Số tiền(VNĐ)";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvCategories);
            tabPage2.Controls.Add(panel2);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1044, 692);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Quản Lý Danh Mục";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvCategories
            // 
            dgvCategories.BackgroundColor = SystemColors.Control;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Dock = DockStyle.Fill;
            dgvCategories.Location = new Point(323, 3);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.RowHeadersWidth = 51;
            dgvCategories.Size = new Size(718, 686);
            dgvCategories.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnAddCat);
            panel2.Controls.Add(cmbCatType);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtCatName);
            panel2.Controls.Add(label9);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(320, 686);
            panel2.TabIndex = 0;
            // 
            // btnAddCat
            // 
            btnAddCat.BackColor = Color.CornflowerBlue;
            btnAddCat.ForeColor = Color.White;
            btnAddCat.Location = new Point(20, 170);
            btnAddCat.Name = "btnAddCat";
            btnAddCat.Size = new Size(260, 40);
            btnAddCat.TabIndex = 4;
            btnAddCat.Text = "Tạo Danh Mục";
            btnAddCat.UseVisualStyleBackColor = false;
            btnAddCat.Click += BtnAddCategory_Click;
            // 
            // cmbCatType
            // 
            cmbCatType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCatType.FormattingEnabled = true;
            cmbCatType.Items.AddRange(new object[] { "Income", "Expense" });
            cmbCatType.Location = new Point(20, 115);
            cmbCatType.Name = "cmbCatType";
            cmbCatType.Size = new Size(260, 31);
            cmbCatType.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 90);
            label10.Name = "label10";
            label10.Size = new Size(135, 23);
            label10.TabIndex = 2;
            label10.Text = "Phân loại nhóm:";
            // 
            // txtCatName
            // 
            txtCatName.Location = new Point(20, 45);
            txtCatName.Name = "txtCatName";
            txtCatName.Size = new Size(260, 30);
            txtCatName.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 20);
            label9.Name = "label9";
            label9.Size = new Size(183, 23);
            label9.TabIndex = 0;
            label9.Text = "Tên danh mục chi tiêu:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvWallets);
            tabPage3.Controls.Add(panel3);
            tabPage3.Location = new Point(4, 32);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1044, 692);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Quản Lý Tài Khoản/Ví";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvWallets
            // 
            dgvWallets.BackgroundColor = Color.White;
            dgvWallets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWallets.Dock = DockStyle.Fill;
            dgvWallets.Location = new Point(320, 0);
            dgvWallets.Name = "dgvWallets";
            dgvWallets.RowHeadersWidth = 51;
            dgvWallets.Size = new Size(724, 692);
            dgvWallets.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btnDelWallet);
            panel3.Controls.Add(btnEditWallet);
            panel3.Controls.Add(btnAddWallet);
            panel3.Controls.Add(txtWalletBalance);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(txtWalletName);
            panel3.Controls.Add(label11);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(320, 692);
            panel3.TabIndex = 0;
            // 
            // btnDelWallet
            // 
            btnDelWallet.BackColor = Color.LightCoral;
            btnDelWallet.Location = new Point(200, 170);
            btnDelWallet.Name = "btnDelWallet";
            btnDelWallet.Size = new Size(80, 35);
            btnDelWallet.TabIndex = 6;
            btnDelWallet.Text = "Xóa";
            btnDelWallet.UseVisualStyleBackColor = false;
            btnDelWallet.Click += BtnDeleteWallet_Click;
            // 
            // btnEditWallet
            // 
            btnEditWallet.BackColor = Color.LightSkyBlue;
            btnEditWallet.Location = new Point(110, 170);
            btnEditWallet.Name = "btnEditWallet";
            btnEditWallet.Size = new Size(80, 35);
            btnEditWallet.TabIndex = 5;
            btnEditWallet.Text = "Sửa";
            btnEditWallet.UseVisualStyleBackColor = false;
            btnEditWallet.Click += BtnEditWallet_Click;
            // 
            // btnAddWallet
            // 
            btnAddWallet.BackColor = Color.LightGreen;
            btnAddWallet.Location = new Point(20, 170);
            btnAddWallet.Name = "btnAddWallet";
            btnAddWallet.Size = new Size(80, 35);
            btnAddWallet.TabIndex = 4;
            btnAddWallet.Text = "Thêm Mới";
            btnAddWallet.UseVisualStyleBackColor = false;
            btnAddWallet.Click += BtnAddWallet_Click;
            // 
            // txtWalletBalance
            // 
            txtWalletBalance.Location = new Point(20, 115);
            txtWalletBalance.Name = "txtWalletBalance";
            txtWalletBalance.Size = new Size(260, 30);
            txtWalletBalance.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(20, 90);
            label12.Name = "label12";
            label12.Size = new Size(112, 23);
            label12.TabIndex = 2;
            label12.Text = "Số dư (VNĐ):";
            // 
            // txtWalletName
            // 
            txtWalletName.Location = new Point(20, 45);
            txtWalletName.Name = "txtWalletName";
            txtWalletName.Size = new Size(260, 30);
            txtWalletName.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(20, 20);
            label11.Name = "label11";
            label11.Size = new Size(151, 23);
            label11.TabIndex = 0;
            label11.Text = "Tên Tài Khoản / Ví:";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dgvStats);
            tabPage4.Controls.Add(panel5);
            tabPage4.Controls.Add(panel4);
            tabPage4.Location = new Point(4, 32);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1044, 692);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Báo Cáo & Thống Kê";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvStats
            // 
            dgvStats.BackgroundColor = Color.White;
            dgvStats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStats.Dock = DockStyle.Fill;
            dgvStats.Location = new Point(380, 64);
            dgvStats.Name = "dgvStats";
            dgvStats.RowHeadersWidth = 51;
            dgvStats.Size = new Size(664, 628);
            dgvStats.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.Controls.Add(groupBox3);
            panel5.Controls.Add(groupBox2);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 64);
            panel5.Name = "panel5";
            panel5.Size = new Size(380, 628);
            panel5.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblLifeBalance);
            groupBox3.Controls.Add(lblLifeExpense);
            groupBox3.Controls.Add(lblLifeIncome);
            groupBox3.Location = new Point(10, 210);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(350, 180);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thống Kê Lũy Kế (Toàn Thời Gian)";
            // 
            // lblLifeBalance
            // 
            lblLifeBalance.AutoSize = true;
            lblLifeBalance.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLifeBalance.ForeColor = Color.Purple;
            lblLifeBalance.Location = new Point(15, 125);
            lblLifeBalance.Name = "lblLifeBalance";
            lblLifeBalance.Size = new Size(160, 31);
            lblLifeBalance.TabIndex = 2;
            lblLifeBalance.Text = "Số Dư: 0 VND";
            // 
            // lblLifeExpense
            // 
            lblLifeExpense.AutoSize = true;
            lblLifeExpense.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLifeExpense.ForeColor = Color.Red;
            lblLifeExpense.Location = new Point(15, 80);
            lblLifeExpense.Name = "lblLifeExpense";
            lblLifeExpense.Size = new Size(152, 25);
            lblLifeExpense.TabIndex = 1;
            lblLifeExpense.Text = "Tổng Chi: 0 VND";
            // 
            // lblLifeIncome
            // 
            lblLifeIncome.AutoSize = true;
            lblLifeIncome.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLifeIncome.ForeColor = Color.Green;
            lblLifeIncome.Location = new Point(15, 35);
            lblLifeIncome.Name = "lblLifeIncome";
            lblLifeIncome.Size = new Size(158, 25);
            lblLifeIncome.TabIndex = 0;
            lblLifeIncome.Text = "Tổng Thu: 0 VND";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblBalance);
            groupBox2.Controls.Add(lblTotalExpense);
            groupBox2.Controls.Add(lblTotalIncome);
            groupBox2.Location = new Point(10, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(350, 180);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thống Kê Theo Tháng";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.ForeColor = Color.Blue;
            lblBalance.Location = new Point(15, 125);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(160, 31);
            lblBalance.TabIndex = 2;
            lblBalance.Text = "Số Dư: 0 VND";
            // 
            // lblTotalExpense
            // 
            lblTotalExpense.AutoSize = true;
            lblTotalExpense.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalExpense.ForeColor = Color.Red;
            lblTotalExpense.Location = new Point(15, 80);
            lblTotalExpense.Name = "lblTotalExpense";
            lblTotalExpense.Size = new Size(152, 25);
            lblTotalExpense.TabIndex = 1;
            lblTotalExpense.Text = "Tổng Chi: 0 VND";
            // 
            // lblTotalIncome
            // 
            lblTotalIncome.AutoSize = true;
            lblTotalIncome.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalIncome.ForeColor = Color.FromArgb(0, 192, 0);
            lblTotalIncome.Location = new Point(15, 35);
            lblTotalIncome.Name = "lblTotalIncome";
            lblTotalIncome.Size = new Size(158, 25);
            lblTotalIncome.TabIndex = 0;
            lblTotalIncome.Text = "Tổng Thu: 0 VND";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(btnViewStats);
            panel4.Controls.Add(numYear);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(numMonth);
            panel4.Controls.Add(label13);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1044, 64);
            panel4.TabIndex = 0;
            // 
            // btnViewStats
            // 
            btnViewStats.BackColor = Color.LightGoldenrodYellow;
            btnViewStats.Location = new Point(474, 12);
            btnViewStats.Name = "btnViewStats";
            btnViewStats.Size = new Size(184, 35);
            btnViewStats.TabIndex = 4;
            btnViewStats.Text = "Truy Xuất Báo Cáo";
            btnViewStats.UseVisualStyleBackColor = false;
            btnViewStats.Click += BtnViewStats_Click;
            // 
            // numYear
            // 
            numYear.Location = new Point(332, 16);
            numYear.Margin = new Padding(4, 3, 4, 3);
            numYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numYear.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(100, 30);
            numYear.TabIndex = 3;
            numYear.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(274, 18);
            label14.Name = "label14";
            label14.Size = new Size(51, 23);
            label14.TabIndex = 2;
            label14.Text = "Năm:";
            // 
            // numMonth
            // 
            numMonth.Location = new Point(190, 16);
            numMonth.Margin = new Padding(4, 3, 4, 3);
            numMonth.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numMonth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numMonth.Name = "numMonth";
            numMonth.Size = new Size(75, 30);
            numMonth.TabIndex = 1;
            numMonth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(20, 18);
            label13.Name = "label13";
            label13.Size = new Size(163, 23);
            label13.TabIndex = 0;
            label13.Text = "Kỳ báo cáo - Tháng:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1052, 728);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HỆ THỐNG QUẢN LÝ CHI TIÊU CÁ NHÂN";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvWallets).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStats).EndInit();
            panel5.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMonth).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private DataGridView dgvTransactions;
        private Panel panel1;
        private Label label1;
        private TextBox txtAmount;
        private Label label2;
        private DateTimePicker dtpDate;
        private Label label3;
        private TextBox txtNotes;
        private Label label4;
        private ComboBox cmbCategories;
        private Label label5;
        private ComboBox cmbPaymentMethods;
        private Button btnAddTrans;
        private GroupBox groupBox1;
        private Label label6;
        private DateTimePicker dtpSearchStart;
        private DateTimePicker dtpSearchEnd;
        private Label label7;
        private Label label8;
        private ComboBox cmbSearchCategory;
        private Button btnSearch;
        private Panel panel2;
        private DataGridView dgvCategories;
        private Label label9;
        private TextBox txtCatName;
        private Label label10;
        private ComboBox cmbCatType;
        private Button btnAddCat;
        private DataGridView dgvWallets;
        private Panel panel3;
        private TextBox txtWalletName;
        private Label label11;
        private TextBox txtWalletBalance;
        private Label label12;
        private Button btnAddWallet;
        private Button btnEditWallet;
        private Button btnDelWallet;
        private Panel panel5;
        private Panel panel4;
        private DataGridView dgvStats;
        private Label label13;
        private NumericUpDown numMonth;
        private NumericUpDown numYear;
        private Label label14;
        private Button btnViewStats;
        private GroupBox groupBox2;
        private Label lblTotalIncome;
        private Label lblTotalExpense;
        private Label lblBalance;
        private GroupBox groupBox3;
        private Label lblLifeBalance;
        private Label lblLifeExpense;
        private Label lblLifeIncome;
    }
}