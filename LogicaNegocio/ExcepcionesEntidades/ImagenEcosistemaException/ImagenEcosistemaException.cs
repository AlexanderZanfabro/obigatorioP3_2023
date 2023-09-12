using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.ExcepcionesEntidades.ImagenEcosistemaException
{
    public class ImagenEcosistemaException:Exception
    {
        public ImagenEcosistemaException() : base() { }
        public ImagenEcosistemaException(string mensaje) : base(mensaje) { }
        public ImagenEcosistemaException(string mensaje, Exception innerException)
            : base(mensaje, innerException) { }
    }
}
