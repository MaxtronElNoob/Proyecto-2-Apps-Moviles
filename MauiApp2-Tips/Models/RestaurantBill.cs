using CommunityToolkit.Mvvm.ComponentModel;

public partial class RestaurantBill : ObservableObject
{
		[ObservableProperty]
		private int billTotal;
		[ObservableProperty]
		private double tipPercent;
		[ObservableProperty]
		private int nPeople;
}
