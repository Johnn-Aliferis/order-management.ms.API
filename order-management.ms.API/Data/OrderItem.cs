using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace order_management.ms.API.Data
{
    [Table("orders")]
    public class OrderItem
    {
        [Key]
        [Column("order_id")]
        public int OrdeId { get; set; }

        [Required]
        [Column("total_amount")]
        public double TotalAmount { get; set; }

        [Required]
        [Column("order_status")]
        public string OrderStatus { get; set; }

        [Required]
        [Column("user_email")]
        public string UserEmail { get; set; } // should be encrypted for security reasons.

        [Required]
        [Column("user_phone")]
        public string UserPhone { get; set; } 

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [Required]
        [Column("order_items", TypeName = "jsonb")]
        public JsonDocument OrderItems { get; set; }
    }
}