

namespace MyFirstMauiApplication;

public partial class Profile : ContentPage
{
   
    
    public Profile()
	{
		InitializeComponent();
        Routing.RegisterRoute("//D_FAULT_TabBar11/D_FAULT_Tab8/HomePage", typeof(HomePage));
    }




    private async void ImageButton_Clicked(object sender, EventArgs e)
    {

        await Shell.Current.GoToAsync("//D_FAULT_TabBar11/D_FAULT_Tab8/HomePage",true);

    }
}