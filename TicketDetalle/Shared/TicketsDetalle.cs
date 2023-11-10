using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketDetalle.Shared
{
    internal class TicketsDetalle
    {
        [Key] 
        public int Id { get; set; }
        public int TicketId { get; set; }
        public string? Emisor {  get; set; }
        public string? Mensaje { get; set; }
    }
}
