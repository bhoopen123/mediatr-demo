using DemoLibrary.Models;

namespace DemoLibrary.DataAccess
{
    public interface IDataAccess
    {
        PersonModel AddPerson(string firstName, string lastName);
        List<PersonModel> GetPeople();
    }
}