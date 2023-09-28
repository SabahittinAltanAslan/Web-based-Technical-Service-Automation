using System.ComponentModel.DataAnnotations;

namespace TknkService.Models
{
    public class Musteri
    {
        [Key]
        public int Musteriid { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string adres { get; set; }
        public string telefon { get; set; }
        public Cihaz chz { get; set; }
    }
}
