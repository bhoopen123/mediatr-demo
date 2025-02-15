using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;

namespace DemoLibrary.Handlers
{
    public class GetPersonByIdHandler : IRequestHandler<GetPersonByIdQuery, PersonModel?>
    {
        private readonly IMediator mediator;

        public GetPersonByIdHandler(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<PersonModel?> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        {
            var allPersons = await mediator.Send(new GetPersonListQuery());

            var output = allPersons.FirstOrDefault(p => p.Id == request.personId);

            return output;
        }
    }
}
