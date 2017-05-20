using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoFarmacia.Models
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        //[DataType(DataType.Text)]
        [StringLength(100)]
        [RegularExpression("^([a-zA-Z .&']+)$", ErrorMessage = "Solo letras")]
        [Required(ErrorMessage = "Debe ingresar el Nombre y Apellido.")]
        public string Nombres { get; set; }

        //[DataType(DataType.Text)]
        [StringLength(100)]
        [RegularExpression("^([a-zA-Z0-9 .&'-.&'#]+)$", ErrorMessage = "Caracteres invalidos")]
        [Required(ErrorMessage = "Debe ingresar la Direccion.")]
        public string Direccion { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [DisplayFormat(DataFormatString = "{0:999-999-9999}", ApplyFormatInEditMode = true)]
        public string Telefono { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy - mm - dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaCreacion { get; set; }

        //[DataType(DataType.EmailAddress)]
        [StringLength(100)]
        [RegularExpression("^([a-zA-Z0-9.&'_.&'@]+)$", ErrorMessage = "Caracteres invalidos")]
        [Required(ErrorMessage = "Debe ingresar ingresar el Email.")]
        public string Email { get; set; }
    }
}