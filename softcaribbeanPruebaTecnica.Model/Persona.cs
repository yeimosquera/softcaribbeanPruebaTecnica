using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softcaribbeanPruebaTecnica.Model
{
    public class Persona
    {
        [Required]
        [Integer]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Cddocumento { get; set; }
        [Required]
        [StringLength(60)]
        public string Dsnombres { get; set; }
        [Required]
        [StringLength(60)]
        public string Dsapellidos { get; set; }
        [Required]
        [StringLength(60)]
        public string Fenacimiento { get; set; }
        [Required]
        [StringLength(10)]
        public string Cdgenero { get; set; }
        [Required]
        [StringLength(50)]
        public string Feregistro { get; set; }
        [StringLength(50)]
        public string Febaja { get; set; }
        [Required]
        [StringLength(150)]
        public string Cdusuario { get; set; }
        [Required]
        [StringLength(200)]
        public string Dsdireccion { get; set; }
        [StringLength(500)]
        public string Dsphoto { get; set; }
        [StringLength(20)]
        public string Cdtelefono_Fijo { get; set; }
        [Required]
        [StringLength(20)]
        public string Cdtelefono_Movil { get; set; }
        [Required]
        [Email]
        [StringLength(200)]
        [EmailExiste]
        public string Dsemail { get; set; }
        [StringLength(50)]
        public string Dseps { get; set; }
        [StringLength(50)]
        public string Dsarl { get; set; }
        [StringLength(20)]        
        public string Dscondicion { get; set; }
        [Required]
        [Integer]
        public int Cdtipo { get; set; }
    }

    
    public class EmailExisteAttribute : ValidationAttribute
    {
        
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            return ValidationResult.Success;
        }
    }
}
