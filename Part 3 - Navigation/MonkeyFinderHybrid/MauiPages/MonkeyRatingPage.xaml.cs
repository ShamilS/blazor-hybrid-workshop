namespace MonkeyFinderHybrid.MauiPages;

public partial class MonkeyRatingPage : ContentPage
{
	public MonkeyRatingPage()
	{
		InitializeComponent();
	}

    public void Button_Clicked(object sender, EventArgs e)
    {
        Debug.WriteLine("Monkey Rating: " + rating.Value);
        Navigation.PopModalAsync();
    }
}
