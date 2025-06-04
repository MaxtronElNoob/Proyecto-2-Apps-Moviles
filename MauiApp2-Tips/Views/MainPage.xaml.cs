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

	public void TipSlider_ValueChanged(object sender, ValueChangedEventArgs e){
	    double value = e.NewValue;
	    double sliderWidth = TipSlider.Width;

	    double usableWidth = sliderWidth - 30;
	    double thumbX = value * usableWidth;

	    TipLabel.TranslationX = thumbX;
	}
}

