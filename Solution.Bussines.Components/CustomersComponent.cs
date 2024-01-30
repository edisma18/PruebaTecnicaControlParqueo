using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Transactions;
using Solution.Data;


using Solution.Bussines.Entities ;

namespace Solution.Bussines.Components
{
    public class CustomersComponent
    {
        /// <summary>
        /// Submit an Customers.
        /// </summary>
        /// <param name="Customers">An Customers object.</param>
        public Customers CreateCustomer(Customers customers)
        {
            Console.WriteLine("Submitting... ");                       

            //using (TransactionScope ts =
            //    new TransactionScope(TransactionScopeOption.Required))
            //{
                try
                {
                    customers = CreateCustomers(customers);                   
                    //ts.Complete();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw ex;
                }
            //}

            Console.WriteLine("New CustomersID = " + customers.Id.ToString());

            return customers;
        }

        /// <summary>
        /// Submit changes of customer
        /// </summary>
        /// <param name="customers">customer for update</param>
        /// <returns>a customers object</returns>
        public Customers UpdateCustomer(Customers customers)
        {
            //using (TransactionScope ts =
            //    new TransactionScope(TransactionScopeOption.Required))
            //{
                try
                {
                    
                    customers = UpdateCustomers(customers);                   
                    //ts.Complete();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw ex;
                }
            //}

            return customers;
        }

        /// <summary>
        /// Creates a new Customers record in the database.
        /// </summary>
        /// <param name="customers">An Customers object.</param>
        private Customers CreateCustomers(Customers customers)
        {
            // Business logic.

            Console.WriteLine(customers.ToString());

            // Persist data.
            CustomersDAC dac = new CustomersDAC();
            return dac.Create(customers);
        }

        /// <summary>
        /// Updates the Customers information into the database.
        /// </summary>
        /// <param name="customers">An Customers object.</param>
        private Customers UpdateCustomers(Customers customers)
        {
            // Business logic.
            Console.WriteLine(customers.ToString());

            // Persist data.
            CustomersDAC dac = new CustomersDAC();
            dac.Update(customers);

            return customers;
        }

        /// <summary>
        /// Return a list of customers
        /// </summary>
        /// <returns></returns>
        public List<Customers> ListCustomers()
        {
            // Retrieve data.
            CustomersDAC dac = new CustomersDAC();
            return dac.Select();
        }

        /// <summary>
        /// return a list of customers by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<Customers> ListCustomersByName(string name)
        {
            // Retrieve data.
            CustomersDAC dac = new CustomersDAC();
            return dac.SelectByName(name);
        }

        /// <summary>
        /// Get a customer by id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Customers getCustomer(int Id)
        {
            CustomersDAC dac = new CustomersDAC();
            return dac.getCustomer(Id);
        }

        /// <summary>
        /// get a list of categories 
        /// </summary>
        /// <returns></returns>
        public List<Category> ListCategories()
        {
            CategoryDAC category = new CategoryDAC();
            return category.Select();

        }

        /// <summary>
        /// get a category by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Category GetCategory(int id)
        {
            CategoryDAC category = new CategoryDAC();
            return category.GetCategory(id);
        }

        /// <summary>
        /// Delete a customer by id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public void delCustomer(int Id)
        {
            CustomersDAC dac = new CustomersDAC();
            dac.Delete(Id);
        }

        public List<Customers> SelectByName(string Name)
        {
            CustomersDAC dac = new CustomersDAC();
            return dac.SelectByName(Name);
        }
    }
}
