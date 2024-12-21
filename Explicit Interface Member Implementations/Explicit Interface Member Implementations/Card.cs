using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Interface_Member_Implementations
{
    internal class Card : IGameObject
    {
        public enum CardSuite { spades, hearts, clubs, diamonds };
        public enum CardValue
        {
            two = 2, three = 3, four = 4, five = 5,
            six = 6, seven = 7, eight = 8, nine = 9,
            ten = 10, jack = 11, queen = 12, king = 13,
            ace = 14
        };

        private CardSuite suite;
        private CardValue value;

        public Card(CardSuite suite, CardValue value)
        {
            this.suite = suite;
            this.value = value;
        }

        public CardSuite Suite { get { return suite; } }

        public CardValue Value { get { return value; } }

        public override String ToString()
        {
            return String.Format("Suite:{0}, Value:{1}", suite, value);
        }
        int IGameObject.Value
        {
            get { return (int)(this.value); }
        }


        public GameObjectMedium Medium
        {
            get
            {
                return GameObjectMedium.Paper;
            }
        }

    }
}
