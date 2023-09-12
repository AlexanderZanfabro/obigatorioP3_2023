using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class DataModificationBank
    {
        public int Id { get; set; }
        [Required]
        public int IdEntidadModificada { get; set; }
        [Required]
        public string? NomUsuarioQintervino { get; set; }
        [Required]
        public DateTime FechaYhoraDeIntervencion { get; set; }
        [Required]
        public string? TipoDeEntidad { get; set; }
    }
}
