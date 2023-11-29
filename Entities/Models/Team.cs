using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Team
    {
        [Column("TeamID")]
        public Guid Id { get; set; }
        public short Season { get; set; }
        public string? TeamCode { get; set; }
        public string? KorName { get; set;}
        public string? EngName { get; set; }

        public ICollection<Player>? Players { get; set; }

    }
}
