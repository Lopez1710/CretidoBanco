using Creditos.Entidades;
using Creditos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creditos.Controlador
{
    class CCliente
    {
        MCliente mCliente = new MCliente();
        public void Insertar(string Nombre, string Apellido, int dui, string direccion, int codigo)
        {
            mCliente.insertar(Nombre, Apellido, dui, direccion, codigo);
        }

        public int Comprobacion(int Cuenta, int Codigo)
        {
            int Resultado = mCliente.Comprobacion(Cuenta, Codigo);

            return Resultado;
        }

        public List<Cliente> datos(int Cuenta)
        {
            return mCliente.datos(Cuenta);
        }

        public int log(string Nombre, string Apellido, int Codigo)
        {
            int reultado = mCliente.Log(Nombre,Apellido,Codigo);

            return reultado;
        }
    }
}
