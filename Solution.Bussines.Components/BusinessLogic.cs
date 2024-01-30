using System;
using Solution.Bussines.Components;
using Solution.Bussines.Entities;
using Solution.Data;

namespace Solution.BusinessLogic
{
	public class Managers
    {
		public Managers()
		{

		}

		public Carros GetVehiculo(string placa)
		{
            CarrosDAC dac = new CarrosDAC();
            return dac.getCarro(placa);

		}

		public RegistroTiemposParqueo RegistrarEntrada(RegistroTiemposParqueo tiempo)
		{
            RegistroTiemposParqueoAC dac = new RegistroTiemposParqueoAC();
            RegistroTiemposParqueo rt = dac.getRegistroTiempo(tiempo.Placa);

            RegistroEntradasComponent rc = new RegistroEntradasComponent();

            if (rt != null)
			{
                if (rt.EstaParqueado.Value)
                {
                    return null;
                }
                else
                {
                    rt.EstaParqueado = true;
                    rt.HoraSalida = null;
                    rt.HoraIngreso = DateTime.Now;
                    return rc.UpdateRegistroEntrada(rt);
                }
            }

			return rc.CreateRegistroEntrada(tiempo);
		}

        public RegistroTiemposParqueo RegistrarSalida(RegistroTiemposParqueo tiempo)
        {
            RegistroTiemposParqueoAC dac = new RegistroTiemposParqueoAC();
            RegistroTiemposParqueo rt = dac.getRegistroTiempo(tiempo.Placa);

            if (rt != null)
            {
				rt.HoraSalida = DateTime.Now;
                rt.EstaParqueado = false;

                TimeSpan ts = DateTime.Now - rt.HoraIngreso;

                rt.TiempoAcumulado = System.Convert.ToInt32(ts.TotalMinutes);
            }
            else { return null; }

            RegistroEntradasComponent rc = new RegistroEntradasComponent();
            return rc.UpdateRegistroEntrada(tiempo);
        }
    }
}