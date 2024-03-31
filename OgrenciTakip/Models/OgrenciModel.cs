using System.ComponentModel.DataAnnotations;

namespace OgrenciTakip.Models
{
    public class OgrenciModel
    {
        [Required(ErrorMessage = "İsim Soyisim alanı boş bırakılamaz.")]
        [Range(1, 1000, ErrorMessage = "1 ile 1000 arasında olmalı.")]
        [Display(Name = "Okul Numarası: *")]
        public int OkulNo { get; set; }

        [Required(ErrorMessage = "İsim Soyisim alanı boş bırakılamaz.")]
        [StringLength(50, ErrorMessage = "7 karekterden az, 50 karakterden fazla girilmez.", MinimumLength = 7)]
        [Display(Name = "İsmi Soyisimi: *")]
        public string IsimSoyisim { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz.")]
        [Display(Name = "Sınıfı/Şubesi: *")]
        public string Sinifi { get; set; }

        [Required(ErrorMessage = "E-Posta adresi boş bırakılamaz.")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Geçerli E-Posta adresi giriniz.")]
        [Display(Name = "E-Posta Adresi: *")]
        public string Eposta { get; set; }

        [Display(Name = "Okuduğu Alan:")]
        public string Alani { get; set; }
     }
}
