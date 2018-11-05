using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("user")]
    public class User
    {
        [Key]
        [Column("UserId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [StringLength(60, ErrorMessage = "Email can't be longer than 60 characters")]
        public string Email { get; set; }

        [StringLength(60, ErrorMessage = "Username can't be longer than 60 characters")]
        public string Username { get; set; }

        [StringLength(2, ErrorMessage = "Country can't be longer than 2 characters")]
        public string Country { get; set; }

    }
}
