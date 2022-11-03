using LoginUI.ViewModels.Startup;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginUI.ViewModels.Dashboard
{
    public partial class DashboardPageViewModel : BaseViewModel
    {
        public DashboardPageViewModel()
        {
            Title = "Welcome";
        }

    }
}
