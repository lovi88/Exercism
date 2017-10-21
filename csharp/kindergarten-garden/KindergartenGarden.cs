using System;
using System.Collections.Generic;
using System.Linq;

namespace KindergartenGarden
{
    public enum Plant
    {
        Violets,
        Radishes,
        Clover,
        Grass
    }

    public class KindergartenGarden
    {
        private readonly List<string> _students;
        private readonly List<List<Plant>> _rows;

        public KindergartenGarden(string diagram)
            : this(diagram, new[]{ "Alice", "Bob", "Charlie", "David", "Eve", "Fred",
                "Ginny", "Harriet", "Ileana", "Joseph", "Kincaid", "Larry" })
        { }

        public KindergartenGarden(string diagram, IEnumerable<string> students)
        {
            _students = students.OrderBy(s => s).ToList();
            _rows = diagram.Split("\n").Select(ToPlants).ToList();
        }

        public IEnumerable<Plant> Plants(string student)
        {
            var rowIdx = _students.IndexOf(student) * 2;
            return _rows.Select(row => new[] { row[rowIdx], row[rowIdx + 1] }).SelectMany(plants => plants);
        }

        private static List<Plant> ToPlants(string str) => str.Select(ToPlant).ToList();

        private static Plant ToPlant(char str)
        {
            switch (str)
            {
                case 'V':
                    return Plant.Violets;
                case 'R':
                    return Plant.Radishes;
                case 'C':
                    return Plant.Clover;
                case 'G':
                    return Plant.Grass;
                default:
                    throw new ArgumentException();
            }
        }
    }
}