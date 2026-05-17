using System;

namespace ExpenseManagerApp
{
    /// <summary>
    /// Data model class representing a Category for transactions.
    /// </summary>
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }

        // Type can be "Income" or "Expense"
        public string Type { get; set; }

        public Category() { }

        public Category(int id, string name, string type)
        {
            CategoryID = id;
            Name = name;
            Type = type;
        }

        // Override ToString to display the Name nicely in ComboBoxes
        public override string ToString()
        {
            return Name;
        }
    }
}
