using LogicaNegocioUsuario.ExcepcionesUsuarios;
using LogicaNegocioUsuario.InterfacesUsuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocioUsuario.Usuarios
{
    public class Usuario:IValidable<Usuario>
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength =2, ErrorMessage ="El largo varia entre 2 y 50")]
        public string? Alias { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 10, ErrorMessage = "El largo varia entre 8 y 20")]
        [Display(Name ="Contraseña")]
        public string? Contrasenia { get; set; }

        public override string ToString()
        {
            string alias = this.Alias ?? "Sin alias";
            string contrasenia = this.Contrasenia ?? "Sin Contraseñia";


            return $"Id: {this.Id} Alias: {alias} Contrasenia: {contrasenia}";
        }

        public void ValidarUsuario()
        {
            if (string.IsNullOrEmpty(this.Alias) || this.Alias.Length < 2)
                throw new UsuarioException("El alias debe tener al menos 2 caracteres");
            if (string.IsNullOrEmpty(this.Contrasenia) || this.Contrasenia.Length < 10 || this.Contrasenia.Length > 20)
                throw new UsuarioException("Tiene que ingresar una contraseña de entre 10 a 20 caracteres");
        }
    }
}
