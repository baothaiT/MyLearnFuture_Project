using MediatR;
using MyLearnFuture.Domain.Abstractions.Repositories;
using MyLearnFuture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnFuture.Application.UserCases.V1.Queries.Vocabularies.GetAll;

public class GetAllVocabulariesQueryHandler : IRequestHandler<GetAllVocabulariesQuery, IEnumerable<VocabulariesEntity>>
{
    private readonly IVocabulariesRepository _vocabulariesRepository;
    public GetAllVocabulariesQueryHandler(IVocabulariesRepository vocabulariesRepository)
    {
        _vocabulariesRepository = vocabulariesRepository;
    }
    public async Task<IEnumerable<VocabulariesEntity>> Handle(GetAllVocabulariesQuery request, CancellationToken cancellationToken)
    {
        return await _vocabulariesRepository.GetAllAsync();
    }
}
