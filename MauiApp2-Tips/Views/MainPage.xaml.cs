namespace MauiApp2_Tips;

public partial class MainPage : ContentPage
{
		public MainPage()
		{
				InitializeComponent();
				BindingContext = new BillViewModel();
		}
		public void Alert(string message)
		{
				DisplayAlert("Alert", message, "OK");
		}
}

