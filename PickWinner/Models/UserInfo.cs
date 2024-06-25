
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PickWinner.Models
{
    [Table("User_Info")]
    public class UserInfo
    {
        public int Id { get; set; } 
        
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Email { get; set; }

        public int Mobile { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string Postcode { get; set; }

    }
}
