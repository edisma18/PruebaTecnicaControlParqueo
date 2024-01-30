﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web;

namespace Solution.Bussines.Entities
{
    public partial class CarrosEntities
    {
        public static CarrosEntities Context
        {
            get
            {
                string objectContextKey = HttpContext.Current.GetHashCode().ToString("x");
                if (!HttpContext.Current.Items.Contains(objectContextKey))
                {
                    HttpContext.Current.Items.Add(objectContextKey, new CarrosEntities());
                }
                return HttpContext.Current.Items[objectContextKey] as CarrosEntities;
            }
        }

        /*
        protected override void Dispose(bool disposing)
        {

            foreach (var entry in 
                ObjectStateManager.GetObjectStateEntries(
                    EntityState.Added | EntityState.Deleted | EntityState.Modified | EntityState.Unchanged))
                    if(entry.Entity != null) 
                        Detach(entry.Entity);

            base.Dispose(disposing);

        }
        */

    }
}
