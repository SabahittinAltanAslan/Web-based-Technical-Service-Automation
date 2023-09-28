using System.ComponentModel.DataAnnotations;

namespace TknkService.Models
{
    public class Personel
    {
        [Key]
        public int perId { get; set; }
        public string perAd { get; set; }

        public string sifre { get; set; }
    }
}
