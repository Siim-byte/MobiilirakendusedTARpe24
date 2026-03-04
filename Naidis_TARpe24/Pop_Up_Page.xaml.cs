namespace Naidis_TARpe24;

public partial class Pop_Up_Page : ContentPage
{
	public Pop_Up_Page()
	{
		//InitializeComponent();
		// 1. Loome esimese nupu (Lihtne teade)
		Button alertButton = new Button()
		{
			Text = "Teade",
			VerticalOptions = LayoutOptions.Start,
			HorizontalOptions = LayoutOptions.Center,
		};
		// Seome nupu klikkimise sündmuse funktsiooniga
		alertButton.Clicked += AlertButton_Clicked;

		//2. Loome teise nupu (Kiinitus)
		Button alertYesNoButton = new Button()
		{
			Text = "Jah või ei",
			VerticalOptions = LayoutOptions.Start,
			HorizontalOptions = LayoutOptions.Center,
		};
		alertYesNoButton.Clicked += AlertYesNoButton_Clicked;

		//3. Loome kolmanda nupu (valikmenüü)
		Button alertListButton = new Button()
		{
			Text = "Valik",
			VerticalOptions = LayoutOptions.Start,
			HorizontalOptions = LayoutOptions.Center
		};
		alertListButton.Clicked += AlertListButton_Clicked;

		Button alertQuestButton = new Button
		{
			Text = "Küsimus",
			VerticalOptions = LayoutOptions.Start,
			HorizontalOptions = LayoutOptions.Center
		};
		alertQuestButton.Clicked += AlertQuestButton_Clicked;

		//4. Paigutame kõik nupud ekraanile üksteise alla
		Content = new VerticalStackLayout()
		{
			Spacing = 20,//jätab nuppude vahele 20 pikslit vaba ruumi
			Padding = new Thickness(0,50,0,0), //lükkab sisu veidi ülevalt alla
			Children = {alertButton, alertYesNoButton, alertListButton, alertQuestButton}
		};
	}
	private async void AlertButton_Clicked(object? sender, EventArgs e)
	{
		await DisplayAlertAsync("Teade", "Teil on uus teade", "OK");
	}
	private async void AlertYesNoButton_Clicked(object? sender, EventArgs e)
	{
		//küsime kasutajalt kinnitust ( tagastab true või false)
		bool result = await DisplayAlertAsync("Kinnitus", "Kas oled kindel?", "Olen kindel", "Ei ole kindel");

		//kuvame uue teate vastavalt sellele, mida kasutaja valis
		// (result ? "Jah" : "Ei" Tähendab result on truem kirjuta "Jah", muidu "Ei".
		await DisplayAlertAsync("Teade", "Teie valik on: " + (result ? "Jah" : "Ei"), "OK");
		
	}
	private async void AlertListButton_Clicked(object? sender, EventArgs e)
	{
		//Kuvab menüü ja salvestab kasutaja valitud teksti muutujasse 'action'
		string action = await DisplayActionSheetAsync("Mida teha?", "Loobu", "Kustutada", "Tantsida", "Laulda", "Joonestada");

		//kontrollime, et kasutaja ei vajutanud lihtsalt kõrvale ega valinud "Loobu"
		if (action != null && action != "Loobu")
		{
			await DisplayAlertAsync("Valik", "Sa valisid tegevuse: " + action, "OK");
		}
	}
	private async void AlertQuestButton_Clicked(object sender, EventArgs e)
	{
		string result1 = await DisplayPromptAsync("Vasta", "Millega võrdub 5 x 5?", initialValue: "", maxLength: 2, keyboard: Keyboard.Numeric);
	}
}