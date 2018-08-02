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
	public partial class HouseholdPage : ContentPage
	{
		public HouseholdPage ()
		{
			InitializeComponent ();
            getHouseholdBtn.Clicked += getHouseholdBtn_Clicked;
            btnShowLandingPage.Clicked += btnShowLandingPage_Clicked;
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

        private async void btnShowLandingPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();          
        }

    }
}