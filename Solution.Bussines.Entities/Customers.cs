using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.ComponentModel;

namespace Solution.Bussines.Entities
{
    public partial class Customers
    {
        public const string EntitySetName = "Customers";


        [Browsable(false)]
        public string CategoryName
        {
            get
            {
                string res = "";
                if (this.Category != null)
                { 
                    res = this.Category.Name; 
                }
                else if (this.CategoryReference != null)
                {
                    this.CategoryReference.Load();
                    if (this.Category != null)
                    { 
                        res = this.Category.Name; 
                    }
                }

                return res;
            }
            set
            {
                this.CategoryReference.EntityKey =
                    new EntityKey("CustomersEntities.Category", "CategoryId", value);
            }
        }

    }
}
