using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Battlebus.Models
{
    public class SavedPolitician
    {
        [Key]
        public int SavedPoliticianId { get; set; }

        public string Name { get; set; }

        public string Photo { get; set; }

        public string District { get; set; }

        public int UserId { get; set; }
    }
}
