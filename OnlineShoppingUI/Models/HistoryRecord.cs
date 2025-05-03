using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingUI.Models
{
    internal class HistoryRecord
    {
        [Key] // Primary Key olduğunu belirt
        public int Id { get; set; }

        [Required] // Zorunlu alan
        public string Action { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
