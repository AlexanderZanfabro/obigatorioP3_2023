using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class DataModificationBank
    {
        public int Id { get; set; }

        public int IdEntidadModificada { get; set; }

        public string? NomUsuarioQintervino { get; set; }

        public DateTime FechaYhoraDeIntervencion { get; set; }

        public string? TipoDeEntidad { get; set; }
    }
}
