using MobileFinance.Classes;
using MobileFinance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileFinance.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MobileFinancePage : ContentPage
	{
		public MobileFinancePage ()
		{
			InitializeComponent ();
            getHouseholdBtn.Clicked += getHouseholdBtn_Clicked;

            this.BindingContext = new Household();
        }

        private async void getHouseholdBtn_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(householdIdEntry.Text))
            {
                var household = await Core.GetHousehold(Convert.ToInt32(householdIdEntry.Text));
                this.BindingContext = household;
            }
        }

    }
}