using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class EcosistemaMarino
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "largo del nombre entre 2 y 50 caracteres")]
        public string? Nombre { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 50, ErrorMessage = "largo del texto debe ser entre 50 y 500 caracteres")]
        public string? DetalleUbicacionGeo { get; set; }
        [Required]
        public int AreaEcosistema { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 50, ErrorMessage = "largo de la descripción entre 50 y 500 caracteres")]
        public string? DescripcionSusCaracteristicasUnicas { get; set; }
        [Required]
        public List<EspecieMarina>? EspeciesQueAbitan { get; set; }
        [Required]
        public List<Amenaza>? AmenazasAesteEcosistenma { get; set; }
        [Required]
        public ImagenEcosistema? ImagenDeEseEcosistema { get; set; }
        [Required]
        public Ubicacion? UbicacionDeEseEcosistema { get; set; }

    }
}
