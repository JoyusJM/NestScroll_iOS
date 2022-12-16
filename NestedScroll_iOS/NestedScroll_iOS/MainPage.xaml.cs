using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace NestedScroll_iOS;

public partial class MainPage : ContentPage
{
    public class AccountDetails
    {
        public string Title { get; set; }
        public string Description { get; set; }

    }

    ObservableCollection<AccountDetails> accountDetails = new ObservableCollection<AccountDetails>();
    public ObservableCollection<AccountDetails> AccountDetail { get { return accountDetails; } }

    public MainPage()
	{
		InitializeComponent();
        accountDetails.Add(new AccountDetails() { Title = "Acccount Balance", Description = "£30,000" });
        accountDetails.Add(new AccountDetails() { Title = "Acccount number", Description = "1234567890" });
        accountDetails.Add(new AccountDetails() { Title = "Acccount type", Description = "Online Saver" });
        accountDetails.Add(new AccountDetails() { Title = "Interest frequency", Description = "Annual" });
        accountDetails.Add(new AccountDetails() { Title = "Interest rate", Description = "2.25% gross" });
        accountDetails.Add(new AccountDetails() { Title = "Next interest due", Description = "31 Jan 2023" });
        collectionView.ItemsSource = accountDetails;
    }

	
}


