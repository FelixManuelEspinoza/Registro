using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Capa_Entidad;

namespace Capa_Datos
{
    public class ClassDatos
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public DataTable D_Lista_Personal() 
        {
            SqlCommand cmd = new SqlCommand("sp_listar_Personal", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        
        }

        public DataTable D_Buscar_Personal(ClassEntidad obje) 
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_Personal", cn);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue ("@Nombre", obje.Nombre);
            SqlDataAdapter da =new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill (dt);
            return dt;
        }

        public string D_Mantenimiento_Personal(ClassEntidad obje) 
        {
            string accion = "";
            SqlCommand cmd = new SqlCommand("sp_mantenimiento_clientes", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Codigo",obje.Codigo);
            cmd.Parameters.AddWithValue("@Nombre", obje.Nombre);
            cmd.Parameters.AddWithValue("@Edad", obje.Edad);
            cmd.Parameters.AddWithValue("@Telefono", obje.Telefono);
            cmd.Parameters.Add("@Accion", SqlDbType.VarChar, 50).Value = obje.Accion;
            cmd.Parameters["@Accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@Accion"].Value.ToString();
            cn.Close();
            return accion;
        }
    }
}
