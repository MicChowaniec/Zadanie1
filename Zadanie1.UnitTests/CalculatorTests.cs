using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Zadanie1.UnitTests
{
    class CalculatorTests
    {
        [Test]
        public void ZeroArgumentConstructorTest()
        {
            //arrange
            var ulamek = new Ulamek();


            //act
            var test = Ulamek.ReferenceEquals(null, ulamek);


            //assert
            Assert.IsTrue(test);
        }

        [Test]
        public void OneArgumentConstructorTest()
        {
            //arrange
            var ulamek1 = new Ulamek();
            var ulamek2 = new Ulamek(ulamek1);


            //act
            var test = ulamek1 == ulamek2;


            //assert
            Assert.IsTrue(test);
        }
    }
}
