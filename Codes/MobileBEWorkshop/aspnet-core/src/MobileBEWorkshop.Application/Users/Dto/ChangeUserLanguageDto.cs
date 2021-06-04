using System.ComponentModel.DataAnnotations;

namespace MobileBEWorkshop.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}