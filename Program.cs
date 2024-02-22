namespace SelectingDataUsingLINQ
{
    public record Person(string FirstName, string LastName, int Age);
    internal class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>
            {
                new Person("Nicholas", "Mamau", 34),
                new Person("Ken", "Njuguna", 32),
                new Person("Ken", "Njuguna", 32),
                new Person("Ken", "Njenga", 36),
                new Person("Paul", "Kiprotech", 37),
                new Person("Isaac", "Soita",37),
                new Person("James", "Kimani", 44)
            };

            var LastNames = persons.Select(person => person.LastName);

            foreach (var lastname in LastNames) 
            {
                Console.WriteLine(lastname);
            }

            Console.WriteLine("\n_________\n");
            var ageBetween20and30 = persons
                .Where(person => person.Age >= 30 && person.Age <= 40)
                .Select(person => person.Age);

            foreach (var age in ageBetween20and30)
            {
                Console.WriteLine(age);
            }

            Console.WriteLine("\n_________\n");

            var firstPerson = persons.First();
            var lastPerson = persons.Last();
            Console.WriteLine(firstPerson.FirstName);
            Console.WriteLine(lastPerson.FirstName);

            Console.WriteLine("\n_________\n");

            foreach (var person in persons.Skip(1).Take(2))
            {
                Console.WriteLine( person.FirstName);
            }
        }
    }
}