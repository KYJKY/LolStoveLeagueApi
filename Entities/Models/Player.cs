using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Player
    {
        [Column("PlayerID")]
        public Guid Id { get; set; }
        public short Season { get; set; }
        public string? KorName { get; set; }
        public string? EngName { get; set; }
        public string? Position { get; set; }
        public DateOnly BirthDay { get; set; }
        public Team? Team { get; set; }
    }
}
