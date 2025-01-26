using MediatR;
using MyLearnFuture.Domain.Abstractions.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnFuture.Application.UserCases.V1.Commands.Vocabularies.Delete;

public class DeleteVocabulariesCommandHandler : IRequestHandler<DeleteVocabulariesCommand, bool>
{
    private readonly IVocabulariesRepository _vocabulariesRepository;
    public DeleteVocabulariesCommandHandler(IVocabulariesRepository vocabulariesRepository)
    {
        _vocabulariesRepository = vocabulariesRepository;
    }
    public Task<bool> Handle(DeleteVocabulariesCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
