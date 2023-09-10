using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ExcepcionesEntidades.EspecieMarinaException
{
    internal class EspecieMarinaException:Exception
    {
        public EspecieMarinaException() : base(){ }
        public EspecieMarinaException(string mensaje) : base(mensaje) { }
        public EspecieMarinaException(string mensaje, Exception innerException)
            : base(mensaje, innerException) { }

    }
}
