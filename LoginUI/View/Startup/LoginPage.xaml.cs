using LoginUI.ViewModels.Startup;

namespace LoginUI.View.Startup;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginPageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;	
	}
}