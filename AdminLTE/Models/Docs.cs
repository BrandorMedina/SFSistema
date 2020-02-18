using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AdminLTE.Models
{
    public class Docs
    {
        [Required]
        public int Id { get; set; }

        [ForeignKey ("ID_Usuario")]
        public string Id_Usuario { get; set; }
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
