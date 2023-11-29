
namespace Lab11
{
    public class Filter
    {
        /// <summary>
        /// Проста фільтрація
        /// </summary>
        public static IEnumerable<Person> SearchByFields(IEnumerable<Person> persons, string searchTerm)
        {
            return persons
                .Where(p => p.FirstName.Contains(searchTerm) || p.LastName.Contains(searchTerm) ||
                            p.Age.ToString().Contains(searchTerm) || p.Weight.ToString().Contains(searchTerm) ||
                            p.Height.ToString().Contains(searchTerm))
                .ToList();
        }

        /// <summary>
        /// Складена фільтрація
        /// </summary>
        public static IEnumerable<Person> FilterPersons(IEnumerable<Person> persons, object filterCriteria)
        {
            var filteredPersons = persons.AsQueryable();

            foreach (var property in filterCriteria.GetType().GetProperties())
            {
                if (property.GetValue(filterCriteria) != null)
                {
                    filteredPersons = filteredPersons.Where(p => p.GetType().GetProperty(property.Name).GetValue(p).Equals(property.GetValue(filterCriteria)));
                }
            }

            return filteredPersons.ToList();
        }


        //Знаходження мінімальних, максимальних та середніх значень полів Age, Weight, Height
        public static int GetMaxAge(IEnumerable<Person> persons)
        {
            return persons.Max(p => p.Age);
        }
        public static double GetMaxWeight(IEnumerable<Person> persons)
        {
            return persons.Max(p => p.Weight);
        }
        public static double GetMaxHeight(IEnumerable<Person> persons)
        {
            return persons.Max(p => p.Height);
        }
        public static int GetMinAge(IEnumerable<Person> persons)
        {
            return persons.Max(p => p.Age);
        }
        public static double GetMinWeight(IEnumerable<Person> persons)
        {
            return persons.Max(p => p.Age);
        }
        public static double GetMinHeight(IEnumerable<Person> persons)
        {
            return persons.Max(p => p.Age);
        }
        public static double GetAverageAge(IEnumerable<Person> persons)
        {
            return persons.Average(p => p.Age);
        }
        public static double GetAverageWeight(IEnumerable<Person> persons)
        {
            return persons.Average(p => p.Age);
        }
        public static double GetAverageHeight(IEnumerable<Person> persons)
        {
            return persons.Average(p => p.Age);
        }
    }
}
