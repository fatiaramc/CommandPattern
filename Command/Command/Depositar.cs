using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    //Concrete command
    public class Depositar : IOperacion
    {
        private Cuenta cuenta;
        private double monto;

        public Depositar(Cuenta cuenta, double monto)
        {
            this.cuenta = cuenta;
            this.monto = monto;
        }

        public void execute()
        {
            this.cuenta.depositar(this.monto);
        }
    }
}
