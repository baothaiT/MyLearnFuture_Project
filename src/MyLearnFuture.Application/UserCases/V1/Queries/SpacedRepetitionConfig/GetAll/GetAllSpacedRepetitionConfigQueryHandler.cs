using MediatR;
using MyLearnFuture.Domain.Abstractions.Repositories;
using MyLearnFuture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnFuture.Application.UserCases.V1.Queries.SpacedRepetitionConfig.GetAll;

public class GetAllSpacedRepetitionConfigQueryHandler : IRequestHandler<GetAllSpacedRepetitionConfigQuery, IEnumerable<SpacedRepetitionConfigEntity>>
{
    private readonly ISpacedRepetitionConfigRepository _spacedRepetitionConfigRepository;
    public GetAllSpacedRepetitionConfigQueryHandler(ISpacedRepetitionConfigRepository spacedRepetitionConfigRepository)
    {
        _spacedRepetitionConfigRepository = spacedRepetitionConfigRepository;
    }
    public async Task<IEnumerable<SpacedRepetitionConfigEntity>> Handle(GetAllSpacedRepetitionConfigQuery request, CancellationToken cancellationToken)
    {
        return await _spacedRepetitionConfigRepository.GetAllAsync();
    }
}
