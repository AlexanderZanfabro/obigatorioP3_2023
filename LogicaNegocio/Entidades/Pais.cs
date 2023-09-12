using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Entidades
{
    public class Pais
    {
        [Required]
        public int Id {  get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "largo del nombre entre 2 y 50 caracteres")]
        public string? NombrePais { get; set; }
        [Required]
        public string? CodigoPaisIsoAlpha3 { get; set; }
    }
}
