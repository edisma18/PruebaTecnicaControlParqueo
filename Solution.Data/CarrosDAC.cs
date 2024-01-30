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

    public class CarrosDAC
    {

        /// <summary>
        /// Inserts an Carros row.
        /// </summary>
        /// <param name="Carros">An Carros object.</param>
        public Carros Create(Carros carros)
        {
            CustomersEntities ctx = CustomersEntities.Context;//)

            try
            {
                ctx.AddToCarros(carros);
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw ex;
            }

            return carros;
        }


        /// <summary>
        /// Updates an Carros row.
        /// </summary>
        /// <param name="Carros">A Carros object.</param>
        public void Update(Carros Carros)
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
        /// Returns a set of Carross that belongs to an employee
        /// </summary>
        /// <returns>A List of Carross.</returns>
        public List<Carros> Select()
        {
            List<Carros> resultsList = null;

            CustomersEntities ctx = CustomersEntities.Context;//)
            resultsList = ctx.Carros.ToList();

            return resultsList;

        }

        /// <summary>
        /// Retunr a list of carros
        /// </summary>
        /// <param name="Name">filter of name customer</param>
        /// <returns>list od carros</returns>
        public List<Carros> SelectByName(string Name)
        {
            List<Carros> resultsList = null;
            //CustomersEntities ctx = CustomersEntities.Context;

            //resultsList = ctx.getCarrosByName(Name).ToList();
            return resultsList;

        }

        public Carros getCarro(string placa)
        {
            Carros car = null;
            CustomersEntities ctx = CustomersEntities.Context;
            {
                car = ctx.Carros.FirstOrDefault(e => e.Placa == placa);
            }
            return car;
        }

        public void Delete(int Id)
        {
            CarrosEntities ctx = CarrosEntities.Context;
            //Carros cust = ctx.Carros.First(c => c.Id == Id);
            //ctx.DeleteObject(cust);
            //ctx.SaveChanges();
        }
    }
}
