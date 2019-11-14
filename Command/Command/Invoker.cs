using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    //Invoker
    class Invoker
    {
        private List<IOperacion> operaciones = new List<IOperacion>();

        public void recibirOperacion(IOperacion operacion)
        {
            this.operaciones.Add(operacion);
        }

        public void realizarOperaciones()
        {
            foreach(var o in operaciones)
            {
                o.execute();
            }
            operaciones.Clear();
            Console.ReadKey();
        }
    }
}
