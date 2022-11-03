using LoginUI.Models;
using LoginUI.View.Dashboard;
using LoginUI.ViewModels;

namespace LoginUI;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		this.BindingContext = new AppShellViewModel();
			
	}
}
