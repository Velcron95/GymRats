using System.ComponentModel.DataAnnotations;

namespace GymRats.Data.Models
{
    public class Ingredients
    {
        [Key]
        public int IngredientsId { get; set; }
        public string Name { get; set; }
        public int Protein {  get; set; }
        public int Calorie { get; set; }
    }
}
