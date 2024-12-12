using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAuthApp.Models.Entities
{
    [Table("user_account_policy")]
    public class UserAccountPolicy
    {
        [Key]
        public int Id { get; set; }

        public int UserAccountId { get; set; }

        [Required, MaxLength(50)]
        public string UserPolicy { get; set; }

        [Required]
        public bool IsEnabled { get; set; } = false;


    }
}
