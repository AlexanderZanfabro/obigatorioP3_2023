using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class EspecieMarina
    {
       
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "largo del nombre entre 2 y 50 caracteres")]
        public string? NombreCientifico { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "largo del nombre entre 2 y 50 caracteres")]
        public string? NombreVulgar { get; set; }

        [StringLength(500, MinimumLength = 50, ErrorMessage = "largo de la descripción entre 50 y 500 caracteres")]
        public string? DescripcionDeLaEspecie { get; set; }
        public decimal RangoDePeso { get; set; }
        public decimal RangoDeLongitud { get; set; }
        public EstadoDeConservacion EstadoDeConservEspecie { get; set; }
        public List<Amenaza> AmenazasAlaEspecie { get; set; }
        public ImagenEspecie ImagenDeEsaEspecie { get; set; }
    }
}
