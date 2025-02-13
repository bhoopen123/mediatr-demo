using DemoLibrary.Models;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModel> people = new();
        private static int counter = 0;
        public DemoDataAccess()
        {
            people.Add(new PersonModel { Id = 1, FirstName = "Tim", LastName = "Corey" });
            people.Add(new PersonModel { Id = 1, FirstName = "Sue", LastName = "Storm" });
        }

        public List<PersonModel> GetPeople()
        {
            return people;
        }

        public PersonModel AddPerson(string firstName, string lastName)
        {
            counter++;
            PersonModel p = new PersonModel { Id = counter, FirstName = firstName, LastName = lastName };
            people.Add(p);
            return p;
        }
    }
}
