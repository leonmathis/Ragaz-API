using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RagazAPI.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Column(TypeName = "nvarchar(10);")]
        public string Salutation { get; set; }

        [Column(TypeName = "nvarchar(25);")]
        public string FirstName { get; set; }

        [Column(TypeName = "nvarchar(25);")]
        public string LastName { get; set; }

        [Column(TypeName = "nvarchar(25);")]
        public string Company { get; set; }

        [Column(TypeName = "nvarchar(25);")]
        public string Street { get; set; }

        [Column(TypeName = "nvarchar(10);")]
        public string PLZ { get; set; }

        [Column(TypeName = "nvarchar(25);")]
        public string City { get; set; }

        [Column(TypeName = "nvarchar(25);")]
        public string Country { get; set; }
    }
}
