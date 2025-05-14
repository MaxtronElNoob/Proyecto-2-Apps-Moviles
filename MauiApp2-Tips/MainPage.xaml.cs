using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiApp2_Tips;

public partial class MainPage : ContentPage
{
	private UserViewModel viewModel;
	public MainPage()
	{
		InitializeComponent();
		viewModel = new UserViewModel();
		BindingContext = viewModel;
		//viewModel.Page = this;
	}
	public void Alert(string message)
	{
		DisplayAlert("Alert", message, "OK");
	}
}

public partial class UserViewModel : ObservableObject
{
	public IRelayCommand<string> UpdateTipCommand2 { get; }
	public UserViewModel()
	{
		UpdateTipCommand2 = new RelayCommand<string>(UpdateTip);
	}
	//public MainPage Page { get; set; }
	[ObservableProperty]
	private int people = 1;
	[ObservableProperty]
	private int tip_porcentage;
	[ObservableProperty]
	private int total_personal;
	[ObservableProperty]
	private int valor_boleta;
	[ObservableProperty]
	private int subtotal;
	[ObservableProperty]
	private int tip;

	private void UpdateTip(string? Button_porcentage){
		Tip_porcentage = int.Parse(Button_porcentage??"0");
		UpdateTotal();
	}
	
	public void UpdateTotal(){
		Subtotal = Valor_boleta / People;
		Tip = (int)(Subtotal*(double)Tip_porcentage/100);
		Total_personal = Tip + Valor_boleta;
	}
	// private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
	// {
	// 	ViewModel.Equals.
	// 	UserViewModel.UpdateTip((int) e.NewValue);
		
	// }

}

