using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    public class PokemonRepository : IPokemonRepository
    {
        private DataContext _context;
        public PokemonRepository(DataContext context) { 
            this._context = context;
        }

        public Pokemon GetPokemon(int id)
        {
            return _context.Pokemons.Where(p => p.Id == id).FirstOrDefault();
        }

        public Pokemon GetPokemon(string name)
        {
            throw new NotImplementedException();
        }

        public ICollection<Pokemon> GetPokemons()
        {
            var pokemons = _context.Pokemons.OrderBy(p => p.Id).ToList();
            Console.WriteLine($"Retrieved {pokemons.Count} Pokemons.");
            return pokemons;
        }

        public bool PokemonExists(int pokeId)
        {
            return _context.Pokemons.Any(p => p.Id == pokeId);
        }
    }
}
