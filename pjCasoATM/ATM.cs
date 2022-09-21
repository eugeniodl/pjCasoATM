using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjCasoATM
{
    internal class ATM
    {
        private bool usuarioAutenticado;
        private int numeroCuentaActual;
        private Pantalla pantalla;
        private Teclado teclado;
        private DispensadorEfectivo dispensadorEfectivo;
        private BaseDatosBanco baseDatosBanco;

        private enum OpcionMenu
        {
            SOLICITUD_SALDO = 1,
            RETIRO = 2,
            SALIR_ATM = 3
        }

        public ATM()
        {
            usuarioAutenticado = false;
            numeroCuentaActual = 0;
            pantalla = new Pantalla();
            teclado = new Teclado();
            dispensadorEfectivo = new DispensadorEfectivo();
            baseDatosBanco = new BaseDatosBanco();
        }

        public void Ejecutar()
        {
            while(true)
            {
                while(!usuarioAutenticado)
                {
                    pantalla.MostrarLineaMensaje("\n¡Bienvenido!");
                    AutenticarUsuario();
                }

                RealizarTransacciones();
                usuarioAutenticado=false;
                numeroCuentaActual=0;
                pantalla.MostrarLineaMensaje("\n¡Gracias! ¡Adiós!");
            }
        }

        private void RealizarTransacciones()
        {
            throw new NotImplementedException();
        }

        private void AutenticarUsuario()
        {
            pantalla.MostrarMensaje("\nIntroduzca su número de cuenta: ");
            int numeroCuenta = teclado.ObtenerEntrada();

            pantalla.MostrarMensaje("\nIntroduzca su PIN: ");
            int pin = teclado.ObtenerEntrada();

            usuarioAutenticado = baseDatosBanco.AutenticarUsuario(numeroCuenta, pin);

            if (usuarioAutenticado)
                numeroCuentaActual = numeroCuenta;
            else
                pantalla.MostrarLineaMensaje(
                    "Número de cuenta o PIN inválido. Intente de nuevo.");
        }
    }
}
