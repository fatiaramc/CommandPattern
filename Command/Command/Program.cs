using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta(1, 200);

            Depositar opDepositar = new Depositar(cuenta, 100);
            Retirar opRetirar = new Retirar(cuenta, 50);

            Invoker ivk = new Invoker();
            ivk.recibirOperacion(opDepositar);
            ivk.recibirOperacion(opRetirar);

            ivk.realizarOperaciones();
        }
    }
}
