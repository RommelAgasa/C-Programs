using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Die d1 = new Die(),
                d2 = new Die(10),
                d3 = new Die(8);

            Card c1 = new Card(Card.CardSuite.spades, Card.CardValue.queen),
                 c2 = new Card(Card.CardSuite.clubs, Card.CardValue.four),
                 c3 = new Card(Card.CardSuite.diamonds, Card.CardValue.ace);

            IGameObject[] gameObjects = {d1, d2, d3, c1, c2, c3};

            foreach (IGameObject gameObject in gameObjects)
                Console.WriteLine($"{gameObject}: {gameObject.GameValue}, {gameObject.Medium}");

        }
    }
}
