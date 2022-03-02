//using BulletLibrary;
//using BulletLibrary.Interfaces;
//using Microsoft.AspNetCore.Components;

//namespace Reloading.Web.Blazor.Data
//{
//    public class CaliberViewModel : ComponentBase 
//    {
//        private readonly ICaliberService _caliberService;
//        private readonly IMeasurementService _measurementService;

//        public CaliberViewModel(ICaliberService caliberService, IMeasurementService measurementService)
//        {
//            _caliberService = caliberService;
//            _measurementService = measurementService;
//        }

//        public IEnumerable<Caliber>? Calibers { get; set; }

//        public IEnumerable<Diameter>? Diameters { get; set; }

//        public string? NewCaliberName { get; set; }

//        public Diameter? SelectedDiameter { get; set; }

//        protected async void Insert()
//        {
//            if (string.IsNullOrWhiteSpace(NewCaliberName)) return;
//            if (SelectedDiameter == null) return;

//            await _caliberService.Insert(new Caliber
//            {
//                Name = NewCaliberName,
//                Diameter = SelectedDiameter
//            });
//        }

//        protected override async Task OnInitializedAsync()
//        {
//            Calibers = await _caliberService.GetAll();
//            Diameters = await _measurementService.GetAllDiameters();
//            await base.OnInitializedAsync();
//        }
//    }
//}
