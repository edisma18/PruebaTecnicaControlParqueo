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

    public class RegistroTiemposParqueoAC
    {

        /// <summary>
        /// Inserts an Carros row.
        /// </summary>
        /// <param name="RegistroTiemposParqueo">An Carros object.</param>
        public RegistroTiemposParqueo Create(RegistroTiemposParqueo tiempo)
        {
            CustomersEntities ctx = CustomersEntities.Context;//)

            try
            {
                ctx.AddToRegistroTiemposParqueo(tiempo);
                ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw ex;
            }

            return tiempo;
        }


        /// <summary>
        /// Updates an Carros row.
        /// </summary>
        /// <param name="Carros">A Carros object.</param>
        public void Update(RegistroTiemposParqueo tiempo)
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
        public List<RegistroTiemposParqueo> Select()
        {
            List<RegistroTiemposParqueo> resultsList = null;

            CustomersEntities ctx = CustomersEntities.Context;//)
            resultsList = ctx.RegistroTiemposParqueo.ToList();

            return resultsList;

        }

        /// <summary>
        /// Retunr a list of carros
        /// </summary>
        /// <param name="Name">filter of name customer</param>
        /// <returns>list od carros</returns>
        public List<RegistroTiemposParqueo> SelectByPlaca(string placa)
        {
            List<RegistroTiemposParqueo> resultsList = null;
            //CustomersEntities ctx = CustomersEntities.Context;

            //resultsList = ctx.getRegistrosParqueoByPlaca(placa).ToList();
            return resultsList;

        }

        public RegistroTiemposParqueo getRegistroTiempo(string placa)
        {
            RegistroTiemposParqueo car = null;
            CustomersEntities ctx = CustomersEntities.Context;
            {
                car = ctx.RegistroTiemposParqueo.FirstOrDefault(e => e.Placa == placa);
            }
            return car;
        }

        public void Delete(int Id)
        {
            CustomersEntities ctx = CustomersEntities.Context;
            RegistroTiemposParqueo tiempo = ctx.RegistroTiemposParqueo.First(c => c.Id == Id);
            ctx.DeleteObject(tiempo);
            ctx.SaveChanges();
        }
    }
}
