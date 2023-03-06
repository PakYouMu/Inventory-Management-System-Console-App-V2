using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System_Console_App
{
    public class Category : ICloneable
    {
        private string? name;

        private List<string> listOfCategory = new List<string>(); 
        private int CategoryID;
        private static int nextCategoryID = 1;
        public Category(string name)
        {
            this.name = name;
            this.CategoryID = nextCategoryID;
            nextCategoryID++;
        }

        public Category(Category category)
        {
            this.name = category.name;
        }

        public Category()
        {
        }
        
        public string? GetName
        {
            get { return name; }
        }

        public List<string> AddSubCategory(string categoryName) 
        {
            this.listOfCategory.Add(categoryName);
            return this.listOfCategory;
        }

        public void RemoveSubCategory(string categoryName)
        {
            this.listOfCategory.RemoveAll(o => o == categoryName);
        }

        public object Clone()
        {
            return new Category(this);
        }
    }
}
