using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WarframeMarketCore.Models
{
    public class Person
    {
        [Key]
        public Guid ID { get; set; }


        [Required]
        [Display(Name = "Логин")]
        public string login { get; set; }


        [Required]
        [MaxLength(12, ErrorMessage = "Пароль слишком длинный, максимальное значение 12 символов")]
        [MinLength(6, ErrorMessage = "Пароль слишком короткий, минимальное значение 6 символов")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string password { get; set; }


        [Required]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        [Display(Name = "Подтвердить пароль")]
        public string passwordconfirm { get; set; }
    }
}
