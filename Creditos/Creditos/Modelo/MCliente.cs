using Creditos.Controlador;
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
    
    class MCliente
    {
        IDbConnection cn = Conexion.conectar();

       public void insertar(string Nombre,string Apellido,int dui,string direccion,int codigo)
        {
            string consulta = "sp_InsertCliente ";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Nombre", Nombre );
            parametros.Add("@Apellido", Apellido );
            parametros.Add("@DUI", dui);
            parametros.Add("@Direccion", direccion);
            parametros.Add("@Codigo", codigo);
            cn.Open();
            cn.Execute(consulta,parametros,commandType:CommandType.StoredProcedure);
            cn.Close();
        }

        public int Comprobacion(int Cuenta, int Codigo)
        {
            List<Cliente> lista;
            string consulta = "select * from Cliente where Numero_De_Cuenta = @Cuenta AND Codigo_De_Seguridad = @Codigo";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Cuenta", Cuenta);
            parametros.Add("@Codigo", Codigo);
            cn.Open();
            lista = cn.Query<Cliente>(consulta, parametros, commandType: CommandType.Text).ToList();
            cn.Close();
            return lista.Count;

        }

        public List<Cliente> datos(int Cuenta)
        {
            List<Cliente> lista;

            string consulta = "select * from Cliente where Numero_De_Cuenta = @Cuenta";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Cuenta", Cuenta);
            cn.Open();
            lista = cn.Query<Cliente>(consulta,parametros, commandType: CommandType.Text).ToList();
            cn.Close();
            return lista;
        } 

        public int Log(string Usuario, string Apellido, int Codigo)
        {
            List<Cliente> lista;
            string consulta = "select * from Cliente where Nombre = @Nombre and Apellido = @Apellido and Codigo_De_Seguridad = @Codigo";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Nombre",Usuario);
            parametros.Add("@Apellido",Apellido);
            parametros.Add("@Codigo", Codigo);

            cn.Open();
            lista = cn.Query<Cliente>(consulta,parametros,commandType:CommandType.Text).ToList();
            cn.Close();

            foreach (var id in lista) {
                NumeroDeCuenta.Cuenta = id.Numero_De_Cuenta;
                    }
            return lista.Count;
        }
    }
}

