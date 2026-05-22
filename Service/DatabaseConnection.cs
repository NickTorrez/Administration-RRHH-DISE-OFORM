using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration_RRHH.Service
{
    /// <summary>
    /// Superclase base para el acceso a SQL Server 2022.
    /// Gsetiona el ciclo de vida de la conexión (abrir, cerrar, lieberar).
    /// Las subclases heredan la cponexion y la utilizan para sus operaciones.
    /// </summary>
    public abstract class DatabaseConnection: IDisposable
    {
        // --- Campos protegido -------------------------------
        // protevidos para que las subclases puedan acceder a ellos directamente.

        protected SqlConnection _connection;
        protected SqlCommand _command;
        protected bool _disposed = false; // Para detectar llamadas redundantes a Dispose

    }
}
