﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebService.Models
{
    [Table("Ingredients")]
    public class Ingredient
    {
        [Key]
        public int Id_Ingredient { get; set; }

        [StringLength(15)]
        [Index(IsUnique = true)]
        public string Name { get; set; }
        public double Price { get; set; }

        public virtual ICollection<IngredientOfOfferedPizza> IngredientsOfOfferedPizza { get; set; }
        public virtual ICollection<IngredientOfOrderedPizza> IngredientsOfOrderedPizza { get; set; }

        public Ingredient() { }
    }
}