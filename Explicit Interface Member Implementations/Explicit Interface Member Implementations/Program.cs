using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Interface_Member_Implementations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card cs = new Card(Card.CardSuite.spades, Card.CardValue.queen);
            // Use of Value from Card 
            Console.WriteLine(cs.Value);
            // Must cast to use the implementation of 
            // Value from IGameObject 
            Console.WriteLine(((IGameObject)cs).Value);
        }
    }
}
