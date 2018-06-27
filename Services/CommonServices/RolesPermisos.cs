using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.CommonServices
{
    public enum RolesPermisos
    {
        #region VENTAS
        Vendedor_Puede_Crear_Nuevo_Registro = 1,
        Vendedor_Puede_Crear_Actualizar_Registro = 3,
        Vendedor_Puede_Eliminar_Registro = 6,
        Vendedor_Puede_Visualizar_Registros= 8,
        Vendedor_Puede_SubirArchivos = 7,
        #endregion
    }
}
