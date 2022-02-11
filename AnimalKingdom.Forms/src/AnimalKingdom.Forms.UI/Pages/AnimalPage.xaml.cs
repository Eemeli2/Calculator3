using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalKingdom.Forms.Core.ViewModels;
using MvvmCross.Forms.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnimalKingdom.Forms.UI.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnimalPage : MvxContentPage<AnimalViewModel>
    {
        public AnimalPage()
        {
            InitializeComponent();
        }
    }
}
