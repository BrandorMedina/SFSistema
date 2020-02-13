using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AdminLTE.Models
{
    public class Docs
    {
        [Required]
        public int Id { get; set; }
        public int Id_Usuario { get; set; }
        public string Tipo_documento { get; set; }
        public string Asunto { get; set; }
        public string Via { get; set; }

        public string Anexo { get; set; }
        public string Descripcion { get; set; }
        [DataType(DataType.Date)]
        public DateTimeOffset Fecha_Creado { get; set; }

        [DataType(DataType.Date)]
        public DateTimeOffset Fecha_Limite { get; set; }

        
    }
}
