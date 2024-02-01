

namespace MyFirstMauiApplication;

public partial class Profile : ContentPage
{
   
    
    public Profile()  
	{
		InitializeComponent();
       
        Routing.RegisterRoute("HomePage", typeof(HomePage));
    }





    private async void ImageButton_Clicked(object sender, EventArgs e)
    {

      
       await Shell.Current.GoToAsync("//HomePage",true);
    }
}