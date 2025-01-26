using MediatR;
using MyLearnFuture.Domain.Abstractions.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnFuture.Application.UserCases.V1.Commands.SpacedRepetitionConfig.Delete;

public class DeleteSpacedRepetitionConfigCommandHandler : IRequestHandler<DeleteSpacedRepetitionConfigCommand, bool>
{
    private ISpacedRepetitionConfigRepository _spacedRepetitionConfigRepository;
    public DeleteSpacedRepetitionConfigCommandHandler(ISpacedRepetitionConfigRepository spacedRepetitionConfigRepository)
    {
        _spacedRepetitionConfigRepository = spacedRepetitionConfigRepository;
    }
    public Task<bool> Handle(DeleteSpacedRepetitionConfigCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
