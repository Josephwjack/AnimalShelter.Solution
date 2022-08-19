using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
    public class Animal
    {
      public int AnimalId { get; set; }


      [Required]
      [StringLength(30)]
      public string Name { get; set; }

      [Required]
      public string Gender { get; set; }

      [Required]
      public string Species { get; set; }


      public string Breed { get; set; }

      [Required]
      [Range(0, 100)]
      public int Age { get; set; }


      [StringLength(300, ErrorMessage = "Description must be less than 300 characters.")]
      public string Description { get; set; }





    }
}