using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace yoked.Entities
{
    public class User
    {
        [Key]
        private String UserID { get; set; }

        [Required]
        private String UserName { get; set; }
        [Required]
        private String Email    { get; set; }
        [Required]
        private String Password { get; set; }

        [Required]
        private BigInteger IsAdmin {  get; set; }



    }
}
