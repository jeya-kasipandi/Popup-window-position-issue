namespace PopupSample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		popup.AnchorView = entry;
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		//popup
		//popup.ShowPopup();
    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
		popup.ShowPopup();
    }
}


