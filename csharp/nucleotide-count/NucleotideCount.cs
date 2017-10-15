using System;
using System.Collections.Generic;
using System.Linq;

public class NucleotideCount
{
    private readonly string _sequence;

    private readonly char[] _validNucleotides = { 'A', 'C', 'G', 'T' };

    public NucleotideCount(string sequence)
    {
        if (!sequence.All(IsNucleotide))
        {
            throw new InvalidNucleotideException();
        }

        _sequence = sequence;
    }

    public IDictionary<char, int> NucleotideCounts =>
        _validNucleotides.Concat(_sequence)
        .GroupBy(c => c)
        .ToDictionary(g => g.Key, g => g.Count() - 1);

    private bool IsNucleotide(char arg)
    {
        return _validNucleotides.Contains(arg);
    }
}

public class InvalidNucleotideException : Exception { }
