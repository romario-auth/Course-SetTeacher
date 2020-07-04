using System.Collections.Generic;

namespace Teacher.Services
{
    class Statistics
    {
        public HashSet<int> Students = new HashSet<int>();

        public Statistics()
        {

        }

        public void AddStudents(int id)
        {
            Students.Add(id);
        }

        public int TotalStudents()
        {
            return Students.Count;
        }
    }
}