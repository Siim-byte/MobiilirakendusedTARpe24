namespace Naidis_TARpe24;

public partial class PopUp_kasutamine : ContentPage
{
	public PopUp_kasutamine()
	{

        Button alertQuestButton = new Button
        {
            Text = "Arvuta",
            VerticalOptions = LayoutOptions.Start,
            HorizontalOptions = LayoutOptions.Center
        };
        alertQuestButton.Clicked += AlertQuestButton_Clicked;

        Button mButton = new Button
        {
            Text = "Mõistatus",
            VerticalOptions = LayoutOptions.Start,
            HorizontalOptions = LayoutOptions.Center
        };
        mButton.Clicked += mButton_Clicked;

        Content = new VerticalStackLayout()
        {
            Spacing = 20,//jätab nuppude vahele 20 pikslit vaba ruumi
            Padding = new Thickness(0, 50, 0, 0), //lükkab sisu veidi ülevalt alla
            Children = { alertQuestButton, mButton }
        };
    }

    private async void AlertQuestButton_Clicked(object sender, EventArgs e)
    {
        string result1 = await DisplayPromptAsync("Vasta", "Millega võrdub 5 x 5?", initialValue: "", maxLength: 2, keyboard: Keyboard.Numeric);
        if (result1 == "25")
        {
            await DisplayAlertAsync("Õige", "vastus on 25.", "OK");
        }
        else
        {
            await DisplayAlertAsync("Vale", "Proovi uuesti", "OK");
        }
    }
    private async void mButton_Clicked(object? sender, EventArgs e)
    {
        await DisplayAlertAsync("Vasta", "Mis värvi on öö", "Must", "Valge");
    }
}
