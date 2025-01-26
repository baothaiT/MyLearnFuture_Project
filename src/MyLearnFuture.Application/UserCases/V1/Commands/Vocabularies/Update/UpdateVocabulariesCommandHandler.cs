using MediatR;
using MyLearnFuture.Domain.Abstractions.Repositories;
using MyLearnFuture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnFuture.Application.UserCases.V1.Commands.Vocabularies.Update;

public class UpdateVocabulariesCommandHandler : IRequestHandler<UpdateVocabulariesCommand, VocabulariesEntity>
{
    private readonly IVocabulariesRepository _vocabulariesRepository;
    public UpdateVocabulariesCommandHandler(IVocabulariesRepository vocabulariesRepository)
    {
        _vocabulariesRepository = vocabulariesRepository;
    }
    public Task<VocabulariesEntity> Handle(UpdateVocabulariesCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
