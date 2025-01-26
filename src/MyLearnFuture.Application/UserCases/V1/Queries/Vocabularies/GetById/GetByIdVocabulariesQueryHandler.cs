using MediatR;
using MyLearnFuture.Domain.Abstractions.Repositories;
using MyLearnFuture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnFuture.Application.UserCases.V1.Queries.Vocabularies.GetById;

public class GetByIdVocabulariesQueryHandler : IRequestHandler<GetByIdVocabulariesQuery, VocabulariesEntity>
{
    private readonly IVocabulariesRepository _vocabulariesRepository;
    public GetByIdVocabulariesQueryHandler(IVocabulariesRepository vocabulariesRepository)
    {
        _vocabulariesRepository = vocabulariesRepository;
    }
    public async Task<VocabulariesEntity> Handle(GetByIdVocabulariesQuery request, CancellationToken cancellationToken)
    {
        return await _vocabulariesRepository.GetByIdAsync(request.Id);
    }
}
