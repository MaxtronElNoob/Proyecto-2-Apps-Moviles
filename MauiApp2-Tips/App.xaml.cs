namespace MauiApp2_Tips;

public partial class App : Application
{
		public App()
		{
				InitializeComponent();
				BindingContext = new BillViewModel();

				MainPage = new AppShell();
		}
}
