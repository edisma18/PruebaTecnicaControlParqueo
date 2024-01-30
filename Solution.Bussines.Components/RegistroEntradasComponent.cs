using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Transactions;
using Solution.Data;


using Solution.Bussines.Entities;

namespace Solution.Bussines.Components
{
    public class RegistroEntradasComponent
    {
        /// <summary>
        /// Submit an Customers.
        /// </summary>
        /// <param name="Customers">An Customers object.</param>
        public RegistroTiemposParqueo CreateRegistroEntrada(RegistroTiemposParqueo tiempo)
        {
            Console.WriteLine("Submitting... ");

            //using (TransactionScope ts =
            //    new TransactionScope(TransactionScopeOption.Required))
            //{
            try
            {
                tiempo = CreateRegistrosEntrada(tiempo);
                //ts.Complete();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            //}

            //Console.WriteLine("Nueva entrada = " + tiempo.HoraIngreso);

            return tiempo;
        }

        /// <summary>
        /// Submit changes of customer
        /// </summary>
        /// <param name="customers">customer for update</param>
        /// <returns>a customers object</returns>
        public RegistroTiemposParqueo UpdateRegistroEntrada(RegistroTiemposParqueo tiempo)
        {
            //using (TransactionScope ts =
            //    new TransactionScope(TransactionScopeOption.Required))
            //{
            try
            {

                tiempo = UpdateRegistrosEntrada(tiempo);
                //ts.Complete();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            //}

            return tiempo;
        }

        /// <summary>
        /// Creates a new Customers record in the database.
        /// </summary>
        /// <param name="customers">An Customers object.</param>
        private RegistroTiemposParqueo CreateRegistrosEntrada(RegistroTiemposParqueo tiempo)
        {
            // Business logic.

            Console.WriteLine(tiempo.ToString());

            // Persist data.
            RegistroTiemposParqueoAC dac = new RegistroTiemposParqueoAC();
            return dac.Create(tiempo);
        }

        /// <summary>
        /// Updates the Customers information into the database.
        /// </summary>
        /// <param name="customers">An Customers object.</param>
        private RegistroTiemposParqueo UpdateRegistrosEntrada(RegistroTiemposParqueo tiempo)
        {
            // Business logic.
            Console.WriteLine(tiempo.ToString());

            // Persist data.
            RegistroTiemposParqueoAC dac = new RegistroTiemposParqueoAC();
            dac.Update(tiempo);

            return tiempo;
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
