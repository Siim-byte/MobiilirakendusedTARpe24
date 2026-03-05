namespace Naidis_TARpe24;

public partial class PickerImageGridPage : ContentPage
{
	Grid gr4x1, gr3x3;
	Picker picker;
	Image img;
	Switch s_pilt, s_grid;
	Random rnd = new Random();
	public PickerImageGridPage()
	{
		gr4x1 = new Grid()
		{
			RowDefinitions =
			{
				new RowDefinition {Height = new GridLength(1, GridUnitType.Star)},
				new RowDefinition {Height = new GridLength(3, GridUnitType.Star)},
				new RowDefinition {Height = new GridLength(3, GridUnitType.Star)},
				new RowDefinition {Height = new GridLength(1, GridUnitType.Star)},
			},
			ColumnDefinitions =
			{
				new ColumnDefinition {Width = new GridLength(1,GridUnitType.Star)},
				new ColumnDefinition {Width = new GridLength(1,GridUnitType.Star)},
			},
		};
	}
}