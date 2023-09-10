using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ExcepcionesEntidades.AmenazaException
{
    public class AmenazaException:Exception
    {
        public AmenazaException() : base() { }
        public AmenazaException(string mensaje) : base(mensaje) { }
        public AmenazaException(string mensaje, Exception innerException)
            : base(mensaje, innerException) { }
    }
}
