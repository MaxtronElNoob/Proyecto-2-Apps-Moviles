using Android.App;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;

namespace MauiApp2_Tips;
public partial class BillViewModel : ObservableObject
{
	[ObservableProperty]
	private RestaurantBill bill;

	public int subtotal => (int)(Bill.BillTotal / Bill.NPeople);
	public int tipAmount => (int)Math.Round(subtotal * Bill.TipPercent);
	public int perPersonAmount => subtotal + tipAmount;

	public string BillTotalText
	{
		get => Bill.BillTotal.ToString();
		set
		{
			if (int.TryParse(value, out var result))
			{
				Bill.BillTotal = result;
				OnPropertyChanged(nameof(subtotal));
				OnPropertyChanged(nameof(tipAmount));
				OnPropertyChanged(nameof(perPersonAmount));
			}
		}
	}

	public string TipPercentText
	{
		get => Bill.TipPercent.ToString();
		set
		{
			if (float.TryParse(value, out var result))
			{
				Bill.TipPercent = result;
				OnPropertyChanged(nameof(subtotal));
				OnPropertyChanged(nameof(tipAmount));
				OnPropertyChanged(nameof(perPersonAmount));
			}
		}
	}

	// private int calculateTipAmount()
	// {
	// 	return (int)(subtotal * Bill.TipPercent);
	// }

	// private int calculatePerPersonSubtotal()
	// {
	// 	return (int)(Bill.BillTotal / Bill.NPeople);

	// }

	// private int calculatePerPersonAmount()
	// {
	// 	int perPersonSplit = subtotal + tipAmount;
	// 	return perPersonSplit;
	// }

	private void OnBillChanged(object sender, PropertyChangedEventArgs e)
	{
		Console.WriteLine("Actualizando Valores...");
		OnPropertyChanged(nameof(subtotal));
		OnPropertyChanged(nameof(tipAmount));
		OnPropertyChanged(nameof(perPersonAmount));
	}

	public BillViewModel()
	{
		Bill = new RestaurantBill { BillTotal = 0, TipPercent = 0.0, NPeople = 1 };
		Bill.PropertyChanged += OnBillChanged;
	}

	[RelayCommand]
	private void UpdateTip(string? Button_porcentage)
	{
		Console.WriteLine("Cambio de propina a: " + Button_porcentage);
		TipPercentText = Button_porcentage ?? "0.0";
	}

	[RelayCommand]
	public void updateTotal(int? Label_total)
	{
		Bill.BillTotal = Label_total ?? 0;

	}
	[RelayCommand]
	public void updateNPeople(int? Label_people)
	{
		Bill.NPeople = Label_people ?? 1;
	}
}
