using MobileFinance.Classes;
using MobileFinance.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileFinance.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AccountsPage : ContentPage
	{
        ObservableCollection<Account> Accounts { get; set; }

        public AccountsPage ()
		{
			InitializeComponent ();
            Accounts = new ObservableCollection<Account>();

            getAccountsBtn.Clicked += getAccountsBtn_Clicked;
            btnShowLandingPage.Clicked += btnShowLandingPage_Clicked;
        }

        private async void getAccountsBtn_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(bankIdEntry.Text))
            {
                List<Account> accounts = await Core.GetAccounts(Convert.ToInt32(bankIdEntry.Text));
                foreach(var acct in accounts)
                {
                    Accounts.Add(acct);
                }               
                AccountsView.ItemsSource = Accounts;
            }
        }

        private async void btnShowLandingPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }


    }
}