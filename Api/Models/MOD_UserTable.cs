using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class MOD_UserTable
    {
        [Key]
        public int id_usr { get; set; }

        [Required]
        [StringLength(50)]
        public string first_names_usr { get; set; }

        [Required]
        [StringLength(50)]
        public string last_names_usr { get; set; }

        [Required]
        [StringLength(15)]
        public string phone_usr { get; set; }

        [Required]
        [StringLength(80)]
        public string address_usr { get; set; }

        [Required]
        public int city_usr { get; set; }
    }
}
