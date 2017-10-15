using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        ISet<int> results = new HashSet<int>();

        foreach (var multiple in multiples)
        {
            for (int i = 1; ; i++)
            {
                var multiplied = i * multiple;

                if (multiplied >= max)
                {
                    break;
                }

                results.Add(multiplied);
            }
        }

        return results.Sum();
    }
}