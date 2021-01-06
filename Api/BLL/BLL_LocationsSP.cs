using System;
using System.Collections.Generic;
using System.Linq;
using Api.Models;
using Api.DAL;
using System.Data;

namespace Api.BLL
{
    public static class BLL_LocationsSP
    {
        /// <summary>
        /// Se convierte el datatable que contiene los países, departamento y ciudades relacionados
        /// en un listado de la clase MOD_LocationsSP
        /// </summary>
        /// <returns></returns>
        public static List<MOD_LocationsSP> Query_Locations()
        {
            var dt = DAL_StoredProcedures.Query_Locations();
            var LisLocations = new List<MOD_LocationsSP>();

            if (dt.Rows.Count > 0)
            {
                LisLocations = dt.AsEnumerable().Select
                    (
                        s => new MOD_LocationsSP()
                        {
                            Id_cty = Convert.ToInt32(s["id_cty"]),
                            Name_cty = Convert.ToString(s["name_cty"]),
                            Id_ste = Convert.ToInt32(s["id_ste"]),
                            Name_ste = Convert.ToString(s["name_ste"]),
                            Id_cit = Convert.ToInt32(s["id_cit"]),
                            Name_cit = Convert.ToString(s["name_cit"])
                        }
                    ).ToList();
            }
            return LisLocations;
        }
    }
}
