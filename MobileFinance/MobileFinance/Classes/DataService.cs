﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MobileFinance.Classes
{
    class DataService
    {
        public static async Task<dynamic> getFinanceApiData(string queryString)
        {
            var client = new HttpClient();
            var response = await client.GetAsync(queryString);

            dynamic data = null;
            if(response != null)
            {
                var json = response.Content.ReadAsStringAsync().Result;
                data = JsonConvert.DeserializeObject(json);
            }
            return data;
        }

    }
}