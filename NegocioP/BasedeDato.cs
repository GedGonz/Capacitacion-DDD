using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioP
{
    public class BasedeDato
    {
        private readonly IBaseDatos bd;
        public BasedeDato(IBaseDatos bd)
        {
            this.bd = bd;
        }

        public void AddData(string dato)
        {

            var Data=bd.AddData()+" "+dato;
            var Conexion = bd.Coneccion();
            Console.WriteLine(Conexion);
            Console.WriteLine(Data);
        }
    }
}
