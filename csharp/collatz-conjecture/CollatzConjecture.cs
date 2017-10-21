using System;
using System.Diagnostics;

namespace CollatzConjecture
{
    public static class CollatzConjecture
    {
        public static int Steps(int number)
        {
            ValidateInputs();

            return MakeSteps();

            int MakeSteps()
            {
                var times = 0;

                while (number != 1)
                {
                    times++;

                    number = number % 2 == 0
                        ? number / 2
                        : number * 3 + 1;
                }

                return times;
            }

            void ValidateInputs()
            {
                if (number < 1)
                {
                    throw new ArgumentException($"{nameof(number)} must be more or equal to one.");
                }
            }
        }

    }
}