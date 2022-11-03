using LoginUI.ViewModels.Dashboard;

namespace LoginUI.View.Dashboard;

public partial class DashboardPage : ContentPage
{
	public DashboardPage(DashboardPageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}