using System.ComponentModel.DataAnnotations;

namespace RagazAPI.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        // Foreign key => An user can have one or more orders
        public int UserID { get; set; }

        // Foreign key => An Order can have one event
        public int EventID { get; set; }

        public int AdultsQty { get; set; }

        public int TeenagersQty { get; set; }

        public int KidsQty { get; set; }
    }
}
