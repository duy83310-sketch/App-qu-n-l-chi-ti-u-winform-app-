using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExpenseManagerApp
{
    public partial class MainForm : Form
    {
        private ExpenseManagerLogic logic = new ExpenseManagerLogic();
        private int selectedWalletId = 0;

        public MainForm()
        {
            // Hàm mặc định của Visual Studio để gọi giao diện kéo thả
            InitializeComponent();

            // Tải dữ liệu ngay khi Form vừa mở lên
            LoadData();
        }

        // ==========================================
        // 1. CÁC HÀM TẢI DỮ LIỆU
        // ==========================================
        private void LoadData()
        {
            try
            {
                // Tải danh mục
                DataTable dtCategories = logic.GetAllCategories();
                dgvCategories.DataSource = dtCategories;

                cmbCategories.DataSource = dtCategories.Copy();
                cmbCategories.DisplayMember = "Tên Danh Mục";
                cmbCategories.ValueMember = "Mã";

                DataTable dtSearchCat = dtCategories.Copy();
                DataRow row = dtSearchCat.NewRow();
                row["Mã"] = 0;
                row["Tên Danh Mục"] = "--- Tất cả ---";
                dtSearchCat.Rows.InsertAt(row, 0);
                cmbSearchCategory.DataSource = dtSearchCat;
                cmbSearchCategory.DisplayMember = "Tên Danh Mục";
                cmbSearchCategory.ValueMember = "Mã";

                // Tải ví/tài khoản
                DataTable dtWallets = logic.GetPaymentMethods();
                dgvWallets.DataSource = dtWallets;

                cmbPaymentMethods.DataSource = dtWallets.Copy();
                cmbPaymentMethods.DisplayMember = "Tên Tài Khoản/Ví";
                cmbPaymentMethods.ValueMember = "Mã Ví";

                // Tải thống kê lũy kế toàn thời gian
                LoadLifetimeStats();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi");
            }
        }

        private void LoadLifetimeStats()
        {
            DataTable dt = logic.GetLifetimeStatistics();
            if (dt.Rows.Count > 0)
            {
                decimal lifeIncome = Convert.ToDecimal(dt.Rows[0]["LifetimeIncome"]);
                decimal lifeExpense = Convert.ToDecimal(dt.Rows[0]["LifetimeExpense"]);
                decimal lifeBalance = lifeIncome - lifeExpense;

                lblLifeIncome.Text = "Tổng Thu: " + lifeIncome.ToString("N0") + " VND";
                lblLifeExpense.Text = "Tổng Chi: " + lifeExpense.ToString("N0") + " VND";
                lblLifeBalance.Text = "Tổng Số Dư: " + lifeBalance.ToString("N0") + " VND";
            }
        }

        // ==========================================
        // 2. SỰ KIỆN TAB 1: GIAO DỊCH
        // ==========================================
        private void BtnAddTransaction_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtAmount.Text, out decimal amount) || cmbCategories.SelectedValue == null || cmbPaymentMethods.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập số tiền hợp lệ và chọn đầy đủ thông tin!", "Lỗi nhập liệu");
                return;
            }

            Transaction trans = new Transaction
            {
                Date = dtpDate.Value,
                Amount = amount,
                CategoryID = Convert.ToInt32(cmbCategories.SelectedValue),
                PaymentMethodID = Convert.ToInt32(cmbPaymentMethods.SelectedValue),
                Notes = txtNotes.Text,
                UserName = "Duy Nguyen"
            };

            if (logic.AddTransaction(trans))
            {
                MessageBox.Show("Ghi nhận giao dịch thành công!", "Thành công");
                txtAmount.Clear();
                txtNotes.Clear();
                LoadData();
                BtnSearch_Click(null, null); // Tự động load lại bảng tìm kiếm
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            dgvTransactions.DataSource = logic.SearchTransactions(dtpSearchStart.Value, dtpSearchEnd.Value, Convert.ToInt32(cmbSearchCategory.SelectedValue));
        }

        private void DgvTransactions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvTransactions.Columns[e.ColumnIndex].Name == "Số Tiền" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal amt))
                {
                    e.Value = amt.ToString("N0") + " VND";
                    e.FormattingApplied = true;
                }
            }

            if (e.RowIndex >= 0 && dgvTransactions.Columns[e.ColumnIndex].Name == "Số Tiền")
            {
                var cellType = dgvTransactions.Rows[e.RowIndex].Cells["Loại"].Value;
                if (cellType != null)
                {
                    string type = cellType.ToString();
                    if (type == "Income")
                    {
                        e.CellStyle.BackColor = Color.FromArgb(230, 255, 230);
                        e.CellStyle.ForeColor = Color.DarkGreen;
                    }
                    else if (type == "Expense")
                    {
                        e.CellStyle.BackColor = Color.FromArgb(255, 230, 230);
                        e.CellStyle.ForeColor = Color.DarkRed;
                    }
                }
            }
        }

        // ==========================================
        // 3. SỰ KIỆN TAB 2: DANH MỤC
        // ==========================================
        private void BtnAddCategory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCatName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên danh mục!", "Cảnh báo");
                return;
            }
            Category newCat = new Category { Name = txtCatName.Text, Type = cmbCatType.SelectedItem.ToString() };
            if (logic.AddCategory(newCat))
            {
                MessageBox.Show("Thêm danh mục mới thành công!", "Thông báo");
                txtCatName.Clear();
                LoadData();
            }
        }

        // ==========================================
        // 4. SỰ KIỆN TAB 3: TÀI KHOẢN / VÍ
        // ==========================================
        private void BtnAddWallet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtWalletName.Text) || !decimal.TryParse(txtWalletBalance.Text, out decimal balance))
            {
                MessageBox.Show("Nhập tên ví và số dư hợp lệ!", "Cảnh báo");
                return;
            }
            if (logic.AddPaymentMethod(txtWalletName.Text, balance))
            {
                MessageBox.Show("Thêm ví mới thành công!", "Thông báo");
                ClearWalletFields();
                LoadData();
            }
        }

        private void BtnEditWallet_Click(object sender, EventArgs e)
        {
            if (selectedWalletId == 0 || string.IsNullOrWhiteSpace(txtWalletName.Text) || !decimal.TryParse(txtWalletBalance.Text, out decimal balance))
            {
                MessageBox.Show("Vui lòng chọn ví từ bảng để sửa!", "Thông báo");
                return;
            }
            if (logic.EditPaymentMethod(selectedWalletId, txtWalletName.Text, balance))
            {
                MessageBox.Show("Sửa thông tin ví thành công!", "Thông báo");
                ClearWalletFields();
                LoadData();
            }
        }

        private void BtnDeleteWallet_Click(object sender, EventArgs e)
        {
            if (selectedWalletId == 0) return;
            if (MessageBox.Show("Bạn có chắc chắn xóa ví này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (logic.DeletePaymentMethod(selectedWalletId))
                {
                    MessageBox.Show("Đã xóa ví thành công!", "Thông báo");
                    ClearWalletFields();
                    LoadData();
                }
            }
        }

        private void DgvWallets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvWallets.Rows[e.RowIndex];
                selectedWalletId = Convert.ToInt32(row.Cells["Mã Ví"].Value);
                txtWalletName.Text = row.Cells["Tên Tài Khoản/Ví"].Value.ToString();

                string rawBalance = row.Cells["Số Dư (VNĐ)"].Value.ToString().Replace(".", "").Replace(" VND", "").Trim();
                txtWalletBalance.Text = rawBalance;
            }
        }

        private void DgvWallets_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvWallets.Columns[e.ColumnIndex].Name == "Số Dư (VNĐ)" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal amt))
                {
                    e.Value = amt.ToString("N0") + " VND";
                    e.FormattingApplied = true;
                }
            }
        }

        private void ClearWalletFields()
        {
            txtWalletName.Clear();
            txtWalletBalance.Clear();
            selectedWalletId = 0;
        }

        // ==========================================
        // 5. SỰ KIỆN TAB 4: THỐNG KÊ
        // ==========================================
        private void BtnViewStats_Click(object sender, EventArgs e)
        {
            DataTable dtStats = logic.GetCategoryStatistics((int)numMonth.Value, (int)numYear.Value);
            dgvStats.DataSource = dtStats;

            decimal totalIncome = 0;
            decimal totalExpense = 0;

            foreach (DataRow row in dtStats.Rows)
            {
                string type = row["Phân Loại"].ToString();
                decimal amount = Convert.ToDecimal(row["Tổng Tiền (VNĐ)"]);

                if (type == "Income") totalIncome += amount;
                else if (type == "Expense") totalExpense += amount;
            }

            lblTotalIncome.Text = "Tổng Thu: " + totalIncome.ToString("N0") + " VND";
            lblTotalExpense.Text = "Tổng Chi: " + totalExpense.ToString("N0") + " VND";
            lblBalance.Text = "Số Dư: " + (totalIncome - totalExpense).ToString("N0") + " VND";

            LoadLifetimeStats();
        }

        private void DgvStats_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvStats.Columns[e.ColumnIndex].Name == "Tổng Tiền (VNĐ)" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal amt))
                {
                    e.Value = amt.ToString("N0") + " VND";
                    e.FormattingApplied = true;
                }
            }

            if (e.RowIndex >= 0 && dgvStats.Columns[e.ColumnIndex].Name == "Tổng Tiền (VNĐ)")
            {
                var cellType = dgvStats.Rows[e.RowIndex].Cells["Phân Loại"].Value;
                if (cellType != null)
                {
                    string type = cellType.ToString();
                    if (type == "Income")
                    {
                        e.CellStyle.BackColor = Color.FromArgb(230, 255, 230);
                        e.CellStyle.ForeColor = Color.DarkGreen;
                    }
                    else if (type == "Expense")
                    {
                        e.CellStyle.BackColor = Color.FromArgb(255, 230, 230);
                        e.CellStyle.ForeColor = Color.DarkRed;
                    }
                }
            }
        }
    }
}