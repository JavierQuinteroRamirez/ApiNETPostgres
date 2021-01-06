using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using App.Models;

namespace App.BLL
{
    public static class BLL_UserRegistration
    {
        const string url_UserSP = "https://localhost:44363/api/UserSP"; //Listar usuarios
        const string url_UserTable = "https://localhost:44363/api/UserTable"; //Crear nuevo usuario
        const string url_LocationSP = "https://localhost:44363/api/LocationsSP"; //Listar ubicaciones

        /// <summary>
        /// Se consume la api que consulta la función sp_query_users
        /// que lista todos los usuarios relacionado con su ubicación.
        /// </summary>
        /// <returns></returns>
        public static List<MOD_UserSP> GetListUser()
        {
            var usr = new HttpClient();
            var ListUser = new List<MOD_UserSP>();
            usr.BaseAddress = new Uri(url_UserSP);
            usr.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = usr.GetAsync(usr.BaseAddress).Result;

            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;                
                Newtonsoft.Json.JsonConvert.PopulateObject(data.ToString(), ListUser);
            }

            return ListUser;
        }

        /// <summary>
        /// Se consume la api que lista las ciudades, estados y países relacionados.
        /// </summary>
        /// <returns></returns>
        public static List<MOD_LocationSP> GetListLocations()
        {
            var loc = new HttpClient();
            var ListLocations = new List<MOD_LocationSP>();
            loc.BaseAddress = new Uri(url_LocationSP);
            loc.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = loc.GetAsync(loc.BaseAddress).Result;

            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;                
                Newtonsoft.Json.JsonConvert.PopulateObject(data.ToString(), ListLocations);                
            }

            return ListLocations;
        }

        /// <summary>
        /// Método que hace el POST para crear un nuevo usuario en la tabla usr_user.
        /// </summary>
        /// <param name="NewUser">Instancia de la clase MOD_UserTable</param>
        /// <returns></returns>
        public static string AddNewUser(MOD_UserTable NewUser)
        {
            string Response = string.Empty;
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(NewUser);            

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url_UserTable);
            request.Method = "POST";

            if (json != string.Empty)
            {
                request.ContentType = "application/json;charset=utf-8"; 
                using (StreamWriter swJSONPayload = new StreamWriter(request.GetRequestStream()))
                {
                    swJSONPayload.Write(json);
                    swJSONPayload.Close();
                }
            }

            HttpWebResponse response = null;

            try
            {
                response = (HttpWebResponse)request.GetResponse();
                
                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            Response = reader.ReadToEnd();
                        }
                    }
                }                
            }
            catch (Exception ex)
            {
                Response = ex.Message.ToString();
            }
            finally
            {
                if (response != null)
                {
                    ((IDisposable)response).Dispose();
                }
            }

            return Response;
        }
    }    
}

