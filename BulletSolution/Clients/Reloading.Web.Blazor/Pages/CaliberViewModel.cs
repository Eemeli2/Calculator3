using BulletLibrary;
using BulletLibrary.Interfaces;
using Microsoft.AspNetCore.Components;

namespace Reloading.Web.Blazor.Data
{
    public class CaliberViewModel : ComponentBase
    {
        [Inject] ICaliberService? CaliberService { get; set; }
        [Inject] IMeasurementService? MeasurementService { get; set; }

        public IEnumerable<Caliber>? Calibers { get; set; }

        public IEnumerable<Diameter>? Diameters { get; set; }

        public string? NewCaliberName { get; set; }

        public Diameter? SelectedDiameter { get; set; }

        public Primer.PrimerType SelectedPrimer { get; set; }

        //public Diameter.Unit SelectedUnit { get; set; }

        bool CanSubmit => !string.IsNullOrWhiteSpace(NewCaliberName) && SelectedDiameter is not null;

        protected async void Insert()
        {
            if (!CanSubmit) return;

            //foreach (var primerType in Enum.GetValues<Primer.PrimerType>())
            //{

            //}

            await CaliberService!.Insert(new Caliber
            {
                Name = NewCaliberName,
                Diameter = SelectedDiameter,
                PrimerType = SelectedPrimer
            });
        }

        protected override async Task OnInitializedAsync()
        {
            Calibers = await CaliberService!.GetAll();
            Diameters = await MeasurementService!.GetAllDiameters();
            await base.OnInitializedAsync();
        }
    }
}

