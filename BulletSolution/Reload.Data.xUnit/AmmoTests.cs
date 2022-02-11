using System;
using BulletLibrary;
using Xunit;

namespace Reloading.Data.xUnit
{
    public class AmmoTests
    {
        [Fact]
        public void Should_not_be_able_to_assign_wrong_diameter_case()
        {
            var ammo = new Ammunition();

            var bulletDiameter = new Diameter { UnitType = Diameter.Unit.Mm, Value = 7 };
            var caseDiameter = new Diameter { UnitType = Diameter.Unit.Mm, Value = 7.62 };

            ammo.Bullet = new Bullet
            {
                Diameter = bulletDiameter
            };

            InvalidOperationException? invalidOperationException = null;
            try
            {
                ammo.Case = new Case { Caliber = new Caliber { Diameter = caseDiameter } };
            }
            catch (InvalidOperationException e)
            {
                invalidOperationException = e;
            }

            Assert.NotNull(invalidOperationException);
        }
        [Fact]
        public void Should_not_be_able_to_assign_wrong_diameter_bullet()
        {
            var ammo = new Ammunition();

            var bulletDiameter = new Diameter { UnitType = Diameter.Unit.Mm, Value = 7 };
            var caseDiameter = new Diameter { UnitType = Diameter.Unit.Mm, Value = 7.62 };


            ammo.Case = new Case { Caliber = new Caliber { Diameter = caseDiameter } };

            InvalidOperationException? invalidOperationException = null;
            try
            {
                ammo.Bullet = new Bullet
                {
                    Diameter = bulletDiameter
                };
            }
            catch (InvalidOperationException e)
            {
                invalidOperationException = e;
            }

            Assert.NotNull(invalidOperationException);
        }
        [Fact]
        public void Should_be_able_to_assign_case_on_empty_load()
        {
            var ammo = new Ammunition();

            var caseDiameter = new Diameter { UnitType = Diameter.Unit.Mm, Value = 7.62 };
            var bulletDiameter = new Diameter { UnitType = Diameter.Unit.Mm, Value = 7 };

            InvalidOperationException? invalidOperationException = null;
            try
            {
                ammo.Case = new Case { Caliber = new Caliber { Diameter = caseDiameter } };
            }
            catch (InvalidOperationException e)
            {
                invalidOperationException = e;
            }

            Assert.Null(invalidOperationException);
        }

        [Fact]
        public void Should_be_able_to_assign_correct_diameter_case_and_bullet()
        {
            var ammo = new Ammunition();

            var bulletDiameter = new Diameter { UnitType = Diameter.Unit.Mm, Value = 7.62 };
            var caseDiameter = new Diameter { UnitType = Diameter.Unit.Inch, Value = .3 };

            ammo.Bullet = new Bullet
            {
                Diameter = bulletDiameter
            };

            InvalidOperationException? invalidOperationException = null;
            try
            {
                ammo.Case = new Case { Caliber = new Caliber { Diameter = caseDiameter } };
            }
            catch (InvalidOperationException e)
            {
                invalidOperationException = e;
            }

            Assert.Null(invalidOperationException);
        }

        [Fact]
        public void Should_be_able_to_assign_correct_primer()
        {
            var ammo = new Ammunition();

            var smallPrimer = new Primer { TypeOf = Primer.PrimerType.Small };

            ammo.Primer = smallPrimer;

            ammo.Case = new Case { Caliber = new Caliber { PrimerType = Primer.PrimerType.Small } };


        }

        [Fact]
        public void Should_not_be_able_to_assign_incorrect_primer()
        {
            var small = Primer.PrimerType.Small;
            var magnum = Primer.PrimerType.Magnum;

            var ammo = new Ammunition
            {
                Case = new Case { Caliber = new Caliber { PrimerType = small } }
            };

            InvalidOperationException? invalidOperationException = null;
            try
            {
                ammo.Primer = new Primer { TypeOf = magnum };
            }
            catch (InvalidOperationException e)
            {
                invalidOperationException = e;
            }

            Assert.NotNull(invalidOperationException);
        }

        [Fact]
        public void Should_not_be_able_to_assign_incorrect_case_to_primer()
        {
            var small = Primer.PrimerType.Small;
            var magnum = Primer.PrimerType.Magnum;

            var ammo = new Ammunition
            {
                Primer = new Primer { TypeOf = magnum }
            };

            InvalidOperationException? invalidOperationException = null;
            try
            {
                ammo.Case = new Case { Caliber = new Caliber { PrimerType = small } };
            }
            catch (InvalidOperationException e)
            {
                invalidOperationException = e;
            }

            Assert.NotNull(invalidOperationException);
        }
    }
}



 