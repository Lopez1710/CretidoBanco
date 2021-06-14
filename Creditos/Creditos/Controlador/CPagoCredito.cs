using Creditos.Entidades;
using Creditos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creditos.Controlador
{
    class CPagoCredito
    {
        MPagoCredito mPagoCredito = new MPagoCredito();

        public void Realizarpago(int cuenta)
        {
            mPagoCredito.realizarpago(cuenta);
        }

        public List<PagoCredito> datos( int cuenta )
        {
            List<PagoCredito> lista;
             lista = mPagoCredito.datos(cuenta);
            return lista;
        }

        public int comprobacion(int cuenta)
        {
            int Resultado = mPagoCredito.Comprobacion(cuenta);

            return Resultado;
        }
    }
}
