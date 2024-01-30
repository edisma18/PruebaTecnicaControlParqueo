using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using Solution.Bussines.Entities;
using System.Diagnostics;
using System.Data;

namespace Solution.Data
{
    
    public class CustomersDAC
    {

        /// <summary>
        /// Inserts an Customers row.
        /// </summary>
        /// <param name="Customers">An Customers object.</param>
        public Customers Create(Customers customers)
        {
            CustomersEntities ctx = CustomersEntities.Context;//)
        
            try
            {
                ctx.AddToCustomers(customers);                    
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw ex;
            }           

            return customers;
        }


        /// <summary>
        /// Updates an Customers row.
        /// </summary>
        /// <param name="Customers">A Customers object.</param>
        public void Update(Customers Customers)
        {
            CustomersEntities ctx = CustomersEntities.Context;//)
            
            try
            {
                ctx.SaveChanges();               

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw ex;
            }
           
        }


        /// <summary>
        /// Returns a set of Customerss that belongs to an employee
        /// </summary>
        /// <returns>A List of Customerss.</returns>
        public List<Customers> Select()
        {
            List<Customers> resultsList = null;

            CustomersEntities ctx = CustomersEntities.Context;//)
            resultsList = ctx.Customers.ToList();

            return resultsList;

        }

        /// <summary>
        /// Retunr a list of customers
        /// </summary>
        /// <param name="Name">filter of name customer</param>
        /// <returns>list od customers</returns>
        public List<Customers> SelectByName(string Name)
        {
            List<Customers> resultsList = null;
            CustomersEntities ctx = CustomersEntities.Context;

            resultsList = ctx.getCustomersByName(Name).ToList();
            return resultsList;

        }

        public Customers getCustomer(int Id)
        {
            Customers custre = null;
            CustomersEntities ctx = CustomersEntities.Context;
            {
                custre = ctx.Customers.First(e => e.Id == Id);
            }            
            custre.CategoryReference.Load();
            return custre;
        }

        public void Delete(int Id)
        {
            CustomersEntities ctx = CustomersEntities.Context;
            Customers cust = ctx.Customers.First(c => c.Id == Id);
            ctx.DeleteObject(cust);
            ctx.SaveChanges();
        }
    }
}
