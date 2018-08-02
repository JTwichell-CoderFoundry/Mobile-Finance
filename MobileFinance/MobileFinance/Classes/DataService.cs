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
            string json = "";

            try
            {
                var response = await client.GetAsync(queryString);
                if (response != null)
                {
                    json = response.Content.ReadAsStringAsync().Result;
                }
            }
            catch (Exception ex)
            {
                var error = ex.Message;
            }

            return json;
        }
    }
}
