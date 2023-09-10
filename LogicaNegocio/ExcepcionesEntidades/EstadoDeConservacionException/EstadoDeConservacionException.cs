using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ExcepcionesEntidades.EstadoDeConservacionException
{
    public class EstadoDeConservacionException:Exception
    {
        public EstadoDeConservacionException() : base() { }
        public EstadoDeConservacionException(string mensaje) : base(mensaje) { }
        public EstadoDeConservacionException(string mensaje, Exception innerException)
            : base(mensaje, innerException) { }
    }
}
