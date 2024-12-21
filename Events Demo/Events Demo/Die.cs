﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Demo
{
    public delegate void Notifier(string message);
    internal class Die
    {
        private int numberOfEyes;
        private Random randomNumberSupplier;
        private int maxNumberOfEyes;
        private List<int> history;
        public event Notifier twoSixesInARow;

        public int NumberOfEyes
        {
            get { return numberOfEyes; }
        }

        public Die() : this(6) { }

        public Die(int maxNumberOfEyes)
        {
            randomNumberSupplier = new Random(unchecked((int)DateTime.Now.Ticks));
            this.maxNumberOfEyes = maxNumberOfEyes;
            numberOfEyes = randomNumberSupplier.Next(1, maxNumberOfEyes + 1);
            history = new List<int>();
            history.Add(numberOfEyes);
            
        }

        public void Toss()
        {
            numberOfEyes = randomNumberSupplier.Next(1, maxNumberOfEyes + 1);
            history.Add(NumberOfEyes);
            if (DoWeHaveTwoSixInARow(history))
                twoSixesInARow("Two sixes in a row.");
        }

        private bool DoWeHaveTwoSixInARow(List<int> history)
        {
            int histLength = history.Count;
            return histLength >= 2 && history[histLength - 1] == 6 && history[histLength - 2] == 6;
        }

        public override String ToString()
        {
            return String.Format("Die[{0}]: {1}", maxNumberOfEyes, NumberOfEyes);
        }
    }
}
