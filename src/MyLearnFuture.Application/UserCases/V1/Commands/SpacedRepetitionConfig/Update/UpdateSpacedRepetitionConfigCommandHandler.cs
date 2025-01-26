using MediatR;
using MyLearnFuture.Domain.Abstractions.Repositories;
using MyLearnFuture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnFuture.Application.UserCases.V1.Commands.SpacedRepetitionConfig.Update;

public class UpdateSpacedRepetitionConfigCommandHandler : IRequestHandler<UpdateSpacedRepetitionConfigCommand, SpacedRepetitionConfigEntity>
{
    private ISpacedRepetitionConfigRepository _spacedRepetitionConfigRepository;
    public UpdateSpacedRepetitionConfigCommandHandler(ISpacedRepetitionConfigRepository spacedRepetitionConfigRepository)
    {
        _spacedRepetitionConfigRepository = spacedRepetitionConfigRepository;
    }
    public Task<SpacedRepetitionConfigEntity> Handle(UpdateSpacedRepetitionConfigCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
