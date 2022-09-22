using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjCasoATM
{
    internal class SolicitudSaldo : Transaccion
    {

        public SolicitudSaldo(
            int cuentaUsuario, Pantalla pantalla, BaseDatosBanco baseDatos) 
            : base(cuentaUsuario, pantalla, baseDatos)
        {

        }

        internal override void Ejecutar()
        {
            throw new NotImplementedException();
        }
    }
}
