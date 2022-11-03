using LoginUI.Controls;
using LoginUI.Models;
using LoginUI.View.Dashboard;
using LoginUI.View.Startup;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LoginUI.ViewModels.Startup
{
    public class LoadingPageViewModel
    {
        public LoadingPageViewModel()
        {
            CheckUserLoginDetails();
        }

        private async void CheckUserLoginDetails()
        {
            string userDetailsStr = Preferences.Get(nameof(App.UserDetails), "");


            if (string.IsNullOrWhiteSpace(userDetailsStr))
            {
                // Navigate to LoginPage
                await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
            }
            else
            {
                var userInfo = JsonConvert.DeserializeObject<UserBasicInfo>(userDetailsStr);
                App.UserDetails = userInfo;
                await AppConstant.AddFlyoutMenusDetails();                
            }
        }
    }
}
