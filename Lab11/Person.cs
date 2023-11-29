using System.Text.RegularExpressions;

namespace Lab11
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private double _weight;
        private double _height;

        public Person(string firstName, string lastName, int age, double weight, double height)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Weight = weight;
            Height = height;
        }

        public string FirstName
        {
            get => _firstName;
            set{
                if (!string.IsNullOrEmpty(value))
                {
                    _firstName = value.Trim();
                }
                else
                {
                    throw new ArgumentException("Incorrect first name of person!");
                }
            }
        }
        public string LastName
        {
            get => _lastName;
            set
            {
                if (!string.IsNullOrEmpty(value) )
                {
                    _lastName = value.Trim();
                }
                else
                {
                    throw new ArgumentException("Incorrect last name of person!");
                }
            }
        }
        public int Age
        {
            get => _age;
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentException($"Incorrect age of person! {value}");
                }
            }
        }
        public double Weight
        {
            get => _weight;
            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
                else
                {
                    throw new ArgumentException($"Incorrect weight of person! {value}");
                }
            }
        }
        public double Height
        {
            get => _height;
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
                else
                {
                    throw new ArgumentException($"Incorrect height of person! {value}");
                }
            }
        }

        public override string ToString()
        {
            return $"First name: {FirstName, -15}" +
                   $"Last name: {LastName, -15}" +
                   $"Age: {Age, -5}"+
                   $"Weight: {Weight, -10}" +
                   $"Height: {Height, -10}";
        }
    }
}
