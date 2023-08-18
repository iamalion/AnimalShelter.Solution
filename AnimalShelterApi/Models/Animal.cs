// using System.ComponentModel.DataAnnotations;

namespace AnimalShelterApi.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        // [Required]
        public string Name { get; set; }
        // [Required]
        public string Species { get; set; }
        public string Breed { get; set; }
        // [Range(0, 30, ErrorMessage ="Age must be between 0 and 30")]
        public int Age { get; set; }
        public string Description { get; set; }
        public bool Available { get; set; }
    }
}