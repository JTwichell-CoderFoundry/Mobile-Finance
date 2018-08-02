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
	public partial class TransactionsPage : ContentPage
	{
		public TransactionsPage ()
		{
			InitializeComponent ();
            btnShowLandingPage.Clicked += btnShowLandingPage_Clicked;
        }

        private async void btnShowLandingPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}