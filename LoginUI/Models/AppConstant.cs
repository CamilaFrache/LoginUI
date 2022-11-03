using LoginUI.Controls;
using LoginUI.View.Dashboard;
using LoginUI.View.Startup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LoginUI.Models
{
    public class AppConstant
    {
        public async static Task AddFlyoutMenusDetails()
        {
            AppShell.Current.FlyoutHeader = new FlyoutHeaderControl();

            var WriterDashboardInfo = AppShell.Current.Items.Where(f => f.Route == nameof(WriterDashboardPage)).FirstOrDefault();
            if (WriterDashboardInfo != null) AppShell.Current.Items.Remove(WriterDashboardInfo);

            var ReaderDashboardInfo = AppShell.Current.Items.Where(f => f.Route == nameof(ReaderDashboardPage)).FirstOrDefault();   
            if (ReaderDashboardInfo != null) AppShell.Current.Items.Remove(ReaderDashboardInfo);



            if (App.UserDetails.RoleID == (int)RoleDetails.Writer)
            {
                var flyoutItem = new FlyoutItem()
                {
                    Title = "Dashboard Page",
                    Route = nameof(WriterDashboardPage),
                    FlyoutDisplayOptions = FlyoutDisplayOptions.AsMultipleItems,
                    Items =
                    {
                        new ShellContent
                        {
                            Title = "Writer Dashboard",
                            ContentTemplate = new DataTemplate(typeof(WriterDashboardPage)),
                        },
                        new ShellContent
                        {
                            Title = "Writer Profile",
                            ContentTemplate = new DataTemplate(typeof(WriterDashboardPage)),
                        },
                    }
                };
                   
                
                if (!AppShell.Current.Items.Contains(flyoutItem))
                {
                    AppShell.Current.Items.Add(flyoutItem);
                    if (DeviceInfo.Platform == DevicePlatform.WinUI)
                    {
                        AppShell.Current.Dispatcher.Dispatch(async () =>
                        {
                            await Shell.Current.GoToAsync($"//{nameof(WriterDashboardPage)}");
                        });
                    }
                    else
                    {
                        await Shell.Current.GoToAsync($"//{nameof(WriterDashboardPage)}");
                    }
                }

            }
            if (App.UserDetails.RoleID == (int)RoleDetails.Reader)
            {
                var flyoutItem = new FlyoutItem()
                {
                    Title = "Dashboard Page",
                    Route = nameof(ReaderDashboardPage),
                    FlyoutDisplayOptions = FlyoutDisplayOptions.AsMultipleItems,
                    Items =
                    {
                        new ShellContent
                        {
                            Title = "Reader Dashboard",
                            ContentTemplate = new DataTemplate(typeof(ReaderDashboardPage)),
                        },
                        new ShellContent
                        {
                            Title = "Reader Profile",
                            ContentTemplate = new DataTemplate(typeof(ReaderDashboardPage)),
                        },
                    }
                };       

                if (!AppShell.Current.Items.Contains(flyoutItem))
                {
                    AppShell.Current.Items.Add(flyoutItem);
                    if (DeviceInfo.Platform == DevicePlatform.WinUI)
                    {
                        AppShell.Current.Dispatcher.Dispatch(async () =>
                        {
                            await Shell.Current.GoToAsync($"//{nameof(ReaderDashboardPage)}");
                        });
                    }
                    else
                    {
                        await Shell.Current.GoToAsync($"//{nameof(ReaderDashboardPage)}");
                    }
                }


            }
        }                     
               

    }
           


}

