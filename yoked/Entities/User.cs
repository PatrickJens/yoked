using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace yoked.Entities
{
    public class User
    {
        [Key]
        [Required]
        private String UserID { get; set; }

        [Required]
        private String UserName { get; set; }
        [Required]
        private String Email    { get; set; }
        [Required]
        private String Password { get; set; }

        [Required]
        private int IsAdmin {  get; set; }
    }
}

/*
Column names must match sql server

To rename table, column in .NET use [Table('tb_user')] and [Column('col_name')]
*/ 