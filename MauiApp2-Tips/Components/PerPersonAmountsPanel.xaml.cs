namespace MauiApp2_Tips.Components;
public partial class PerPersonAmountsPanel : Grid
{
		public PerPersonAmountsPanel()
		{
				InitializeComponent();
		}
		public static readonly BindableProperty SubtotalProperty =
				BindableProperty.Create(
					nameof(Subtotal),
					typeof(int),
					typeof(PerPersonAmountsPanel),
					default(int));

		public int Subtotal
		{
				get => (int)GetValue(SubtotalProperty);
				set => SetValue(SubtotalProperty, value);
		}

		public static readonly BindableProperty TipAmountProperty =
				BindableProperty.Create(
					nameof(TipAmount),
					typeof(int),
					typeof(PerPersonAmountsPanel),
					default(int));

		public int TipAmount
		{
				get => (int)GetValue(TipAmountProperty);
				set => SetValue(TipAmountProperty, value);
		}

		public static readonly BindableProperty PerPersonAmountProperty =
				BindableProperty.Create(
					nameof(PerPersonAmount),
					typeof(int),
					typeof(PerPersonAmountsPanel),
					default(int));

		public int PerPersonAmount
		{
				get => (int)GetValue(PerPersonAmountProperty);
				set => SetValue(PerPersonAmountProperty, value);
		}
}
