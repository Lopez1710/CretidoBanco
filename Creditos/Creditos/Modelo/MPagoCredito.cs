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
    class MPagoCredito
    {

        IDbConnection cn = Conexion.conectar();

        public void realizarpago(int Pago)
        {
            string consulta = "sp_RealizarPago";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Cuenta",  Pago);
            cn.Open();
            cn.Execute(consulta,parametros,commandType:CommandType.StoredProcedure);
            cn.Close();

        }

        public List<PagoCredito> datos(int Cuenta)
        {
            List<PagoCredito> lista;
            string consulta = "select * from PagoCredito where Numero_De_Cuenta_Fk = @Cuenta";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Cuenta", Cuenta);
            cn.Open();
            lista = cn.Query<PagoCredito>(consulta,parametros,commandType:CommandType.Text).ToList();
            cn.Close();
            return lista;
        }

        public int Comprobacion(int Cuenta)
        {
            List<PagoCredito> lista;
            string consulta = "select * from PagoCredito where Numero_De_Cuenta_Fk = @Cuenta";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Cuenta", Cuenta);
            cn.Open();
            lista = cn.Query<PagoCredito>(consulta, parametros, commandType: CommandType.Text).ToList();
            cn.Close();
            return lista.Count;
        }
    }
}
