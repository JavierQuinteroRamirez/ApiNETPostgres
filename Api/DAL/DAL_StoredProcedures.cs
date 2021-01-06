using Npgsql;
using System;
using System.Data;

namespace Api.DAL
{
    public static class DAL_StoredProcedures
    {
        /// <summary>
        /// Retorna un datatable de usuarios según identificación aportada
        /// </summary>
        /// <param name="Id">Identificación del usuario (opcional)</param>
        /// <returns></returns>
        public static DataTable Query_Users(int Id)
        {
            try
            {
                DataTable dt = new DataTable();
                using (var NpgsqConn = new NpgsqlConnection(DAL_Connection.ConnPostgres))
                {
                    var cmd = new NpgsqlCommand("sp_query_users", NpgsqConn);
                    using (var da = new NpgsqlDataAdapter(cmd))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = Id;
                        da.Fill(dt);
                    }
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Retorna un datatable con todas los países, departamentos y ciudades relacionados.
        /// </summary>
        /// <returns></returns>
        public static DataTable Query_Locations()
        {
            try
            {
                DataTable dt = new DataTable();
                using (var NpgsqConn = new NpgsqlConnection(DAL_Connection.ConnPostgres))
                {
                    var cmd = new NpgsqlCommand("sp_query_locations", NpgsqConn);
                    using (var da = new NpgsqlDataAdapter(cmd))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        da.Fill(dt);
                    }
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
