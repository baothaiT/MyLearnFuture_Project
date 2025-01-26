using MediatR;
using MyLearnFuture.Domain.Abstractions.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnFuture.Application.UserCases.V1.Commands.SpacedRepetitionConfig.Create;

public class CreateSpacedRepetitionConfigCommandHandler: IRequestHandler<CreateSpacedRepetitionConfigCommand, bool>
{
    private ISpacedRepetitionConfigRepository _spacedRepetitionConfigRepository;
    public CreateSpacedRepetitionConfigCommandHandler(ISpacedRepetitionConfigRepository spacedRepetitionConfigRepository)
    {
        _spacedRepetitionConfigRepository = spacedRepetitionConfigRepository;
    }
    public Task<bool> Handle(CreateSpacedRepetitionConfigCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
