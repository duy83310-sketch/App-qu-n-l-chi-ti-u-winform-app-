using System;
using System.Data;
using System.Data.SqlClient;

namespace ExpenseManagerApp
{
    public class ExpenseManagerLogic
    {
        private DatabaseConnection db = new DatabaseConnection();

        // --- 1. QUẢN LÝ DANH MỤC (CRUD) ---
        public DataTable GetAllCategories()
        {
            string query = "SELECT CategoryID AS [Mã], Name AS [Tên Danh Mục], Type AS [Loại] FROM Category";
            return db.ExecuteQuery(query);
        }

        public bool AddCategory(Category category)
        {
            string query = "INSERT INTO Category (Name, Type) VALUES (@Name, @Type)";
            SqlParameter[] parameters = {
                new SqlParameter("@Name", category.Name),
                new SqlParameter("@Type", category.Type)
            };
            return db.ExecuteNonQuery(query, parameters) > 0;
        }

        // --- 2. QUẢN LÝ TÀI KHOẢN / VÍ ---
        public DataTable GetPaymentMethods()
        {
            string query = "SELECT MethodID AS [Mã Ví], MethodName AS [Tên Tài Khoản/Ví], Balance AS [Số Dư (VNĐ)] FROM PaymentMethod";
            return db.ExecuteQuery(query);
        }

        public bool AddPaymentMethod(string name, decimal balance)
        {
            string query = "INSERT INTO PaymentMethod (MethodName, Balance) VALUES (@Name, @Balance)";
            SqlParameter[] parameters = {
                new SqlParameter("@Name", name),
                new SqlParameter("@Balance", balance)
            };
            return db.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool EditPaymentMethod(int id, string name, decimal balance)
        {
            string query = "UPDATE PaymentMethod SET MethodName = @Name, Balance = @Balance WHERE MethodID = @MethodID";
            SqlParameter[] parameters = {
                new SqlParameter("@Name", name),
                new SqlParameter("@Balance", balance),
                new SqlParameter("@MethodID", id)
            };
            return db.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeletePaymentMethod(int id)
        {
            string query = "DELETE FROM PaymentMethod WHERE MethodID = @MethodID";
            SqlParameter[] parameters = {
                new SqlParameter("@MethodID", id)
            };
            return db.ExecuteNonQuery(query, parameters) > 0;
        }

        // --- 3. QUẢN LÝ GIAO DỊCH ---
        public bool AddTransaction(Transaction trans)
        {
            string transQuery = @"INSERT INTO [Transaction] (TransactionDate, Amount, CategoryID, MethodID, Notes, UserName) 
                                 VALUES (@Date, @Amount, @CategoryID, @MethodID, @Notes, @UserName)";

            SqlParameter[] parameters = {
                new SqlParameter("@Date", trans.Date),
                new SqlParameter("@Amount", trans.Amount),
                new SqlParameter("@CategoryID", trans.CategoryID),
                new SqlParameter("@MethodID", trans.PaymentMethodID),
                new SqlParameter("@Notes", trans.Notes),
                new SqlParameter("@UserName", trans.UserName)
            };

            bool isTransAdded = db.ExecuteNonQuery(transQuery, parameters) > 0;

            if (isTransAdded)
            {
                string updateWalletQuery = @"
                    UPDATE PaymentMethod 
                    SET Balance = Balance + (CASE WHEN (SELECT Type FROM Category WHERE CategoryID = @CategoryID) = 'Income' THEN @Amount ELSE -@Amount END)
                    WHERE MethodID = @MethodID";

                SqlParameter[] walletParams = {
                    new SqlParameter("@Amount", trans.Amount),
                    new SqlParameter("@CategoryID", trans.CategoryID),
                    new SqlParameter("@MethodID", trans.PaymentMethodID)
                };
                db.ExecuteNonQuery(updateWalletQuery, walletParams);
            }

            return isTransAdded;
        }

        // --- 4. TÌM KIẾM NÂNG CAO ---
        public DataTable SearchTransactions(DateTime startDate, DateTime endDate, int categoryId)
        {
            string query = @"SELECT t.TransactionID AS [Mã GD], t.TransactionDate AS [Ngày], t.Amount AS [Số Tiền], 
                                    c.Name AS [Danh Mục], c.Type AS [Loại], p.MethodName AS [Tài Khoản/Ví], t.Notes AS [Ghi Chú]
                             FROM [Transaction] t
                             JOIN Category c ON t.CategoryID = c.CategoryID
                             JOIN PaymentMethod p ON t.MethodID = p.MethodID
                             WHERE t.TransactionDate >= @StartDate AND t.TransactionDate <= @EndDate";

            if (categoryId > 0)
            {
                query += " AND t.CategoryID = @CategoryID";
            }

            SqlParameter[] parameters = {
                new SqlParameter("@StartDate", startDate.Date),
                new SqlParameter("@EndDate", endDate.Date.AddDays(1).AddSeconds(-1)),
                new SqlParameter("@CategoryID", categoryId)
            };

            return db.ExecuteQuery(query, parameters);
        }

        // --- 5. THỐNG KÊ THEO THÁNG ---
        public DataTable GetCategoryStatistics(int month, int year)
        {
            string query = @"SELECT c.Name AS [Tên Danh Mục], c.Type AS [Phân Loại], SUM(t.Amount) AS [Tổng Tiền (VNĐ)]
                             FROM [Transaction] t
                             JOIN Category c ON t.CategoryID = c.CategoryID
                             WHERE MONTH(t.TransactionDate) = @Month AND YEAR(t.TransactionDate) = @Year
                             GROUP BY c.Name, c.Type";

            SqlParameter[] parameters = {
                new SqlParameter("@Month", month),
                new SqlParameter("@Year", year)
            };

            return db.ExecuteQuery(query, parameters);
        }

        // --- 6. BÁO CÁO TOÀN THỂ TỪ ĐẦU ĐẾN HIỆN TẠI (MỚI) ---
        public DataTable GetLifetimeStatistics()
        {
            string query = @"SELECT 
                                ISNULL(SUM(CASE WHEN c.Type = 'Income' THEN t.Amount ELSE 0 END), 0) AS LifetimeIncome,
                                ISNULL(SUM(CASE WHEN c.Type = 'Expense' THEN t.Amount ELSE 0 END), 0) AS LifetimeExpense
                             FROM [Transaction] t
                             JOIN Category c ON t.CategoryID = c.CategoryID";
            return db.ExecuteQuery(query);
        }
    }
}