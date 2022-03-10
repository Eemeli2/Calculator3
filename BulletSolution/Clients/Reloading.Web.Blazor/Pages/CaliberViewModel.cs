using BulletLibrary;
using BulletLibrary.Interfaces;
using Microsoft.AspNetCore.Components;
using Reloading.Web.Blazor.Pages;

namespace Reloading.Web.Blazor.Data
{
    public class CaliberViewModel : ComponentBase
    {
        [Inject] ICaliberService? CaliberService { get; set; }

        public DiameterComponent? DiameterComponent { get; set; }

        public IEnumerable<Caliber>? Calibers { get; set; }

        public string? NewCaliberName { get; set; }

        public Primer.PrimerType SelectedPrimer { get; set; }

        bool CanSubmit => !string.IsNullOrWhiteSpace(NewCaliberName) && DiameterComponent?.SelectedDiameter is not null;

        protected async void Insert()
        {
            if (!CanSubmit) return;


            await CaliberService!.Insert(new Caliber
            {
                Name = NewCaliberName,
                Diameter = DiameterComponent!.SelectedDiameter,
                PrimerType = SelectedPrimer
            });
        }

        protected override async Task OnInitializedAsync()
        {
            Calibers = await CaliberService!.GetAll();
            await base.OnInitializedAsync();
        }
       public void DiameterUpdated(Diameter args)
        {
            StateHasChanged();
        }

    }
}

