using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Solution.Bussines.Entities;

namespace Solution.Data
{
    public class CategoryDAC
    {
        public List<Category> Select()
        {
            List<Category> resultsList = null;

            CustomersEntities ctx = CustomersEntities.Context;
            resultsList = ctx.Category.ToList();
                   // (from category in ctx.Category
                   //  select category).ToList();

            return resultsList;
        }


        public Category GetCategory(int Id)
        {
            Category result = null;
                        
            CustomersEntities ctx = CustomersEntities.Context;            
            result = ctx.Category.First(c => c.Id == Id);                
                
            return result;
        }
    }
}
