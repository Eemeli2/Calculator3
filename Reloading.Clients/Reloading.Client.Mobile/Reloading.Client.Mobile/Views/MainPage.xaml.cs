
using BulletLibrary.Interfaces;
using Reloading.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Reloading.Client.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : FlyoutPage
    {
        public MainPage()
        {
            InitializeComponent();

            flyout.listview.ItemSelected += OnSelectedItem;
        }

        private void OnSelectedItem(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as FlyOutItemPage;
            if(item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetPage));
                flyout.listview.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}