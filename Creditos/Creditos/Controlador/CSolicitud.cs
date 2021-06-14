using Creditos.Entidades;
using Creditos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creditos.Controlador
{
    class CSolicitud
    {
        MSolicitud mSolicitud = new MSolicitud();
        public void CrearSolicitud(int Cantidad, int Plasos, int Cuenta, string Garantia)
        {
            mSolicitud.Insertar(Cantidad,Plasos, Cuenta, Garantia);
        }

        public List<Solicitud> solisitudes()
        {
            return mSolicitud.solisitudes();
        }

        public List<Solicitud> datosdesolicitud(int id)
        {
            return mSolicitud.Datosdesolicitud(id);

        }

        public void cambiarestado(int id,int estado)
        {
            mSolicitud.cambiarestado(id,estado);
        }
    }
}
