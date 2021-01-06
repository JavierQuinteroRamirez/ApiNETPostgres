using System;
using System.Collections.Generic;
using System.Linq;
using Api.Models;
using Api.DAL;
using System.Data;

namespace Api.BLL
{
    public static class BLL_UserSP
    {
        /// <summary>
        /// Retorna una instancia o un listado de la clase MOD_UserSP
        /// </summary>
        /// <param name="Id">Identificación del usuario (opcional)</param>
        /// <returns></returns>
        public static List<MOD_UserSP> Query_Users(int Id = 0)
        {
            var dt = DAL_StoredProcedures.Query_Users(Id);
            var ListUsers = new List<MOD_UserSP>();

            if (dt.Rows.Count > 0)
            {
                ListUsers = dt.AsEnumerable().Select
                    (
                        s => new MOD_UserSP()
                        {
                            IdUsuario = Convert.ToInt32(s["IdUsuario"]),
                            Nombres = Convert.ToString(s["Nombres"]),
                            Apellidos = Convert.ToString(s["Apellidos"]),
                            Telefono = Convert.ToString(s["Telefono"]),
                            Direccion = Convert.ToString(s["Direccion"]),
                            Pais = Convert.ToString(s["Pais"]),
                            Departamento = Convert.ToString(s["Departamento"]),
                            Ciudad = Convert.ToString(s["Ciudad"])
                        }
                    ).ToList();
            }
            return ListUsers;
        }
    }
}
