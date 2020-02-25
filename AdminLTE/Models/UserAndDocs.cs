using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.Models
{
    public class UserAndDocs
    {
        [Key, Column(Order = 1)]
        public string Id_Usuario { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        [Key, Column(Order = 2)]
        public int Id_Documento { get; set; }
        public Docs Docs { get; set; }
        
    }
}
