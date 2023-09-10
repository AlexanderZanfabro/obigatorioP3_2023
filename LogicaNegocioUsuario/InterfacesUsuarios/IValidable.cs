using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocioUsuario.InterfacesUsuarios
{
    public interface IValidable<T> where T : class
    {
        void ValidarUsuario();
    }
}
