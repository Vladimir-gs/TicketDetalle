using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketDetalle.Shared
{
    public class Tickets
    {
        [Key]
        public int TicketId { get; set; }
        public DateTime Fecha {  get; set; }
        [Required(ErrorMessage ="Favor completar este campo")]
        public string? SolicitadoPor {  get; set; }
        [Required(ErrorMessage = "Favor completar este campo")]
        public string? Asunto { get; set; }
        [Required(ErrorMessage = "Favor completar este campo")]
        public string? Descripcion { get; set; }

        [ForeignKey("TicketId")]
        public ICollection<TicketsDetalle> TicketsDetalle { get; set; } = new List<TicketsDetalle>();
    }
}
