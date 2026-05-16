using System.ComponentModel.DataAnnotations;

namespace MotoStudio.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public E Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;




    }
}
