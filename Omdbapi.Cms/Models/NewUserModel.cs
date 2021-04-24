using System.ComponentModel.DataAnnotations;

namespace Omdbapi.Cms.Models
{
    public class NewUserModel
    {
        [Required(ErrorMessage = "Lütfen doldurunuz")]
        [MinLength(3)]
        public string UserName { get; set; }
         [Required]
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*[^a-zA-Z])(.{6,9})$", ErrorMessage = "Lütfen en az 6 karakter, Bir Büyük Harf ve Bir Küçük harf Giriniz.")]
        public string Password { get; set; }
        [MinLength(3)]
        public string Name { get; set; }
        public string SurName { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Lütfen doldurunuz")]
        public string Emails { get; set; }
        public string Phone { get; set; }

    }
}
