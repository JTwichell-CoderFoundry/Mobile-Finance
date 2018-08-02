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
	public partial class Landing : ContentPage
	{
		public Landing ()
		{
			InitializeComponent ();
            btnHouseholds.Clicked += btnHouseholds_Clicked;
            btnAccounts.Clicked += btnAccounts_Clicked;
            btnTransactions.Clicked += btnTransactions_Clicked;
            btnBudgets.Clicked += btnBudgets_Clicked;

        }

        private async void btnHouseholds_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HouseholdPage());
        }

        private async void btnAccounts_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AccountsPage());
        }

        private async void btnTransactions_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TransactionsPage());
        }

        private async void btnBudgets_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BudgetsPage());
        }

    }
}