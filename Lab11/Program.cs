using System.Text.Json;
using static Lab11.Filter;

namespace Lab11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonFilePath = "MOCK_DATA.json";
            IEnumerable<Person> persons;
            FileStream file = new FileStream(jsonFilePath, FileMode.Open);
            persons = JsonSerializer.Deserialize<IEnumerable<Person>>(file) ??Enumerable.Empty<Person>();
            Console.WriteLine(persons.Count());

            //IEnumerable<Person> filteredPersons = SearchByFields(persons, "Tom");
            //foreach (Person person in filteredPersons)
            //{
            //    Console.WriteLine(person);
            //}

            IEnumerable<Person> filteredPersons = FilterPersons(persons, new { FirstName = "Tom", LastName = "Tom" });
            foreach (Person person in filteredPersons)
            {
                Console.WriteLine(person);
            }



            Console.WriteLine($"Max age in list is: {GetMaxAge(persons)};");
            Console.WriteLine($"Min age in list is: {GetMaxAge(persons)};");
            Console.WriteLine($"Average age in list is: {GetMaxAge(persons)};");
            Console.WriteLine($"Max weight in list is: {GetMaxWeight(persons)};");
            Console.WriteLine($"Min weight in list is: {GetMaxWeight(persons)};");
            Console.WriteLine($"Average weight in list is: {GetMaxWeight(persons)};");
            Console.WriteLine($"Max height in list is: {GetMaxHeight(persons)} ;");
            Console.WriteLine($"Min height in list is: {GetMaxHeight(persons)} ;");
            Console.WriteLine($"Average height in list is: {GetMaxHeight(persons)} ;");
        }
    }
}