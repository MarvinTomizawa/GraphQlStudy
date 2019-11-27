using System;
using System.Collections.Generic;

namespace App
{
    internal class PokeBox
    {
        internal static IEnumerable<Pokemon> GetPokemons()
        {
            return new List<Pokemon>()
            {
                new Pokemon() { Name ="Charmander", Type="Fire"},
                new Pokemon() { Name ="Bulbassaur", Type="Grass"},
                new Pokemon() { Name ="Squirdle", Type="Water"}
            };
        }
    }
}