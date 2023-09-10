using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ExcepcionesEntidades.UbicacionException
{
    public class UbicacionException:Exception
    {
        public UbicacionException() : base() { }
        public UbicacionException(string mensaje) : base(mensaje) { }
        public UbicacionException(string mensaje, Exception innerException)
            : base(mensaje, innerException) { }
    }
}
