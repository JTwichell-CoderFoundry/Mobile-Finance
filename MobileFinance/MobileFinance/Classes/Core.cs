using MobileFinance.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace MobileFinance.Classes
{
    class Core
    {
        public static async Task<Household> GetHousehold(int householdId)
        {
            string queryString = string.Format("http://daytwo-financeapi.azurewebsites.net:80/api/Households/GetHousehold?householdId={0}", householdId);
            string json = await DataService.getFinanceApiData(queryString).ConfigureAwait(false);
            if(json != null)
            {
                return JsonConvert.DeserializeObject<Household>(json);
            }
            else
            {
                return null;
            }        
        }

        public static async Task<List<Account>> GetAccounts(int bankId)
        {            
            string queryString = string.Format("http://daytwo-financeapi.azurewebsites.net:80/api/Accounts/GetAccounts?bankId={0}", bankId);
            string json = await DataService.getFinanceApiData(queryString).ConfigureAwait(false);
            if (json != null)
            {
                return JsonConvert.DeserializeObject<List<Account>>(json);
            }
            else
            {
                return null;
            }
        }
    }
}
