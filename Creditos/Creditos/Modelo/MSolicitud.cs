using Creditos.Entidades;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creditos.Modelo
{
    class MSolicitud
    {
        IDbConnection cn = Conexion.conectar();

        public void Insertar(int Cantidad,int Plasos, int Cuenta, string Garantia)
        {
            string consulta = "sp_CrearSolisitud";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@CantidadPrestamo", Cantidad);
            parametros.Add("@Plasos", Plasos);
            parametros.Add("@Cuenta",Cuenta);
            parametros.Add("@Garantia", Garantia);
            cn.Open();
            cn.Execute(consulta,parametros,commandType:CommandType.StoredProcedure);
            cn.Close();
        }

        public List<Solicitud> solisitudes()
        {
            List<Solicitud> listado;
            string consulta = "select * from Solicitud";
            cn.Open();
            listado = cn.Query<Solicitud>(consulta,commandType:CommandType.Text).ToList();
            cn.Close();
            return listado;

        }

        public List<Solicitud> Datosdesolicitud(int Id)
        {
            List<Solicitud> listado;
            string consulta = "select * from Solicitud where iDSolicitud = @Id";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Id", Id);
            cn.Open();
            listado = cn.Query<Solicitud>(consulta,parametros, commandType: CommandType.Text).ToList();
            cn.Close();
            return listado;

        }

        public void cambiarestado(int id, int estado)
        {
            string consulta = "sp_EstadoSolicitud";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Estado",estado);
            parametros.Add("@IdSolicitud",id);
            cn.Open();
            cn.Execute(consulta,parametros,commandType:CommandType.StoredProcedure);
            cn.Close();
        }
    }
}
