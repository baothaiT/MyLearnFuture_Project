using MediatR;
using MyLearnFuture.Application.UserCases.V1.Queries.SpacedRepetitionConfig.GetAll;
using MyLearnFuture.Domain.Abstractions.Repositories;
using MyLearnFuture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnFuture.Application.UserCases.V1.Queries.SpacedRepetitionConfig.GetById;

public class GetByIdSpacedRepetitionConfigQueryHandler : IRequestHandler<GetByIdSpacedRepetitionConfigQuery, SpacedRepetitionConfigEntity>
{
    private readonly ISpacedRepetitionConfigRepository _spacedRepetitionConfigRepository;
    public GetByIdSpacedRepetitionConfigQueryHandler(ISpacedRepetitionConfigRepository spacedRepetitionConfigRepository)
    {
        _spacedRepetitionConfigRepository = spacedRepetitionConfigRepository;
    }

    public async Task<SpacedRepetitionConfigEntity> Handle(GetByIdSpacedRepetitionConfigQuery request, CancellationToken cancellationToken)
    {
        return await _spacedRepetitionConfigRepository.GetByIdAsync(request.Id);
    }
}
