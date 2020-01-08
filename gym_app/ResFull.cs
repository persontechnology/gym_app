﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace gym_app
{
    public class ResFull
    {
        public const string urlbase = "http://192.168.1.29:8000/";
        public async Task<T> Get<T>(string url)
        {
            try
            {
                HttpClient cliente = new HttpClient();
                var contenido = await cliente.GetAsync(urlbase + url);
                if (contenido.StatusCode == HttpStatusCode.OK || contenido.Content != null)
                {
                    var json = await contenido.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<T>(json);

                }
            }
            catch (Exception)
            {

                throw;
            }
            return default(T);
        }
    }
}
