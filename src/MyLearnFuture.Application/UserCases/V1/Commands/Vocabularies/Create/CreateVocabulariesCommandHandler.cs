using MediatR;
using MyLearnFuture.Domain.Abstractions.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnFuture.Application.UserCases.V1.Commands.Vocabularies.Create;

public class CreateVocabulariesCommandHandler : IRequestHandler<CreateVocabulariesCommand, bool>
{
    private readonly IVocabulariesRepository _vocabulariesRepository;
    public CreateVocabulariesCommandHandler(IVocabulariesRepository vocabulariesRepository)
    {
        _vocabulariesRepository = vocabulariesRepository;
    }
    public Task<bool> Handle(CreateVocabulariesCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
