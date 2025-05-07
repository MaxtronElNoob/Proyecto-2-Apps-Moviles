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
	}
}

public partial class UserViewModel : ObservableObject
{
	[ObservableProperty]
	private string name;

	[ObservableProperty]
	private string email;

	public UserViewModel()
	{
		// Inicializamos con datos por defecto
		Name = "azul";
		Email = "";
	}
	[RelayCommand]
	public void LoadUser(){

		// Inicializamos con datos por defecto
		Name = "Juan Perez";
		Email = "juan@example.com";

	}
}

