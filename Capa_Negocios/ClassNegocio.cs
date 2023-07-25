using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocios
{
    public class ClassNegocio
    {
        ClassDatos objd =new ClassDatos();

        public DataTable N_Listar_Personal()
        {
            return objd.D_Lista_Personal ();
        }

        public DataTable N_Buscar_Clientes(ClassEntidad obje)
        {
            return objd.D_Buscar_Personal(obje);
        }

        public string N_Mantenimiento_Cliente(ClassEntidad obje)
        {
            return objd.D_Mantenimiento_Personal(obje);
        }

    }
}
