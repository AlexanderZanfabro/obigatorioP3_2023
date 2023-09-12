using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ExcepcionesEntidades.ImagenEspecieMarinaException
{
    public class ImagenEspecieMarinaException:Exception
    {
        public ImagenEspecieMarinaException() : base() { }
        public ImagenEspecieMarinaException(string mensaje) : base(mensaje) { }
        public ImagenEspecieMarinaException(string mensaje, Exception innerException)
            : base(mensaje, innerException) { }
    }
}
