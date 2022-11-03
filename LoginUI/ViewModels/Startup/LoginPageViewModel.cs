using LoginUI.Controls;
using LoginUI.Models;
using LoginUI.View.Dashboard;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LoginUI.ViewModels.Startup
{
    public partial class LoginPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private string _password;

        [ICommand]
        async void Login()
        {
            if(!string.IsNullOrWhiteSpace(_email) && !string.IsNullOrWhiteSpace(_password))
            {
                //calling api
                
                var userDetails = new UserBasicInfo();
                userDetails.Email = Email;
                userDetails.FullName = "Test User Name";
                // reader rol, writer rol

                if (Email.ToLower().Contains("writer"))
                {
                    userDetails.RoleID = (int)RoleDetails.Writer;
                    userDetails.RoleText = "Writer Role";
                }
                else if (Email.ToLower().Contains("reader"))
                {
                    userDetails.RoleID = (int)RoleDetails.Reader;
                    userDetails.RoleText = "Reader Role";
                }

                if (Preferences.ContainsKey(nameof(App.UserDetails)))
                {
                    Preferences.Remove(nameof(App.UserDetails));
                }

                string userDetailStr = JsonConvert.SerializeObject(userDetails);
               
                Preferences.Set(nameof(App.UserDetails), userDetailStr);

                App.UserDetails = userDetails;
                await AppConstant.AddFlyoutMenusDetails();
            }
          
        }
    }
}
