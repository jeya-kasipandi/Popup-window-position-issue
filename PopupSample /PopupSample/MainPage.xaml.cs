namespace PopupSample;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
		popup.AnchorView = entry;
	}

   

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
		popup.ShowPopup();
    }
}


