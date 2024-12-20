﻿using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        Category getCategory(int id);
        ICollection<Pokemon> GetPokemonsByCategory(int id);
        bool CategoryExists(int id);
        bool CreateCategory(Category category);
        bool Save();
    }
}
