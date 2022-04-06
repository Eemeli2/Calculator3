using BulletLibrary;
using Reloading.ApiClient;

var bulletClient = new BulletApiClient("https://localhost:7296");


// awaitable task that gets an IEnumerable of bullets.
var bullets = await bulletClient.GetAll();


// foreach statement executing a statement for each bullet in (IEnumerable) bullets 
foreach (var bullet in bullets)
{
    // Writes the string values of bullets with manufacturers, bullets with a name, bullets with any diameters.
    Console.WriteLine($"{bullet.Manufacturer.Name} {bullet.Name} {bullet.Diameter}");

    // IEnumerable of diameters, gets a list of bullets that all have the SAME diameter.
    var diameters = await bulletClient.GetAllByDiameter(bullet.Diameter);

    // foreach statement executing a statement for each diameter in (IEnumerable) diameters (to search for all matching diameters)
    foreach (var diameter in diameters)
    {
        Console.WriteLine(diameter);
    }
}


var guid = await bulletClient.Insert(new Bullet
{
    Diameter = new Diameter
    {
        UnitType = Diameter.Unit.Inch,
        Value = .3
    },
    Manufacturer = new Manufacturer
    {
        Name = "Speer"
    },
    Mass = new Mass
    {
        UnitType = Mass.Unit.Grain,
        Value = 150
    }
});

Console.WriteLine($"New bullet created with id: {guid}");
