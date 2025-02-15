using DemoLibrary.Commands;
using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary.Handlers
{
    public class CreatePersonHandler : IRequestHandler<CreatePersonCommand, PersonModel>
    {
        private readonly IDataAccess dataAccess;

        public CreatePersonHandler(IDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public Task<PersonModel> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(dataAccess.AddPerson(request.FirstName, request.LastName));
        }
    }
}
