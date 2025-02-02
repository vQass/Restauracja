﻿using System.Collections.Generic;
using System.ComponentModel;

namespace Restauracja_MVC.Models.Recipes
{
    public class RecipesListItem
    {
        [DisplayName("ID dania")]
        public short MealID { get; set; }

        [DisplayName("Danie")]
        public string Meal { get; set; }

        [DisplayName("Kategoria")]
        public string Category { get; set; }

        [DisplayName("Lista składników")]
        public List<string> Ingredientlist { get; set; }
    }
}
