using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    //Concrete command
    public class Retirar : IOperacion
    {
        private Cuenta cuenta;
        private double monto;

        public Retirar(Cuenta cuenta, double monto)
        {
            this.cuenta = cuenta;
            this.monto = monto;
        }

        public void execute()
        {
            this.cuenta.retirar(this.monto);
        }
    }
}
