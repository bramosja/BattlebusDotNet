using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Battlebus.Models
{
    public class Note
    {
        [Key]
        public int NoteId { get; set; }

        public string Content { get; set; }

        public SavedPolitician SavedPolitician { get; set; }
    }
}
