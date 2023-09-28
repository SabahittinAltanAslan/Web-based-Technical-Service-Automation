using System.ComponentModel.DataAnnotations;

namespace TknkService.Models
{
    public class Cihaz
    {
        [Key]
        public int cihazID { get; set; }
        public string cihazAd { get; set; }
        public string aciklama { get; set; }
        public string cihazDurum { get; set; }
        public List<Musteri> mus { get; set; }

    }
}
