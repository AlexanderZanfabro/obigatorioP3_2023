using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class ImagenEcosistema
    {
        [Key, ForeignKey(nameof(EcosistemaMarinoDeLaImagen))]
        public int EcosistemaMarinoId { get; set; }
        public string? Imagen { get; set; }
        public string? NombreEcosistema { get; set; }

        public EcosistemaMarino? EcosistemaMarinoDeLaImagen { get; set; }
    }
}
