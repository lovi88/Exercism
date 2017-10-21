using System.Collections.Generic;
using System.Linq;

namespace GradeSchool
{
    public class School
    {
        readonly IDictionary<int, List<string>> _grades = new Dictionary<int, List<string>>();

        public void Add(string student, int grade)
        {
            if (!_grades.ContainsKey(grade))
            {
                _grades.Add(grade, new List<string>());
            }

            _grades[grade].Add(student);
        }

        public IEnumerable<string> Roster()
            => _grades
                .SelectMany(gradePair => gradePair.Value,
                    (gradePair, student) => new { Grade = gradePair.Key, Student = student })
                .OrderBy(g => g.Grade).ThenBy(g => g.Student)
                .Select(g => g.Student);

        public IEnumerable<string> Grade(int grade)
            => _grades.ContainsKey(grade)
                ? _grades[grade].OrderBy(name => name) as IEnumerable<string>
                : new string[0];
    }
}