

namespace MyFirstMauiApplication;

public partial class Profile : ContentPage
{
   
    
    public Profile()
	{
		InitializeComponent();
	}

    
    

    private async void ImageButton_Clicked(object sender, EventArgs e)
    { 
        
        Routing.RegisterRoute(nameof(AppShell), typeof(AppShell));
        //Routing.RegisterRoute("AppShell", typeof(AppShell));
        
        await Shell.Current.GoToAsync(nameof(AppShell));
    }
}