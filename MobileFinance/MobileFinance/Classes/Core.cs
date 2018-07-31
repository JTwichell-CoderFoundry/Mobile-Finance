using MobileFinance.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MobileFinance.Classes
{
    class Core
    {
        public static async Task<Household> GetHousehold(int householdId)
        {
            string queryString = string.Format("http://daytwo-financeapi.azurewebsites.net:80/api/Households/GetHousehold?householdId={0}", householdId);

            dynamic results = await DataService.getFinanceApiData(queryString).ConfigureAwait(false);
            if(results["Id"] != null)
            {
                var household = new Household();
                household.Name = (string)results["Name"];
                household.Description = (string)results["Description"];
                return household;
            }
            else
            {
                return null;
            }

        }      
                
                
                
                }
}
