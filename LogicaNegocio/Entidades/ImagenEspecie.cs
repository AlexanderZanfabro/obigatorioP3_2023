using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class ImagenEspecie
    {
        [Key, ForeignKey(nameof(EspecieMarinaDeLaImagen))]
        public int EcosistemaMarinoId { get; set; }
        public string? Imagen { get; set; }
        public string? NombreEspecie { get; set; }

        public EspecieMarina? EspecieMarinaDeLaImagen { get; set; }
       
    }
}
