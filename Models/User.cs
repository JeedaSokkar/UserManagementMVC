using System.ComponentModel.DataAnnotations;

namespace MvcUsersProject.Models
{
    public class User
    {
        public int Id { get; set; }
        [MinLength(4)]
        [MaxLength(30)]
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Range(20,50)]
        public int Age { get; set; }
        [Range(0,50)]
        public decimal Score { get; set; }
    }
}
