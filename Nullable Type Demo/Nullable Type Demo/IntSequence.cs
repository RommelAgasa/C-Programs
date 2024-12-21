using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_Type_Demo
{
    internal class IntSequence
    {

        private int[] sequence;

        public IntSequence(params int[] elements)
        {
            sequence = new int[elements.Length];
            for(int i = 0; i < elements.Length; i++)
            {
                sequence[i] = elements[i];
            }
        }

        public int? Min()
        {
            int theMinimum;
            if (sequence.Length == 0) return null;
            theMinimum = sequence[0];
            for(int i = 1; i < sequence.Length; i++)
                if(sequence[i] < theMinimum)
                    theMinimum = sequence[i];
            return theMinimum;
        }

        public int? Max()
        {
            int theMaximum;
            if (sequence.Length == 0) return null;
            theMaximum = sequence[0];
            for (int i = 1; i < sequence.Length; i++)
                if (sequence[i] < theMaximum)
                    theMaximum = sequence[i];
            return theMaximum;

        }
    }
}
