using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    public class MOD_LocationsSP
    {
        public int Id_cty { get; set; }
        public string Name_cty { get; set; }
        public int Id_ste { get; set; }
        public string Name_ste { get; set; }

        [Key]
        public int Id_cit { get; set; }
        public string Name_cit { get; set; }
    }
}
