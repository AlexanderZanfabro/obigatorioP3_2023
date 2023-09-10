using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ExcepcionesEntidades.EcosistemaMarinoException
{
    public class EcosistemaMarinoException:Exception
    {
        public EcosistemaMarinoException() : base() { }
        public EcosistemaMarinoException(string mensaje) : base(mensaje) { }
        public EcosistemaMarinoException(string mensaje, Exception innerException)
            : base(mensaje, innerException) { }
    }
}
