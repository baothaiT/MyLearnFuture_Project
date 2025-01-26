using MediatR;
using MyLearnFuture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearnFuture.Application.UserCases.V1.Commands.Vocabularies.Delete;

public class DeleteVocabulariesCommand : IRequest<bool>
{
    public Guid Id { get; set; }
}
