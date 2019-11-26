using GraphQL;
using GraphQL.Types;
using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var schema = Schema.For(@"
                type Pokemon {
                    name: String,
                    type: String,
                    id: ID
                }

                type Query {
                    hello: String,
                    pokemons: [Pokemon],
                    pokemon(id: ID): Pokemon
                }
            ", _ =>
            {
                _.Types.Include<Query>();
            });

            var root = new { Hello = "Hello World!" };
            var json = schema.Execute(_ =>
            {
                _.Query = "{ pokemons(id: 1) { name, type } }";
                _.Root = root;
            });

            Console.WriteLine(json);
        }
    }
}
