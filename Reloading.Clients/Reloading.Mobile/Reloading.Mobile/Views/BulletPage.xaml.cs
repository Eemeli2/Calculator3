using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Net.Http;
using BulletLibrary;
using Reloading.ApiClient;
using Reloading.ApiClient.Extensions;
using System.Threading.Tasks;
using System.Collections.Generic;
using BulletLibrary.Interfaces;

namespace Reloading.Mobile.Views
{


    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BulletPage : ContentPage
    {


        public BulletPage()
        {
            InitializeComponent();
           
        }

       // private async Task Button_Clicked(object sender, EventArgs e)
       // {
           // var bulletClient = new BulletApiClient("https://localhost:7296");
           // var bullets = await bulletClient.GetAll();

            //foreach (var bullet in bullets)
           // {

              //  Console.WriteLine($"{bullet.Manufacturer.Name} {bullet.Name} {bullet.Diameter}");
           // }
        }
    }
