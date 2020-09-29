using System.ComponentModel.DataAnnotations;

namespace TodoList.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}