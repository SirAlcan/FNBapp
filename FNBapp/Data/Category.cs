using System.ComponentModel.DataAnnotations;

namespace FNBapp.Data
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter Name..")]
        public string Name { get; set; }
    }
}
