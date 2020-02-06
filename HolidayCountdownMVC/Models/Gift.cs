using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HolidayCountdownMVC.Models
{
    public class Gift
    {
        [Key]
        public int GiftId { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required]
        public string Item { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required]
        public string Recipient { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required]
        public decimal Price { get; set; }
    }
}
