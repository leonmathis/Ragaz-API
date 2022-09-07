using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RagazAPI.Models
{
    public class Event
    {
        [Key]
        public int EventID { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        public string EventName { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? EventDate { get; set; }
    }
}
