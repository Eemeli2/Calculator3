using System;
using BulletLibrary;
using Xunit;

namespace Reloading.Data.UnitTest
{
    public class AmmoTests
    {
        [Fact]
        public void Should_not_be_able_to_assign_wrong_diameter_bullet()
        {
            var ammo = new Ammunition();

            var ammoDiameter = new Diameter {UnitType = Diameter.Unit.Mm, Value = 7};
            var caseDiameter = new Diameter { UnitType = Diameter.Unit.Mm, Value = 7.62 };

            ammo.Bullet = new Bullet
            {
                Diameter = ammoDiameter
            };

            InvalidOperationException invalidOperationException = null;
            try
            {
                ammo.Case = new Case {Caliber = new Caliber {Diameter = caseDiameter}};
            }
            catch (InvalidOperationException e)
            {
                invalidOperationException = e;
            }

            Assert.NotNull(invalidOperationException);
        }
    }
}
