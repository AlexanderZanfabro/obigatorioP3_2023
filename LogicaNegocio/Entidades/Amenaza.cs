using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Amenaza
    {
        public int? Id { get; set; }
        [Required]
        [StringLength(500, MinimumLength =50, ErrorMessage ="")]
        public string? DescripcionDeAmenaza { get; set; }
        [Required]
        public int GradoDePeligro { get; set; }
       
        public override string ToString()
        {    
            string descripcionDeAmenaza = this.DescripcionDeAmenaza ?? string.Empty;
            int gradoDePeligro = this.GradoDePeligro ;
            return $"Id: {this.Id} DescripcionDeAmenaza: {this.DescripcionDeAmenaza} GradoDePeligro: {this.GradoDePeligro}";
        }

    }
}
