using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    //Command Manager
    public class Cuenta
    {
        private int id;
        private double saldo;

        public Cuenta(int id, double saldo)
        {
            this.id = id;
            this.saldo = saldo;
        }

        public void retirar(double monto)
        {
            this.saldo -= monto;
            Console.Write("[COMANDO RETIRAR] Cuenta: " + id + " Saldo: " + this.saldo + "\n");
        }

        public void depositar(double monto)
        {
            this.saldo += monto;
            Console.Write("[COMANDO DEPOSITAR] Cuenta: " + id + " Saldo: " + this.saldo + "\n");
        }
    }
}
