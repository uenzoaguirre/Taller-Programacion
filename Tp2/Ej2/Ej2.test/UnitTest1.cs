using System;
using Xunit;

namespace Ej2.test
{
    public class UnitTest1
    {
        [Fact]
        public void HappyPathAcreditarSaldo()
        {
            Cuenta cuenta = new Cuenta (new Moneda ("Peso","Enzo","$"));
            cuenta.AcreditarSaldo(1234);
            Assert.Equal(1234,cuenta.Saldo);
        }

        [Fact]
        public void HappyPathDebitarSaldo()
        {
            Cuenta cuenta = new Cuenta (new Moneda ("Peso","Enzo","$"));
            cuenta.AcreditarSaldo(1234);
            cuenta.DebitarSaldo(234);
            Assert.Equal(1000,cuenta.Saldo);
        }
        
    }
}
