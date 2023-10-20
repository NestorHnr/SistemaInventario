using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos.Modelos
{
    public class UsuarioAplicacion : IdentityUser
    {
        [Required(ErrorMessage ="Nombres son requeridos")]
        [MaxLength(80)]
        public string Nombres { get; set; }

        [Required(ErrorMessage ="Apellidos son requeridos")]
        [MaxLength(80)]
        public string Apellidos { get; set; }

        [MaxLength(200)]
        [Required(ErrorMessage ="Direccion es requerida")]
        public string Direccion { get; set; }

        [Required(ErrorMessage ="Ciudad es requerida")]
        [MaxLength(60)]
        public string Ciudad { get; set; }

        [Required(ErrorMessage ="Pais es requerida")]
        [MaxLength(60)]
        public string Pais { get; set; }

        [NotMapped]//No se agrega a la tabla
        public string Role { get; set; }
    }
}
