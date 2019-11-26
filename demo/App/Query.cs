using GraphQL;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace App
{
    internal class Query
    {
        [GraphQLMetadata("pokemons")]
        public IEnumerable<Pokemon> GetPokemons()
        {
            return PokeBox.GetPokemons();
        }

        [GraphQLMetadata("pokemon")]
        public Pokemon GetPokemon(int id)
        {
            return PokeBox.GetPokemons().SingleOrDefault(x => x.Id == id);
        }

        [GraphQLMetadata("hello")]
        public string GetHello()
        {
            return "Pokemon Query Selector!!";
        }
    }
}