using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocioUsuario.ExcepcionesUsuarios
{
    public class UsuarioException:Exception
    {
        public UsuarioException() : base() { }
        public UsuarioException(string mensaje) : base(mensaje) { }
        public UsuarioException(string mensaje, Exception innerException)
            : base(mensaje, innerException) { }
    }
}
