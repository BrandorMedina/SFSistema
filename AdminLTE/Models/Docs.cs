using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.Models
{
    public class Docs
    {
        [Required]
        public string Id { get; set; }
        public string Tipo_documento { get; set; }
        public string Asunto { get; set; }
        public string Via { get; set; }

        public string Anexo { get; set; }
        public string Descripcion { get; set; }
        [DataType(DataType.Date)]
        public DateTime Fecha_Creado { get; set; }

        [DataType(DataType.Date)]
        public DateTime Fecha_Limite { get; set; }

        public string ID_Usuario { get; set; }
    }
}
